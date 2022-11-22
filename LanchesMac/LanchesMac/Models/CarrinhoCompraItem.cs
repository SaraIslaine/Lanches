using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    [Table("CarrinhoCompraItens")]
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }

        public Lanche  Lanche { get; set; }

         public int Quantidade { get; set; }
        
        [StringLength(200)]

         public String CarrinhoCompraId { get; set; }
}
}
