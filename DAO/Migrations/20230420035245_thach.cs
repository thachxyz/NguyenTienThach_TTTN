using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class thach : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    created_by = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    updated_by = table.Column<long>(type: "bigint", nullable: true),
                    trash = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "brand",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    created_by = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    updated_by = table.Column<long>(type: "bigint", nullable: true),
                    alias = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    brand_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trash = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    alias = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cat_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trash = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    parent_category = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "FKaicb6e7sl98i1qgcisd5kjkbs",
                        column: x => x.parent_category,
                        principalTable: "category",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "contact",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    created_by = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    updated_by = table.Column<long>(type: "bigint", nullable: true),
                    content = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<int>(type: "int", nullable: true),
                    title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trash = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    age = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "hibernate_sequence",
                columns: table => new
                {
                    next_val = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "link",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    created_by = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    updated_by = table.Column<long>(type: "bigint", nullable: true),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    link = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    position = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'1'"),
                    trash = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "oder",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReceiverName = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    created_by = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    updated_by = table.Column<long>(type: "bigint", nullable: true),
                    note = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'0'"),
                    trash = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "page",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    created_by = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    updated_by = table.Column<long>(type: "bigint", nullable: true),
                    content = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trash = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    created_by = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    updated_by = table.Column<long>(type: "bigint", nullable: true),
                    full_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pass = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trash = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'0'"),
                    user_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    created_by = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    updated_by = table.Column<long>(type: "bigint", nullable: true),
                    alias = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    detail = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name_product = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    sale_price = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    brand_id = table.Column<long>(type: "bigint", nullable: true),
                    category_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "FK1mtsbur82frn64de7balymq9s",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FKs6cydsualtsrprvlf2bb3lcam",
                        column: x => x.brand_id,
                        principalTable: "brand",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "orderdetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    created_by = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    updated_by = table.Column<long>(type: "bigint", nullable: true),
                    price = table.Column<double>(type: "double", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'0'"),
                    trash = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    order_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "FKlsqxuwouem7wwcq9qm84ivwbv",
                        column: x => x.order_id,
                        principalTable: "oder",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    created_by = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    updated_by = table.Column<long>(type: "bigint", nullable: true),
                    diachi = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<int>(type: "int", nullable: true),
                    phone = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    full_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trash = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    order_id = table.Column<long>(type: "bigint", nullable: true),
                    user_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "FKeu3atqr8ryloegtmbc4w9h63b",
                        column: x => x.order_id,
                        principalTable: "oder",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FKj8dlm21j202cadsbfkoem0s58",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "cart",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    productid = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    subPrice = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "FK_cart_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "cart_product",
                        column: x => x.productid,
                        principalTable: "product",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateTable(
                name: "image",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    created_by = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    updated_by = table.Column<long>(type: "bigint", nullable: true),
                    image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    link = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    position = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'1'"),
                    title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_vietnamese_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trash = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    product_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "FKgpextbyee3uk9u6o2381m7ft1",
                        column: x => x.product_id,
                        principalTable: "product",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_vietnamese_ci");

            migrationBuilder.CreateIndex(
                name: "cart_product",
                table: "cart",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_cart_UserId",
                table: "cart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "FKaicb6e7sl98i1qgcisd5kjkbs",
                table: "category",
                column: "parent_category");

            migrationBuilder.CreateIndex(
                name: "FKeu3atqr8ryloegtmbc4w9h63b",
                table: "customer",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "FKj8dlm21j202cadsbfkoem0s58",
                table: "customer",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_order_id",
                table: "customer",
                column: "order_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FKgpextbyee3uk9u6o2381m7ft1",
                table: "image",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "FKlsqxuwouem7wwcq9qm84ivwbv",
                table: "orderdetail",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "FK1mtsbur82frn64de7balymq9s",
                table: "product",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "FKs6cydsualtsrprvlf2bb3lcam",
                table: "product",
                column: "brand_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "cart");

            migrationBuilder.DropTable(
                name: "contact");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "hibernate_sequence");

            migrationBuilder.DropTable(
                name: "image");

            migrationBuilder.DropTable(
                name: "link");

            migrationBuilder.DropTable(
                name: "orderdetail");

            migrationBuilder.DropTable(
                name: "page");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "oder");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "brand");
        }
    }
}
