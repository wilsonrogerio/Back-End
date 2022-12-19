using CadastroPessoas.Interfaces;

namespace CadastroPessoas.Classes
{
    public abstract class Pessoa : Ipessoa
    {
         public string? nome { get; set; }
         
         public float rendimento { get; set; }

         public Endereco end { get; set; }
         
         
        
        
        
        public  abstract float CalcularImposto(float rendimento);
        
    }
}