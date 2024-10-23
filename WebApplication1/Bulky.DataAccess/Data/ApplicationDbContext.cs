using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace BulykyWeb.DataAccess.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // 이 한줄로 테이블이 생성됨
        public DbSet<Category> Categories { get; set; }


        // 모델이 생성될때 오버라이딩
        // 생성될때 데이터 3개 추가됨
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id =1, Name ="Action", DisplayOrder = 1},
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
           
        }
    }
}
