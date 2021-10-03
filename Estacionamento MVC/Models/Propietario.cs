using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento_MVC.Models
{
    public class Propietario
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        [StringLength(100)]
        public string Marca { get; set; }
        [StringLength(8)]
        public string Placa { get; set; }

        [Display(Name = "Proprietario")]
        [StringLength(250)]
        public string NomePessoa { get; set; }
        [StringLength(11)]
        public string CPF { get; set; }
        [Display(Name ="Vaga")]
        public int NumVaga { get; set; }
        [DataType(DataType.Date)]
        public string Data { get; set; }
        [Display(Name = "Entrada")]
        [DataType(DataType.Time)]
        public string HoraEntrada { get; set; }
        [DataType(DataType.Time)]
        [Display(Name ="Saida")]
        public string HoraSaida { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public double Total { get; set; }
        public bool Pago { get; set; }
    }
}
