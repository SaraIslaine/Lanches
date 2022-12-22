using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {


        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public DbSet<Pedido> Pedidos{get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
    
    }
}

