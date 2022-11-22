using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    public class Lanche
    {
        [key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = " o nome do lanche deve ser informado")]
        [Display(Name = "nome")]
        [StringLength(80, MinimumLength= 10 ,ErrorMessage = "o {0} deve ter no minimo {1} caracteres")]

        public string Nome { get; set; }

        [Required(ErrorMessage = " a discricão do lanche deve ser informada")]
        [Display(Name = "descriçao do lanche")]
        [MinLength( 20, ErrorMessage = "descriçao deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage=" descriçao detalhada pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = " a discricão detalhada do lanche deve ser informada")]
        [Display(Name = "descriçao detalhada do lanche")]
        [MinLength(20, ErrorMessage = "descriçao deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = " descriçao detalhada pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = " informe o preço do lanche")]
        [Display(Name = "preço")]
        [Column(TypeName = "decimal(10, 2)")]
        [Range(1,999.99,ErrorMessage ="o preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }
        [Display(Name = "caminho da imagem normal")]
        [StringLength(200,ErrorMessage ="o {0} deve ter no maximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "caminho imagem miniatura")]
        [StringLength(200, ErrorMessage = "o {0} deve ter no maximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "estoque?")]
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
