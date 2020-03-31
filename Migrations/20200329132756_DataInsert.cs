using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularWithCore.Migrations
{
    public partial class DataInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into makes(Name) values ('Make1')");
            migrationBuilder.Sql("Insert into makes(Name) values ('Make2')");
            migrationBuilder.Sql("Insert into makes(Name) values ('Make3')");
            migrationBuilder.Sql("Insert into Models(Name, MakeId) values ('Make1-ModelA',(Select ID from Makes where Name='Make1'))");
            migrationBuilder.Sql("Insert into Models(Name, MakeId) values ('Make1-ModelB',(Select ID from Makes where Name='Make1'))");
            migrationBuilder.Sql("Insert into Models(Name, MakeId) values ('Make1-ModelC',(Select ID from Makes where Name='Make1'))");
            migrationBuilder.Sql("Insert into Models(Name, MakeID) values ('Make2-ModelA',(Select ID from Makes where Name='Make2'))");
            migrationBuilder.Sql("Insert into Models(Name, MakeId) values ('Make2-ModelB',(Select ID from Makes where Name='Make2'))");
            migrationBuilder.Sql("Insert into Models(Name, MakeId) values ('Make2-ModelC',(Select ID from Makes where Name='Make2'))");

            migrationBuilder.Sql("Insert into Models(Name, MakeId) values ('Make3-ModelA',(Select ID from Makes where Name='Make3'))");
            migrationBuilder.Sql("Insert into Models(Name, MakeId) values ('Make3-ModelB',(Select ID from Makes where Name='Make3'))");
            migrationBuilder.Sql("Insert into Models(Name, MakeId) values ('Make3-ModelC',(Select ID from Makes where Name='Make3'))");
         
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

