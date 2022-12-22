using CadastroPessoas.Interfaces;

namespace CadastroPessoas.Classes
{
    public class PessoaJuridica : Pessoa, IpessoaJuridica

    {
        
        public string nome { get; set; }

        public float rendimento { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;
                
            }else if(rendimento <= 6000)
            {
                return rendimento * .05f;


            }else if (rendimento <= 10000) 
            {
                return rendimento * .07f;
                
            }else
            {
                return rendimento * 09f;
                
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}