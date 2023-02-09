using CadastroPessoas.Interfaces;

namespace CadastroPessoas.Classes
{
    public class PessoaFisica : Pessoa, IpessoaFisica
    {
        
        public string cpf { get; set; }

        public DateTime DataNasc { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500 )
            {
                return 0;

            }else if (rendimento > 1500 && rendimento <= 3500)
            {
                float resultado = (rendimento / 100) * 2;
                return resultado;

            }else if (rendimento > 3500 && rendimento <= 600)
            {
                float resultado = (rendimento / 100) * 3.5f;
                return resultado;

            }else
            {
                float resultado =(rendimento /100)* 5;
                return resultado;


            }

        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos =  (dataAtual - dataNasc).TotalDays / 365;

            // Console.WriteLine(anos); 

            if (anos >= 18 ){

               

                return true;
                // ;throw new NotImplementedException()


            }else{

                return false;

            }

            // throw new NotImplementedException();

        }
        public bool ValidarDataNasc(string dataNasc)
        {

           if ( DateTime.TryParse(dataNasc, out DateTime dataConvertida )){

            DateTime dataAtual = DateTime.Today;

            double anos =  (dataAtual - dataConvertida).TotalDays / 365;

            // Console.WriteLine(anos); 

            if (anos >= 18 ){

                return true;

            }

           } 

           return false;

           throw new NotImplementedException();
        }
    }
}