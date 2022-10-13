using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingList.Migrations
{
    public partial class minor_changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ListItems_ListItemId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ListItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ListItemId",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "ListItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ListItems_ItemId",
                table: "ListItems",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListItems_Items_ItemId",
                table: "ListItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListItems_Items_ItemId",
                table: "ListItems");

            migrationBuilder.DropIndex(
                name: "IX_ListItems_ItemId",
                table: "ListItems");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ListItems");

            migrationBuilder.AddColumn<int>(
                name: "ListItemId",
                table: "Items",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ListItemId",
                table: "Items",
                column: "ListItemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ListItems_ListItemId",
                table: "Items",
                column: "ListItemId",
                principalTable: "ListItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
