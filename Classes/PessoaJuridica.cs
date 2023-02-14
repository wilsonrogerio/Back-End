using System.Text.RegularExpressions;
using CadastroPessoas.Interfaces;

namespace CadastroPessoas.Classes
{
    public class PessoaJuridica : Pessoa, IpessoaJuridica

    {
        
        public string nome { get; set; }

        public float rendimento { get; set; }

        public string cnpj {get; set;}

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
          bool retornoCnpjValido = Regex.IsMatch(cnpj, @"^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2}) $");
          
          if ( retornoCnpjValido)
          {
            string subStringCnpj14 = cnpj.Substring(8, 4);

            if (subStringCnpj14 == "0001")
            {
                return true ;
            }else{
                return false;
            }
          }

         string subStringCnpj18 = cnpj.Substring(11, 4);

            if (subStringCnpj18 == "0001")
            {
                return true ;
            }
          return false;
        }

          
          
          
            // throw new NotImplementedException();
    }
}
