using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Data;

internal sealed class CRUD30MinsDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=CRUD30Mins.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Post[] postsToSeed = new Post[6];

        for (int i = 1; i <= 6; i++)
        {
            postsToSeed[i - 1] = new Post
            {
                PostId = i,
                Title = $"Post {i}",
                Content = $"This is post {i}'s content. I have also liked and subscribed."
            };
        }

        modelBuilder.Entity<Post>().HasData(postsToSeed);
    }
}