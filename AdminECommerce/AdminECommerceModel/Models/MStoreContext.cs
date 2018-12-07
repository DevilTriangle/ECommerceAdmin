using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminECommerceModel.Models
{
    public class MStoreContext: IdentityDbContext<ApplicationUser>
    {
        public MStoreContext()
          : base("name=MStoreConnection")
        {
            //this.Configuration.LazyLoadingEnabled = false;

            //If DbContext.Configuration.ProxyCreationEnabled is set to false, 
            //DbContext will not load child objects for some parent object 
            //unless Include method is called on parent object
            this.Configuration.ProxyCreationEnabled = false;
        }
        public static MStoreContext Create()
        {
            return new MStoreContext();
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        // The following DBSet, I commented because it is table
        //for manage roles of user so we don't need it.
        // one more reason, it affacts manage role of admin
        //public virtual DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.RoleID)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Accounts)
                .Map(m => m.ToTable("Wishlist").MapLeftKey("AccountID").MapRightKey("ProductID"));

            modelBuilder.Entity<Banner>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<Banner>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.LandLine)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Skype)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Facebook)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Gmail)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Twitter)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Instagram)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Working)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.AccountID)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.AccountID)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.OrderID)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.AccountID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Image1)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Image2)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Image3)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Image4)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Promotion>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Promotion>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Promotion>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<Promotion>()
                .Property(e => e.AccountID)
                .IsUnicode(false);
            modelBuilder.Entity<Review>()
               .Property(e => e.ProductId)
               .IsUnicode(false);

            modelBuilder.Entity<Review>()
                .Property(e => e.AccountId)
                .IsUnicode(false);

            //modelBuilder.Entity<Role>()
            //    .Property(e => e.ID)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Role>()
            //    .Property(e => e.RoleName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Role>()
            //    .HasMany(e => e.Accounts)
            //    .WithRequired(e => e.Role)
            //    .WillCascadeOnDelete(false);
        }

        public System.Data.Entity.DbSet<AdminECommerceModel.Models.Role> Roles1 { get; set; }
    }
}
