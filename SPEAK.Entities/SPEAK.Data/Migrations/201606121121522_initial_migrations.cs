namespace SPEAK.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_migrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        SectionAssignID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employee", t => t.EmployeeID)
                .ForeignKey("dbo.SectionAssign", t => t.SectionAssignID)
                .Index(t => t.SectionAssignID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        LocationID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        GenderID = c.Int(nullable: false),
                        NationalityID = c.Int(nullable: false),
                        JoblevelID = c.Int(nullable: false),
                        ServicelengthID = c.Int(nullable: false),
                        CurrentSectionID = c.Int(),
                        IsRegistered = c.Boolean(nullable: false),
                        RegistrationDatetime = c.DateTime(),
                        IsDistributed = c.Boolean(nullable: false),
                        DistributionDatetime = c.DateTime(),
                        IsSurveyCompleted = c.Boolean(nullable: false),
                        SurveyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.SectionAssign", t => t.CurrentSectionID)
                .ForeignKey("dbo.Department", t => t.DepartmentID)
                .ForeignKey("dbo.Gender", t => t.GenderID)
                .ForeignKey("dbo.Joblevel", t => t.JoblevelID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.Nationality", t => t.NationalityID)
                .ForeignKey("dbo.Servicelength", t => t.ServicelengthID)
                .ForeignKey("dbo.Survey", t => t.SurveyID)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.LocationID)
                .Index(t => t.DepartmentID)
                .Index(t => t.GenderID)
                .Index(t => t.NationalityID)
                .Index(t => t.JoblevelID)
                .Index(t => t.ServicelengthID)
                .Index(t => t.CurrentSectionID)
                .Index(t => t.SurveyID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(),
                        CreatorId = c.Int(),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Username = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 200),
                        HashedPassword = c.String(nullable: false, maxLength: 200),
                        Salt = c.String(nullable: false, maxLength: 200),
                        IsLocked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Code = c.String(maxLength: 3),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Code = c.String(maxLength: 3),
                        Name = c.String(nullable: false, maxLength: 50),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Country", t => t.CountryId)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Code = c.String(maxLength: 3),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        LocationID = c.Int(nullable: false),
                        OwnerID = c.Int(),
                        IsParent = c.Boolean(nullable: false),
                        ParentID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.User", t => t.OwnerID)
                .ForeignKey("dbo.Department", t => t.ParentID)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.LocationID)
                .Index(t => t.OwnerID)
                .Index(t => t.ParentID);
            
            CreateTable(
                "dbo.QuestionAssign",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        QuestionID = c.Int(nullable: false),
                        SurveyID = c.Int(nullable: false),
                        SectionAssignID = c.Int(nullable: false),
                        LocationID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.Department", t => t.DepartmentID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.Question", t => t.QuestionID)
                .ForeignKey("dbo.SectionAssign", t => t.SectionAssignID)
                .ForeignKey("dbo.Survey", t => t.SurveyID)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.QuestionID)
                .Index(t => t.SurveyID)
                .Index(t => t.SectionAssignID)
                .Index(t => t.LocationID)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId);
            
            CreateTable(
                "dbo.QuestionOther",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        QuestionID = c.Int(nullable: false),
                        LanguageID = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.Language", t => t.LanguageID)
                .ForeignKey("dbo.Question", t => t.QuestionID)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.QuestionID)
                .Index(t => t.LanguageID);
            
            CreateTable(
                "dbo.Language",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Code = c.String(),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId);
            
            CreateTable(
                "dbo.Rating",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        QuestionAssignID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employee", t => t.EmployeeID)
                .ForeignKey("dbo.QuestionAssign", t => t.QuestionAssignID)
                .Index(t => t.QuestionAssignID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.SectionAssign",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        SectionID = c.Int(nullable: false),
                        SurveyID = c.Int(nullable: false),
                        LocationID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.Department", t => t.DepartmentID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.Section", t => t.SectionID)
                .ForeignKey("dbo.Survey", t => t.SurveyID)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.SectionID)
                .Index(t => t.SurveyID)
                .Index(t => t.LocationID)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Section",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId);
            
            CreateTable(
                "dbo.Survey",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        LocationID = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.LocationID);
            
            CreateTable(
                "dbo.TotalGender",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        GenderID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.Department", t => t.DepartmentID)
                .ForeignKey("dbo.Gender", t => t.GenderID)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.GenderID)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Gender",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId);
            
            CreateTable(
                "dbo.TotalJoblevel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        JoblevelID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.Department", t => t.DepartmentID)
                .ForeignKey("dbo.Joblevel", t => t.JoblevelID)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.JoblevelID)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Joblevel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId);
            
            CreateTable(
                "dbo.TotalNationality",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        NationalityID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.Department", t => t.DepartmentID)
                .ForeignKey("dbo.Nationality", t => t.NationalityID)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.NationalityID)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Nationality",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId);
            
            CreateTable(
                "dbo.TotalServicelength",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        ServicelengthID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.Department", t => t.DepartmentID)
                .ForeignKey("dbo.Servicelength", t => t.ServicelengthID)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.ServicelengthID)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Servicelength",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        User_ID = c.Int(),
                        User_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .ForeignKey("dbo.User", t => t.User_ID)
                .ForeignKey("dbo.User", t => t.User_ID1)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.User_ID)
                .Index(t => t.User_ID1);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UserID = c.Int(nullable: false),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.CreatorId)
                .ForeignKey("dbo.Role", t => t.RoleID)
                .ForeignKey("dbo.User", t => t.UpdatorId)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.CreatorId)
                .Index(t => t.UpdatorId)
                .Index(t => t.UserID)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.Error",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatorId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Message = c.String(),
                        StackTrace = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comment", "SectionAssignID", "dbo.SectionAssign");
            DropForeignKey("dbo.Comment", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.Employee", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.Employee", "SurveyID", "dbo.Survey");
            DropForeignKey("dbo.Employee", "ServicelengthID", "dbo.Servicelength");
            DropForeignKey("dbo.Employee", "NationalityID", "dbo.Nationality");
            DropForeignKey("dbo.Employee", "LocationID", "dbo.Location");
            DropForeignKey("dbo.Employee", "JoblevelID", "dbo.Joblevel");
            DropForeignKey("dbo.Employee", "GenderID", "dbo.Gender");
            DropForeignKey("dbo.Employee", "DepartmentID", "dbo.Department");
            DropForeignKey("dbo.Employee", "CurrentSectionID", "dbo.SectionAssign");
            DropForeignKey("dbo.Employee", "CreatorId", "dbo.User");
            DropForeignKey("dbo.Role", "User_ID1", "dbo.User");
            DropForeignKey("dbo.Role", "User_ID", "dbo.User");
            DropForeignKey("dbo.UserRole", "UserID", "dbo.User");
            DropForeignKey("dbo.UserRole", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.UserRole", "RoleID", "dbo.Role");
            DropForeignKey("dbo.UserRole", "CreatorId", "dbo.User");
            DropForeignKey("dbo.Role", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.Role", "CreatorId", "dbo.User");
            DropForeignKey("dbo.Country", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.Location", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.Department", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.TotalServicelength", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.TotalServicelength", "ServicelengthID", "dbo.Servicelength");
            DropForeignKey("dbo.Servicelength", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.Servicelength", "CreatorId", "dbo.User");
            DropForeignKey("dbo.TotalServicelength", "DepartmentID", "dbo.Department");
            DropForeignKey("dbo.TotalServicelength", "CreatorId", "dbo.User");
            DropForeignKey("dbo.TotalNationality", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.TotalNationality", "NationalityID", "dbo.Nationality");
            DropForeignKey("dbo.Nationality", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.Nationality", "CreatorId", "dbo.User");
            DropForeignKey("dbo.TotalNationality", "DepartmentID", "dbo.Department");
            DropForeignKey("dbo.TotalNationality", "CreatorId", "dbo.User");
            DropForeignKey("dbo.TotalJoblevel", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.TotalJoblevel", "JoblevelID", "dbo.Joblevel");
            DropForeignKey("dbo.Joblevel", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.Joblevel", "CreatorId", "dbo.User");
            DropForeignKey("dbo.TotalJoblevel", "DepartmentID", "dbo.Department");
            DropForeignKey("dbo.TotalJoblevel", "CreatorId", "dbo.User");
            DropForeignKey("dbo.TotalGender", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.TotalGender", "GenderID", "dbo.Gender");
            DropForeignKey("dbo.Gender", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.Gender", "CreatorId", "dbo.User");
            DropForeignKey("dbo.TotalGender", "DepartmentID", "dbo.Department");
            DropForeignKey("dbo.TotalGender", "CreatorId", "dbo.User");
            DropForeignKey("dbo.QuestionAssign", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.QuestionAssign", "SurveyID", "dbo.Survey");
            DropForeignKey("dbo.QuestionAssign", "SectionAssignID", "dbo.SectionAssign");
            DropForeignKey("dbo.SectionAssign", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.SectionAssign", "SurveyID", "dbo.Survey");
            DropForeignKey("dbo.Survey", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.Survey", "LocationID", "dbo.Location");
            DropForeignKey("dbo.Survey", "CreatorId", "dbo.User");
            DropForeignKey("dbo.SectionAssign", "SectionID", "dbo.Section");
            DropForeignKey("dbo.Section", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.Section", "CreatorId", "dbo.User");
            DropForeignKey("dbo.SectionAssign", "LocationID", "dbo.Location");
            DropForeignKey("dbo.SectionAssign", "DepartmentID", "dbo.Department");
            DropForeignKey("dbo.SectionAssign", "CreatorId", "dbo.User");
            DropForeignKey("dbo.Rating", "QuestionAssignID", "dbo.QuestionAssign");
            DropForeignKey("dbo.Rating", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.QuestionAssign", "QuestionID", "dbo.Question");
            DropForeignKey("dbo.Question", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.QuestionOther", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.QuestionOther", "QuestionID", "dbo.Question");
            DropForeignKey("dbo.QuestionOther", "LanguageID", "dbo.Language");
            DropForeignKey("dbo.Language", "UpdatorId", "dbo.User");
            DropForeignKey("dbo.Language", "CreatorId", "dbo.User");
            DropForeignKey("dbo.QuestionOther", "CreatorId", "dbo.User");
            DropForeignKey("dbo.Question", "CreatorId", "dbo.User");
            DropForeignKey("dbo.QuestionAssign", "LocationID", "dbo.Location");
            DropForeignKey("dbo.QuestionAssign", "DepartmentID", "dbo.Department");
            DropForeignKey("dbo.QuestionAssign", "CreatorId", "dbo.User");
            DropForeignKey("dbo.Department", "ParentID", "dbo.Department");
            DropForeignKey("dbo.Department", "OwnerID", "dbo.User");
            DropForeignKey("dbo.Department", "LocationID", "dbo.Location");
            DropForeignKey("dbo.Department", "CreatorId", "dbo.User");
            DropForeignKey("dbo.Location", "CreatorId", "dbo.User");
            DropForeignKey("dbo.Location", "CountryId", "dbo.Country");
            DropForeignKey("dbo.Country", "CreatorId", "dbo.User");
            DropIndex("dbo.UserRole", new[] { "RoleID" });
            DropIndex("dbo.UserRole", new[] { "UserID" });
            DropIndex("dbo.UserRole", new[] { "UpdatorId" });
            DropIndex("dbo.UserRole", new[] { "CreatorId" });
            DropIndex("dbo.Role", new[] { "User_ID1" });
            DropIndex("dbo.Role", new[] { "User_ID" });
            DropIndex("dbo.Role", new[] { "UpdatorId" });
            DropIndex("dbo.Role", new[] { "CreatorId" });
            DropIndex("dbo.Servicelength", new[] { "UpdatorId" });
            DropIndex("dbo.Servicelength", new[] { "CreatorId" });
            DropIndex("dbo.TotalServicelength", new[] { "DepartmentID" });
            DropIndex("dbo.TotalServicelength", new[] { "ServicelengthID" });
            DropIndex("dbo.TotalServicelength", new[] { "UpdatorId" });
            DropIndex("dbo.TotalServicelength", new[] { "CreatorId" });
            DropIndex("dbo.Nationality", new[] { "UpdatorId" });
            DropIndex("dbo.Nationality", new[] { "CreatorId" });
            DropIndex("dbo.TotalNationality", new[] { "DepartmentID" });
            DropIndex("dbo.TotalNationality", new[] { "NationalityID" });
            DropIndex("dbo.TotalNationality", new[] { "UpdatorId" });
            DropIndex("dbo.TotalNationality", new[] { "CreatorId" });
            DropIndex("dbo.Joblevel", new[] { "UpdatorId" });
            DropIndex("dbo.Joblevel", new[] { "CreatorId" });
            DropIndex("dbo.TotalJoblevel", new[] { "DepartmentID" });
            DropIndex("dbo.TotalJoblevel", new[] { "JoblevelID" });
            DropIndex("dbo.TotalJoblevel", new[] { "UpdatorId" });
            DropIndex("dbo.TotalJoblevel", new[] { "CreatorId" });
            DropIndex("dbo.Gender", new[] { "UpdatorId" });
            DropIndex("dbo.Gender", new[] { "CreatorId" });
            DropIndex("dbo.TotalGender", new[] { "DepartmentID" });
            DropIndex("dbo.TotalGender", new[] { "GenderID" });
            DropIndex("dbo.TotalGender", new[] { "UpdatorId" });
            DropIndex("dbo.TotalGender", new[] { "CreatorId" });
            DropIndex("dbo.Survey", new[] { "LocationID" });
            DropIndex("dbo.Survey", new[] { "UpdatorId" });
            DropIndex("dbo.Survey", new[] { "CreatorId" });
            DropIndex("dbo.Section", new[] { "UpdatorId" });
            DropIndex("dbo.Section", new[] { "CreatorId" });
            DropIndex("dbo.SectionAssign", new[] { "DepartmentID" });
            DropIndex("dbo.SectionAssign", new[] { "LocationID" });
            DropIndex("dbo.SectionAssign", new[] { "SurveyID" });
            DropIndex("dbo.SectionAssign", new[] { "SectionID" });
            DropIndex("dbo.SectionAssign", new[] { "UpdatorId" });
            DropIndex("dbo.SectionAssign", new[] { "CreatorId" });
            DropIndex("dbo.Rating", new[] { "EmployeeID" });
            DropIndex("dbo.Rating", new[] { "QuestionAssignID" });
            DropIndex("dbo.Language", new[] { "UpdatorId" });
            DropIndex("dbo.Language", new[] { "CreatorId" });
            DropIndex("dbo.QuestionOther", new[] { "LanguageID" });
            DropIndex("dbo.QuestionOther", new[] { "QuestionID" });
            DropIndex("dbo.QuestionOther", new[] { "UpdatorId" });
            DropIndex("dbo.QuestionOther", new[] { "CreatorId" });
            DropIndex("dbo.Question", new[] { "UpdatorId" });
            DropIndex("dbo.Question", new[] { "CreatorId" });
            DropIndex("dbo.QuestionAssign", new[] { "DepartmentID" });
            DropIndex("dbo.QuestionAssign", new[] { "LocationID" });
            DropIndex("dbo.QuestionAssign", new[] { "SectionAssignID" });
            DropIndex("dbo.QuestionAssign", new[] { "SurveyID" });
            DropIndex("dbo.QuestionAssign", new[] { "QuestionID" });
            DropIndex("dbo.QuestionAssign", new[] { "UpdatorId" });
            DropIndex("dbo.QuestionAssign", new[] { "CreatorId" });
            DropIndex("dbo.Department", new[] { "ParentID" });
            DropIndex("dbo.Department", new[] { "OwnerID" });
            DropIndex("dbo.Department", new[] { "LocationID" });
            DropIndex("dbo.Department", new[] { "UpdatorId" });
            DropIndex("dbo.Department", new[] { "CreatorId" });
            DropIndex("dbo.Location", new[] { "CountryId" });
            DropIndex("dbo.Location", new[] { "UpdatorId" });
            DropIndex("dbo.Location", new[] { "CreatorId" });
            DropIndex("dbo.Country", new[] { "UpdatorId" });
            DropIndex("dbo.Country", new[] { "CreatorId" });
            DropIndex("dbo.Employee", new[] { "SurveyID" });
            DropIndex("dbo.Employee", new[] { "CurrentSectionID" });
            DropIndex("dbo.Employee", new[] { "ServicelengthID" });
            DropIndex("dbo.Employee", new[] { "JoblevelID" });
            DropIndex("dbo.Employee", new[] { "NationalityID" });
            DropIndex("dbo.Employee", new[] { "GenderID" });
            DropIndex("dbo.Employee", new[] { "DepartmentID" });
            DropIndex("dbo.Employee", new[] { "LocationID" });
            DropIndex("dbo.Employee", new[] { "UpdatorId" });
            DropIndex("dbo.Employee", new[] { "CreatorId" });
            DropIndex("dbo.Comment", new[] { "EmployeeID" });
            DropIndex("dbo.Comment", new[] { "SectionAssignID" });
            DropTable("dbo.Error");
            DropTable("dbo.UserRole");
            DropTable("dbo.Role");
            DropTable("dbo.Servicelength");
            DropTable("dbo.TotalServicelength");
            DropTable("dbo.Nationality");
            DropTable("dbo.TotalNationality");
            DropTable("dbo.Joblevel");
            DropTable("dbo.TotalJoblevel");
            DropTable("dbo.Gender");
            DropTable("dbo.TotalGender");
            DropTable("dbo.Survey");
            DropTable("dbo.Section");
            DropTable("dbo.SectionAssign");
            DropTable("dbo.Rating");
            DropTable("dbo.Language");
            DropTable("dbo.QuestionOther");
            DropTable("dbo.Question");
            DropTable("dbo.QuestionAssign");
            DropTable("dbo.Department");
            DropTable("dbo.Location");
            DropTable("dbo.Country");
            DropTable("dbo.User");
            DropTable("dbo.Employee");
            DropTable("dbo.Comment");
        }
    }
}
