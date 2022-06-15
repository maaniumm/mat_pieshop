using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class finaldata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                column: "LongDescription",
                value: "Najelpszy Nowojorski sernik!");

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImgThumbUrl", "ImgUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 2, "", 1, "https://d3iamf8ydd24h9.cloudfront.net/pictures/articles/2018/11/659622-v-1080x1080.jpg", "https://d3iamf8ydd24h9.cloudfront.net/pictures/articles/2018/11/659622-v-1080x1080.jpg", true, false, "Kruche ciasto z dodatkiem kakao i idealna masa serowa!", "Sernkik krolewski", 8.99m, "Kruche ciasto z dodatkiem kakao i idealna masa serowa!" },
                    { 3, "", 2, "https://pk1.pocztakwiatowa.pl/media/catalog/product/xc/image/t/o/tort_orzechowy.jpg", "https://pk1.pocztakwiatowa.pl/media/catalog/product/xc/image/t/o/tort_orzechowy.jpg", true, false, "Delikatny orzechowy krem...", "Tort orzechowy", 11.95m, "Delikatny orzechowy krem..." },
                    { 4, "", 3, "https://wszystkiegoslodkiego.pl/storage/images/202110/tofumisu-1.webp", "https://wszystkiegoslodkiego.pl/storage/images/202110/tofumisu-1.webp", true, false, "Tofumisu - tiramisu w wersji Vegan!", "Tofumisu", 25m, "Tofumisu - tiramisu w wersji Vegan!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                column: "LongDescription",
                value: "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.");
        }
    }
}
