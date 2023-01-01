using Bogus;
using Microsoft.EntityFrameworkCore;
using reenbitChat.DAL.Entities;
using reenbitChat.DAL.Entities.Messages;
using System.Text;

namespace reenbitChat.DAL.Extentions;

public static class ModelBuilderExtentions
{
    public static void Configure(this ModelBuilder builder)
    {
        builder.Entity<GroupMessage>()
            .HasOne(x => x.Chat)
            .WithMany(x => x.Messages)
            .HasForeignKey(x => x.ChatId);

        builder.Entity<User>()
            .HasMany(x => x.Chats)
            .WithMany(x => x.Members);

        builder.Entity<User>()
            .HasMany(x => x.PrivateMessagesReceived)
            .WithOne(x => x.Receiver)
            .HasForeignKey(x => x.ReceiverId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<User>()
            .HasMany(x => x.PrivateMessagesSent)
            .WithOne(x => x.Sender)
            .HasForeignKey(x => x.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Chat>()
            .HasMany(x => x.Messages)
            .WithOne(x => x.Chat)
            .HasForeignKey(x => x.ChatId);

        builder.Entity<UserContact>()
            .HasOne(x => x.User)
            .WithMany(x => x.Contacts)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<UserContact>()
            .HasOne(x => x.ContactUser)
            .WithMany(x => x.ContactsOf)
            .HasForeignKey(x => x.ContactUserId);

        builder.Entity<UserContact>()
            .HasKey(x => new { x.UserId, x.ContactUserId });

    }   

    public static void Seed(this ModelBuilder builder)
    {
        var groups = GenerateGroupes(20);
        var users = GenerateUsersWithoutContacts(10).ToList();
        var contacts = GenerateContacts(users);
        var messages = GenerateMessages(300, users, groups);
        var chatUsers = GenerateChatUserValues(users, groups);
        var privateMessages = GeneratePrivateMessages(contacts);
        builder.Entity<Chat>().HasData(groups);
        builder.Entity<User>().HasData(users);
        builder.Entity<GroupMessage>().HasData(messages);
        builder.Entity<UserContact>().HasData(contacts);
        builder.Entity<PrivateMessage>().HasData(privateMessages);
        builder.Entity("ChatUser").HasData(chatUsers);
    }

    private static IEnumerable<PrivateMessage> GeneratePrivateMessages(List<UserContact> contacts)
    {
        var index = 1;
        var faker = new Faker<PrivateMessage>()
            .RuleFor(x => x.Id, _ => index++)
            .RuleFor(x => x.Text, f => f.Lorem.Sentence(6));
        var rndFaker = new Faker();

        for (int i = 0; i < contacts.Count; i++)
        {
            var senderId = (int)rndFaker.PickRandom(contacts).UserId;
            var receiverId = (int)rndFaker.PickRandom(contacts.Where(x => x.ContactUserId != senderId))
                .ContactUserId;
            for (int j = 0;j < 20; ++j)
            {
                var pm = faker.Generate();
                pm.SenderId = senderId;
                pm.ReceiverId = receiverId;
                yield return pm;
            }
        }
    }

    private static List<UserContact> GenerateContacts(List<User> users)
    {
        var list = new List<UserContact>(users.Count * users.Count / 3);
        var faker = new Faker();
        for (int i = 0; i < users.Count; i++)
        {
            foreach (var item in faker.PickRandom(users, users.Count / 3)
                .Where(x => x.Id != users[i].Id))
            {
                var userContact = new UserContact
                {
                    UserId = users[i].Id,
                    ContactUserId = item.Id
                };

                list.Add(userContact);
            }
        }

        return list;
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


    private static IEnumerable<GroupMessage> GenerateMessages(int count, 
        IEnumerable<User> users, IEnumerable<Chat> groups)
    {
        var index = 1;
        var faker = new Faker<GroupMessage>()
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
