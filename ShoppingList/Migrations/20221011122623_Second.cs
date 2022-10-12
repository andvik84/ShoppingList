using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingList.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemHistories_Lists_ListId",
                table: "ItemHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCategories_CategoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_ListItems_ItemCategories_CategoryId",
                table: "ListItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ListItems_Items_ItemId",
                table: "ListItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ListItems_Lists_ListId",
                table: "ListItems");

            migrationBuilder.DropIndex(
                name: "IX_ListItems_CategoryId",
                table: "ListItems");

            migrationBuilder.DropIndex(
                name: "IX_ListItems_ItemId",
                table: "ListItems");

            migrationBuilder.DropIndex(
                name: "IX_ItemHistories_ListId",
                table: "ItemHistories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ListItems");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ListItems");

            migrationBuilder.RenameColumn(
                name: "ListId",
                table: "ListItems",
                newName: "ListaId");

            migrationBuilder.RenameIndex(
                name: "IX_ListItems_ListId",
                table: "ListItems",
                newName: "IX_ListItems_ListaId");

            migrationBuilder.RenameColumn(
                name: "ListId",
                table: "ItemHistories",
                newName: "ListaId");

            migrationBuilder.AlterColumn<string>(
                name: "ExtraText",
                table: "ListItems",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Items",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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
                name: "FK_Items_ItemCategories_CategoryId",
                table: "Items",
                column: "CategoryId",
                principalTable: "ItemCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ListItems_ListItemId",
                table: "Items",
                column: "ListItemId",
                principalTable: "ListItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListItems_Lists_ListaId",
                table: "ListItems",
                column: "ListaId",
                principalTable: "Lists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCategories_CategoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ListItems_ListItemId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_ListItems_Lists_ListaId",
                table: "ListItems");

            migrationBuilder.DropIndex(
                name: "IX_Items_ListItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ListItemId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "ListaId",
                table: "ListItems",
                newName: "ListId");

            migrationBuilder.RenameIndex(
                name: "IX_ListItems_ListaId",
                table: "ListItems",
                newName: "IX_ListItems_ListId");

            migrationBuilder.RenameColumn(
                name: "ListaId",
                table: "ItemHistories",
                newName: "ListId");

            migrationBuilder.AlterColumn<string>(
                name: "ExtraText",
                table: "ListItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ListItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "ListItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Items",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListItems_CategoryId",
                table: "ListItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ListItems_ItemId",
                table: "ListItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemHistories_ListId",
                table: "ItemHistories",
                column: "ListId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemHistories_Lists_ListId",
                table: "ItemHistories",
                column: "ListId",
                principalTable: "Lists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCategories_CategoryId",
                table: "Items",
                column: "CategoryId",
                principalTable: "ItemCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListItems_ItemCategories_CategoryId",
                table: "ListItems",
                column: "CategoryId",
                principalTable: "ItemCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListItems_Items_ItemId",
                table: "ListItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListItems_Lists_ListId",
                table: "ListItems",
                column: "ListId",
                principalTable: "Lists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
