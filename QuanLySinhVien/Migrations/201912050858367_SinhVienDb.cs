namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SinhVienDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DiemHocTaps", "MaSinhVien", "dbo.SinhViens");
            DropIndex("dbo.DiemHocTaps", new[] { "MaSinhVien" });
            DropPrimaryKey("dbo.DiemHocTaps");
            AlterColumn("dbo.DiemHocTaps", "MaSinhVien", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.DiemHocTaps", new[] { "MaMonHoc", "MaSinhVien" });
            CreateIndex("dbo.DiemHocTaps", "MaSinhVien");
            AddForeignKey("dbo.DiemHocTaps", "MaSinhVien", "dbo.SinhViens", "MaSinhVien", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DiemHocTaps", "MaSinhVien", "dbo.SinhViens");
            DropIndex("dbo.DiemHocTaps", new[] { "MaSinhVien" });
            DropPrimaryKey("dbo.DiemHocTaps");
            AlterColumn("dbo.DiemHocTaps", "MaSinhVien", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.DiemHocTaps", "MaMonHoc");
            CreateIndex("dbo.DiemHocTaps", "MaSinhVien");
            AddForeignKey("dbo.DiemHocTaps", "MaSinhVien", "dbo.SinhViens", "MaSinhVien");
        }
    }
}
