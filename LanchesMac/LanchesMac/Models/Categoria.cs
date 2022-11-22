using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [key]
        public int categoriaId { get; set; }
        [StringLength(100,  ErrorMessage  ="o tamanho maximo é 100 caracter")]
        [Required(ErrorMessage = "Informar o nome da categoria")]
        [Display(Name ="nome")]
        public string categoriaName { get; set; }

        [StringLength(200, ErrorMessage = "o tamanho maximo é 200 caracter")]
        [Required(ErrorMessage = "Informar o nome da categoria")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set;}

        public List<Lanche> Lanches { get; set; }
        
    }

    internal class keyAttribute : Attribute
    {
    }
}
