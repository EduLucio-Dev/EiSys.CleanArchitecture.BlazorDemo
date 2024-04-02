using EiSys.CleanArchitecture.DomainLayer.Validation;

namespace EiSys.CleanArchitecture.DomainLayer.Entities
{
    public sealed class Funcionario : EntityBase
    {
        public string? Nome { get; private set; }
        public string? Endereco { get; private set; }

        public Funcionario(string nome, string endereco)
        {
            ValidateDomain(nome, endereco);
        }
        public Funcionario(Guid id,string nome, string endereco)
        {
            DomainExceptionValidation.when(id == Guid.Empty, "Valor do Id Invalido");
            Id = id;
            ValidateDomain(nome, endereco);
        }

        private void ValidateDomain(string nome, string endereco)
        {
            if (nome == null)
            {
                DomainExceptionValidation.when(string.IsNullOrEmpty(nome), "Nome Invalido!");
            }else if (nome.Length < 3)
            {
                DomainExceptionValidation.when(nome.Length < 3, "Nome muito curto, minimo 3 caracteres.");
            }
                if (endereco == null)
            {
                DomainExceptionValidation.when(string.IsNullOrEmpty(endereco), "Endereco Invalido!");
            }else if (endereco.Length < 10) 
            {
                DomainExceptionValidation.when(endereco.Length < 10, "Endereço muito curto, minimo 10 caracteres.");
            }

            Nome = nome;
            Endereco = endereco;
        }
    }
}
