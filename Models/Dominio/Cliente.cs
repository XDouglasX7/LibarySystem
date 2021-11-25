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
    [Table("Cliente")]
    public class Cliente
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
        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        [StringLength(14, ErrorMessage = "Não aceita CPF com mais de 14 dígitos")]
        public string cpf { get; set; }

        [Display(Name = "Plano")]
        public Plano Plano { get; set; }

        public ICollection<Movimentacao> movimentacao { get; set; }
    }
}
