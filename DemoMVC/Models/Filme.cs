using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo Título é obrigatório!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Título precisa ter entre 3 ou 60 caracteres.")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto!")]
        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório!")]
        [Display(Name = "Data de Lançameto")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00c0-\u00FF""'\w-]*$", ErrorMessage = "Genero em formato inválido!")]
        [StringLength(60, ErrorMessage = "Máximo de 30 caracteres."), Required(ErrorMessage = "O campo Gênero é obrigatório!")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "O campo Valor é obrigatório!")]
        [Column(TypeName = "Decimal (18, 2)")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números")]
        [Required(ErrorMessage = "O campo Avaliação é obrigatório!")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }

    }
}
