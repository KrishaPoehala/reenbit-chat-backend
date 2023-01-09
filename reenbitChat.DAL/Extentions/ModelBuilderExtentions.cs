using Bogus;
using Microsoft.EntityFrameworkCore;
using reenbitChat.DAL.Entities;
using System.Text;

namespace reenbitChat.DAL.Extentions;

public static class ModelBuilderExtentions
{
    public static void Configure(this ModelBuilder builder)
    {
        builder.Entity<Message>()
            .HasOne(x => x.Chat)
            .WithMany(x => x.Messages)
            .HasForeignKey(x => x.ChatId);

        builder.Entity<User>()
            .HasMany(x => x.Chats)
            .WithMany(x => x.Members);

        builder.Entity<Chat>()
            .HasMany(x => x.Messages)
            .WithOne(x => x.Chat)
            .HasForeignKey(x => x.ChatId);
    }   

    public static void Seed(this ModelBuilder builder)
    {
        var groups = GenerateGroupes(20);
        var users = GenerateUsersWithoutContacts(10).ToList();
        var messages = GenerateMessages(300, users, groups);
        var chatUsers = GenerateChatUserValues(users, groups);
        builder.Entity<Chat>().HasData(groups);
        builder.Entity<User>().HasData(users);
        builder.Entity<Message>().HasData(messages);
        builder.Entity("ChatUser").HasData(chatUsers);
    }

    
    public class ChatUser
    {
        public int ChatsId { get; set; }
        public int MembersId { get; set; }
    }
    public static IEnumerable<ChatUser> GenerateChatUserValues(
        IEnumerable<User> users, IEnumerable<Chat> groups)
    {
        var faker = new Faker<ChatUser>()
           .RuleFor(x => x.ChatsId, f => f.PickRandom(groups).Id)
           .RuleFor(x => x.MembersId, f => f.PickRandom(users).Id);

        return faker.Generate(200)
            .DistinctBy(x => new { x.ChatsId, x.MembersId })
            .ToList();
    }


    private static IEnumerable<Message> GenerateMessages(int count, 
        IEnumerable<User> users, IEnumerable<Chat> groups)
    {
        var index = 1;
        var faker = new Faker<Message>()
            .RuleFor(x => x.Text, f => f.Lorem.Sentences(2))
            .RuleFor(x => x.ChatId, f => f.PickRandom(groups).Id)
            .RuleFor(x => x.SenderId, f => f.PickRandom(users).Id)
            .RuleFor(x => x.SentAt, f => f.Date.Past())
            .RuleFor(x => x.Id, f => index++);

        return faker.Generate(count);
    }

    private static IEnumerable<User> GenerateUsersWithoutContacts(int count)
    {
        var index = 1;
        var faker = new Faker<User>()
            .RuleFor(x => x.NormalizedEmail, f => f.Internet.Email())
            .RuleFor(x => x.UserName, f => f.Name.FirstName())
            .RuleFor(x => x.ProfilePhotoUrl, f=> f.Image.PicsumUrl(480))
            .RuleFor(x => x.Id, f => index++);


        return faker.Generate(count);
    }

    private static IEnumerable<Chat> GenerateGroupes(int count)
    {
        var index = 1;
        var faker = new Faker<Chat>()
            .RuleFor(x => x.Name, f => f.Company.CompanyName())
            .RuleFor(x => x.ImageUrl, f=> f.Image.PicsumUrl())
            .RuleFor(x => x.Id, f => index++);

        return faker.Generate(count);
    }
}
