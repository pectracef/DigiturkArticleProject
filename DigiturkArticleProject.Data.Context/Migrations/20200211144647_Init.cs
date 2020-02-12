using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiturkArticleProject.Data.Context.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SystemAction",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false),
                    controllerName = table.Column<string>(nullable: true),
                    actionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemAction", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    roleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                    table.ForeignKey(
                        name: "FK_User_Role_roleId",
                        column: x => x.roleId,
                        principalTable: "Role",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleSystemAction",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false),
                    roleId = table.Column<long>(nullable: false),
                    systemActionId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleSystemAction", x => x.id);
                    table.ForeignKey(
                        name: "FK_RoleSystemAction_Role_roleId",
                        column: x => x.roleId,
                        principalTable: "Role",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleSystemAction_SystemAction_systemActionId",
                        column: x => x.systemActionId,
                        principalTable: "SystemAction",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    subTitle = table.Column<string>(nullable: true),
                    content = table.Column<string>(nullable: true),
                    createdUserId = table.Column<long>(nullable: false),
                    updatedUserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.id);
                    table.ForeignKey(
                        name: "FK_Article_User_createdUserId",
                        column: x => x.createdUserId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Article_User_updatedUserId",
                        column: x => x.updatedUserId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false),
                    parentCommentId = table.Column<long>(nullable: true),
                    articleId = table.Column<long>(nullable: false),
                    content = table.Column<string>(nullable: true),
                    createdUserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comment_Article_articleId",
                        column: x => x.articleId,
                        principalTable: "Article",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_User_createdUserId",
                        column: x => x.createdUserId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Comment_parentCommentId",
                        column: x => x.parentCommentId,
                        principalTable: "Comment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_createdUserId",
                table: "Article",
                column: "createdUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_updatedUserId",
                table: "Article",
                column: "updatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_articleId",
                table: "Comment",
                column: "articleId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_createdUserId",
                table: "Comment",
                column: "createdUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_parentCommentId",
                table: "Comment",
                column: "parentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleSystemAction_roleId",
                table: "RoleSystemAction",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleSystemAction_systemActionId",
                table: "RoleSystemAction",
                column: "systemActionId");

            migrationBuilder.CreateIndex(
                name: "IX_User_roleId",
                table: "User",
                column: "roleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "RoleSystemAction");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "SystemAction");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
