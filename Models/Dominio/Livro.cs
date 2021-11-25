using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Dominio
{
    [Table("Livro")]
    public class Livro
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho de nome inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Preço de Compra é obrigatório")]
        [Display(Name = "Preço de Compra")]
        public string preco_compra { get; set; }

        [Required(ErrorMessage = "Campo Preço de Venda é obrigatório")]
        [Display(Name = "Preço de Venda")]
        public string preco_venda { get; set; }

        [Required(ErrorMessage = "Campo Quantidade é obrigatório")]
        [Display(Name = "Quantidade")]
        public int quantidade { get; set; }

        public ICollection<Movimentacao> movimentacao { get; set; }
    }
}
