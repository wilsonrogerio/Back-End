using System.Text.RegularExpressions;
using CadastroPessoas.Interfaces;

namespace CadastroPessoas.Classes
{
    public class PessoaJuridica : Pessoa, IpessoaJuridica

    {

        public string? razaoSocial { get; set; }

        public float rendimento { get; set; }

        public string? cnpj { get; set; }

        public string? Caminho { get; private set; } = "Datebase/PessoaJuridica.csv";

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;

            }
            else if (rendimento <= 6000)
            {
                return rendimento * .05f;


            }
            else if (rendimento <= 10000)
            {
                return rendimento * .07f;

            }
            else
            {
                return rendimento * 09f;

            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2}) $");

            if (retornoCnpjValido)
            {
                string subStringCnpj14 = cnpj.Substring(8, 4);

                if (subStringCnpj14 == "0001")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            string subStringCnpj18 = cnpj.Substring(11, 4);

            if (subStringCnpj18 == "0001")
            {
                return true;
            }
            return false;
        }

        public void Inserir(PessoaJuridica pj)
        {

            Utils.VerificarPastaArquivo(Caminho);

            string[] pjstring = { $"{pj.razaoSocial},{pj.cnpj}" };

            File.AppendAllLines(Caminho, pjstring);

        }

        public List<PessoaJuridica> LerArquivo()
        {
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string [] linhas = File.ReadAllLines(Caminho);
            foreach (string cadaLinha in linhas)
            {
                string [] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPJ = new PessoaJuridica();

                cadaPJ.razaoSocial = atributos[0];
                cadaPJ.cnpj = atributos[1];

                listaPj.Add (cadaPJ);

            }
            
            return listaPj;

        }



        // throw new NotImplementedException();
    }
}
