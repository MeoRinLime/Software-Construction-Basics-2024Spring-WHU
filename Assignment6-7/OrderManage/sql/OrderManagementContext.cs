using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManage;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace OrderManage.sql
{
    public class OrderManagementContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Goods> Goods { get; set; }

        public void ConnectToDatabase()
        {
            // 与数据库连接的信息
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                UserID = "root",
                Password = "meorin",
                Server = "localhost",
                Database = "ordermanage"
            };

            // 定义与数据连接的链接，并确保通过using语句正确释放资源
            using (MySqlConnection connection = new MySqlConnection(builder.ConnectionString))
            {
                try
                {
                    // 打开这个链接
                    connection.Open();
                    Console.WriteLine("Connection Opened Successfully");

                    // 在此执行数据库操作...

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                // 连接将在using语句结束时自动关闭
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // 连接信息
                string sql = "server=localhost;port=3306;database=ordermanage;user=root;password=meorin;CharSet=utf8;";
                optionsBuilder
                    .UseMySQL(sql)
                    .LogTo(Console.WriteLine, LogLevel.Information)  // 将日志输出到控制台，并设置日志级别为Information
                    .EnableSensitiveDataLogging()                    // 启用敏感数据日志记录，适用于开发环境
                    .EnableDetailedErrors();                         // 启用详细错误信息，有助于调试
            }
        }

        public bool CanQueryDatabase()
        {
            try
            {
                var count = this.Orders.Count();  // 假设有一个 Orders 表
                Console.WriteLine($"Number of orders: {count}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while querying the database: {ex.Message}");
                return false;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 设置每个实体的主键
            modelBuilder.Entity<Order>().HasKey(o => o.OrderId);
            modelBuilder.Entity<Goods>().HasKey(g => g.GoodsId);
            modelBuilder.Entity<OrderDetail>().HasKey(od => new { od.OrderId, od.GoodsId }); 

            // 配置 Order 和 OrderDetail 的一对多关系
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Details)
                .WithOne(d => d.Order)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // 删除订单时，相关的订单明细也应被删除

            // 配置 Goods 和 OrderDetail 的一对多关系
            modelBuilder.Entity<Goods>()
                .HasMany(g => g.OrderDetails)
                .WithOne(d => d.Goods)
                .HasForeignKey(d => d.GoodsId)
                .OnDelete(DeleteBehavior.Restrict); // 删除商品时不删除订单明细，防止数据丢失
        }

    }
}