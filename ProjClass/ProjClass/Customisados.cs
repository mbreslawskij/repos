using System;
using System.Collections.Generic;
using System.Text;

namespace ProjClass
{
    public class Customisados
    {
        public int AnoModelo = 1994;
        public int Cilindradas = 1900;
        public string Montadora = "VW";
        private string Alteracoes = "Turbo interculado";
        private string Cor = "Vermelho";

        public Customisados()
        {
            AnoModelo = 2012;
            Cilindradas = 1000;
            Alteracoes = "Original";
        }

        public int IdadeVeiculo(int modelo)
        {
            int idade = 2021 - modelo;
            return idade;
            }
   

    }
}
