namespace UserRepoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TopicsTableChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Topics", "Author_Id", c => c.Int());
            CreateIndex("dbo.Topics", "Author_Id");
            AddForeignKey("dbo.Topics", "Author_Id", "dbo.UserDetails", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Topics", "Author_Id", "dbo.UserDetails");
            DropIndex("dbo.Topics", new[] { "Author_Id" });
            DropColumn("dbo.Topics", "Author_Id");
        }
    }
}
