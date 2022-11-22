using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrger, ovo, presunto, queijo e batata palha','Delicioso pão de hambúrger com ovo frito; carne de hambúrguer, presunto e queijo de primeira qualidade acompanhado com alface, tomate e milho ',1, 'https://static.expressodelivery.com.br/imagens/produtos/102801/180/Expresso-Delivery_fb845a9a1d5d7b620a0e19de0a9632e3.png','https://static.expressodelivery.com.br/imagens/produtos/102801/180/Expresso-Delivery_fb845a9a1d5d7b620a0e19de0a9632e3.png',0 ,'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão,presunto, milho, ovo, tomate e alface','Delicioso pão francês quentinho na chapa com presunto, milho, ovo e alface bem servidos com tomate preparado com carinho.',1,'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTbt1J31lJp3oZx0wZE7gdw07BAOuVzXZGKw&usqp=CAU','https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTbt1J31lJp3oZx0wZE7gdw07BAOuVzXZGKw&usqp=CAU',0,'Misto Quente', 13.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrger, presunto, mussarela e batalha palha','Pão de hambúrger especial com hambúrguer de nossa preparação e presunto e mussarela; acompanha batata palha.',1,'https://www.receitasnestle.com.br/sites/default/files/2021-08/image%20-%202021-08-10T115911.650.jpg','https://www.receitasnestle.com.br/sites/default/files/2021-08/image%20-%202021-08-10T115911.650.jpg',0,'Cheese Burger', 11.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(2,'Pão Integral, queijo branco, peito de peru, cenoura, alface, iogurte','Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado.',1,'http://d3ugyf2ht6aenh.cloudfront.net/stores/001/183/764/products/hamburguer-de-carne-com-queijo-no-pao-integral1-171e5a49f22082192416335471743288-640-0.jpg','http://d3ugyf2ht6aenh.cloudfront.net/stores/001/183/764/products/hamburguer-de-carne-com-queijo-no-pao-integral1-171e5a49f22082192416335471743288-640-0.jpg',1,'Lanche Natural Peito Peru', 15.00)");



        }
    }
}