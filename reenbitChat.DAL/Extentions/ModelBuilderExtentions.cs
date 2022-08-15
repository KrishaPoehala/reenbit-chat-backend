using Bogus;
using Microsoft.EntityFrameworkCore;
using reenbitChat.DAL.Entities;

namespace reenbitChat.DAL.Extentions;

public static class ModelBuilderExtentions
{
    public static void Configure(this ModelBuilder builder)
    {
        builder.Entity<Message>()
            .HasOne(x => x.Sender)
            .WithMany(x => x.MessagesSent)
            .HasForeignKey(x => x.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Message>()
            .HasOne(x => x.Chat)
            .WithMany(x => x.Messages)
            .HasForeignKey(x => x.ChatId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<User>()
            .HasMany(x => x.MessagesSent)
            .WithOne(x => x.Sender)
            .HasForeignKey(x => x.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<ChatEntity>()
            .HasMany(x => x.Members)
            .WithMany(x => x.Chats);

        builder.Entity<ChatEntity>()
            .HasMany(x => x.Messages)
            .WithOne(x => x.Chat)
            .HasForeignKey(x => x.ChatId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public static void Seed(this ModelBuilder builder)
    {
        var groups = GenerateGroupes(15);
        var users = GenerateUsers(50);
        var messages = GenerateMessages(1000, users, groups);
        builder.Entity<ChatEntity>().HasData(groups);
        builder.Entity<User>().HasData(users);
        builder.Entity<Message>().HasData(messages);
    }

    private static IEnumerable<Message> GenerateMessages(int count, 
        IEnumerable<User> users, IEnumerable<ChatEntity> groups)
    {
        var index = 1;
        var faker = new Faker<Message>()
            .RuleFor(x => x.Text, f => f.Lorem.Sentences(2))
            .RuleFor(x => x.ChatId, f => f.PickRandom(groups).Id)
            .RuleFor(x => x.SenderId, f => f.PickRandom(users).Id)
            .RuleFor(x => x.SentAt, f => f.Date.Future())
            .RuleFor(x => x.Id, f => index++);

        return faker.Generate(count);
    }

    private static IEnumerable<User> GenerateUsers(int count)
    {
        var index = 1;
        var faker = new Faker<User>()
            .RuleFor(x => x.Email, f => f.Internet.Email())
            .RuleFor(x => x.Name, f => f.Name.FirstName())
            .RuleFor(x => x.Id, f => index++);

        return faker.Generate(count);
    }

    private static IEnumerable<ChatEntity> GenerateGroupes(int count)
    {
        var index = 1;
        var faker = new Faker<ChatEntity>()
            .RuleFor(x => x.Name, f => f.Company.CompanyName())
            .RuleFor(x => x.IsGroup, f => true)
            .RuleFor(x => x.Id, f => index++);

        return faker.Generate(count);
    }
}
