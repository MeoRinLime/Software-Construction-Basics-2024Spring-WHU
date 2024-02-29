using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext{
        public TodoContext(DbContextOptions<TodoContext> options)
         : base(options) {
         this.Database.EnsureCreated(); //�Զ����⽨��
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}