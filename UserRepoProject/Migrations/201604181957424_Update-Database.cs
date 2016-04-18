namespace UserRepoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        TopicId = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.TopicId);
            
            AlterColumn("dbo.UserDetails", "Name", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.UserDetails", "lastName", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserDetails", "lastName", c => c.String());
            AlterColumn("dbo.UserDetails", "Name", c => c.String());
            DropTable("dbo.Topics");
        }
    }
}
