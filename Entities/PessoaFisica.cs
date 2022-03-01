using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoHeracaoAbstracaoPolimosfismo.Entities
{
    class PessoaFisica : Pessoa
    {
        public double HealtPenditures { get; set; }
        
        public PessoaFisica(double healtPenditures, string namePessoa, double rendaAnual) : base(namePessoa, rendaAnual)
        {
            HealtPenditures = healtPenditures;
        }

        public override double Taxa()
        {
            return (RendaAnual * 0.25) - (HealtPenditures * 0.50); 
        }
    }
}
