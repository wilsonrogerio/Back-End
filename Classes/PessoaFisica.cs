using CadastroPessoas.Interfaces;

namespace CadastroPessoas.Classes
{
    public class PessoaFisica : Pessoa, IpessoaFisica
    {
        
        public string cpf { get; set; }

        public DateTime DataNasc { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}