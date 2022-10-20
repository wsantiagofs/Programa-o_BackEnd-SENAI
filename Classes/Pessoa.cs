using Back_End_ER2.Interfaces;
using Programacao_BackEnd_SENAI.Classes;

namespace Back_End_ER2.Classes

{
    public abstract class Pessoa : IPessoa
    {
        public string? nome { get; set; }

        public float rendimento { get; set; }

        public Endereco? endereco { get; set; }

        public abstract float CalcularImposto(float rendimento);
       
    }
}