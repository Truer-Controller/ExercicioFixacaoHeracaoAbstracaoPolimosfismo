using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoHeracaoAbstracaoPolimosfismo.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumberEmploy { get; set; }

        public PessoaJuridica(int numberEmploy, string namePessoa, double rendaAnual) : base(namePessoa, rendaAnual)
        {
            NumberEmploy = numberEmploy;
        }

        public override double Taxa()
        {
            if(NumberEmploy > 10)
            {
                return RendaAnual * 0.14;
            }
            else {
                return RendaAnual * 0.16;
            }
            
        }
    }
}
