using PNFun.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PNFun.DAL
{
    public class PNFContext : DbContext
    {
        public PNFContext()
            : base("PNFContext") { }

        public DbSet<BadLink> BadLinkDb { get; set; }
        public DbSet<Category> CategoryDb { get; set; }
        public DbSet<SubCategory> SubCategoryDb { get; set; }
        public DbSet<Comments> CommentsDb { get; set; }
        public DbSet<NonprofitEvent> NonprofitEventDb { get; set; }
        public DbSet<PhotoLink> PhotoLinkDb { get; set; }
        public DbSet<RecreationSite> RecreationSiteDb { get; set; }
        public DbSet<LinkCategoryToSubCategory> LinkCategoryToSiteDb { get; set; }
        public DbSet<LinkSubCategoryToSite> LinkSubCategoryToSiteDb { get; set; }
        public DbSet<Message> MessagesDb { get; set; }
        public DbSet<Reply> RepliesDb { get; set; }
        public DbSet<MessageBoard> MessageBoardsDb { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}