

namespace ryle.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ryleEntities1 : DbContext
    {
        public ryleEntities1()
            : base("name=ryleEntities1")
        {

        }
        private static ryleEntities1 context;
        public static ryleEntities1 GetContext()
        {
            if (context == null)
                context = new ryleEntities1();
            return context;

        }
        public static users CurrentUser = null;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<merch> merch { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<point> point { get; set; }
        public virtual DbSet<sostav> sostav { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<type_users> type_users { get; set; }
        public virtual DbSet<users> users { get; set; }
    }
}
