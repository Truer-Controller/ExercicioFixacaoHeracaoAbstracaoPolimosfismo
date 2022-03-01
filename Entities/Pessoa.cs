using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoHeracaoAbstracaoPolimosfismo.Entities
{
    abstract class Pessoa
    {
        public string NamePessoa { get; set; }

        public double RendaAnual { get; set; }

        public Pessoa()
        {
        }

        protected Pessoa(string namePessoa, double rendaAnual)
        {
            NamePessoa = namePessoa;
            RendaAnual = rendaAnual;
        }

        public abstract double Taxa();
    }
}
