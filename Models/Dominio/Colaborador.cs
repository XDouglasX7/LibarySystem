using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Dominio
{
    [Table("Colaborador")]
    public class Colaborador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Tamanho de nome inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "CPF")]

        [StringLength(14, ErrorMessage = "Não aceita CPF com mais de 14 dígitos")]
        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        public string cpf { get; set; }

        [Display(Name = "E-Mail")]
        [StringLength(35, ErrorMessage = "E-Mail maior que 35 caracteres")]
        [RegularExpression("^[a-zA-Z0-9_+-]+[a-zA-Z0-9._+-]*[a-zA-Z0-9_+-]+@[a-zA-Z0-9_+-]+[a-zA-Z0-9._+-]*[.]{1,1}[a-zA-Z]{2,}$", ErrorMessage = "Email invalido")]
        public string email { get; set; }

        [StringLength(20, ErrorMessage = "Tamanho de nome inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo Usuário é obrigatório")]
        [Display(Name = "Usuario")]
        public string usuario { get; set; }
    }
}
