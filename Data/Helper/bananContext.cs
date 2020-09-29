using Models;
using Microsoft.EntityFrameworkCore;
namespace Helper{
    public class bananContext:DbContext{
        public bananContext(DbContextOptions<bananContext> opt):base(opt){

        }
        public DbSet<banan> banans {get; set;}
    }
}