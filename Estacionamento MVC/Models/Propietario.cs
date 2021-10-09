using System.ComponentModel.DataAnnotations;

namespace Estacionamento_MVC.Models
{
    public class Propietario
    {
        public int Id { get; set; }
        [Required]
        public string Modelo { get; set; }

        [Required]
        public string Cor { get; set; }

        [Required]
        [StringLength(100)]
        public string Marca { get; set; }

        [Required]
        [StringLength(8)]
        public string Placa { get; set; }

        [Required]
        [Display(Name = "Proprietário")]
        [StringLength(250)]
        public string NomePessoa { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        [Display(Name ="Vaga")]
        public int NumVaga { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string Data { get; set; }

        [Required]
        [Display(Name = "Entrada")]
        [DataType(DataType.Time)]
        public string HoraEntrada { get; set; }

        
        [DataType(DataType.Time)]
        [Display(Name ="Saida")]
        public string HoraSaida { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public decimal Total { get; set; }
        public bool Pago { get; set; }
    }
}
