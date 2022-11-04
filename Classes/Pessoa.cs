using Back_End_ER2.Interfaces;
using Programacao_BackEnd_SENAI.Classes;

namespace Back_End_ER2.Classes

{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
        
        public float Rendimento { get; set; }
        
        public Endereco? Endereco { get; set; }

        public float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public abstract float PagarImposto(float rendimento);
    }
}