using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}
