using Microsoft.EntityFrameworkCore;
using LoveLink.Models;

namespace LoveLink.Data
{
    public class LoveLinkDbContext : DbContext
    {
        public LoveLinkDbContext(DbContextOptions<LoveLinkDbContext> options)
            : base(options)
        {
        }

        public DbSet<Proposal> Proposals { get; set; }
    }
}