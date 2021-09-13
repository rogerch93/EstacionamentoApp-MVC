using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento_MVC.Models
{
    public class CarroPessoa
    {
        public Genero Genero { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string NomePessoa { get; set; }
        public string CPF { get; set; }
        public string NumVaga { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSaida { get; set; }
        public string Total { get; set; }
        private bool Pago { get; set; }

        public CarroPessoa(int id, Genero genero, string modelo, string marca, string placa, string nomePessoa, string cpf, string numVaga,
        string horaEntrada, string horaSaida, string total)
        {
            this.Id = id;
            this.Genero = genero;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Placa = placa;
            this.NomePessoa = nomePessoa;
            this.CPF = cpf;
            this.NumVaga = numVaga;
            this.HoraEntrada = horaEntrada;
            this.HoraSaida = horaSaida;
            this.Total = total;
            this.Pago = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Modelo: " + Modelo + Environment.NewLine;
            retorno += "Marca: " + Marca + Environment.NewLine;
            retorno += "Placa: " + Placa + Environment.NewLine;
            retorno += "Nome do Cliente: " + NomePessoa + Environment.NewLine;
            retorno += "CPF: " + CPF + Environment.NewLine;
            retorno += "Numero da Vaga: " + NumVaga + Environment.NewLine;
            retorno += "Pago: " + Pago;  
            return retorno;
        }

        public string RetornaCPF()
        {
            return CPF;
        }

        public int RetornaId()
        {
            return Id;
        }

        public bool RetornaExcluido()
        {
            return Pago;
        }

        public string RetornaModelo()
        {
            return Modelo;
        }

        public string RetornaNomePessoa()
        {
            return NomePessoa;
        }

        public string RetornaHoraEntrada()
        {
            return HoraEntrada;
        }

        public string RetornaPlaca()
        {
            return Placa;
        }

        public string RetornaVaga()
        {
            return NumVaga;
        }

        public Genero RetornaGenero()
        {
            return Genero;
        }

        public string RetornaHoraSaida()
        {
            return HoraSaida;
        }

        public string RetornaTotal()
        {
            return Total;
        }

        public void Exclui()
        {
            Pago = true;
        }
    }

    
}
