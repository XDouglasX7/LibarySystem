using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Dominio
{

    [Table("Plano")]
    public class Plano
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho de nome inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Porcentagem Desconto")]
        [Required(ErrorMessage = "Campo Porcentagem de Desconto é obrigatório")]
        [StringLength(3, ErrorMessage = "Não aceita porcentagem com mais de 3 dígitos")]
        public string porcen_desconto { get; set; }

        public ICollection<Cliente> cliente { get; set; }
    }
}
