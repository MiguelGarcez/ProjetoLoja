using ProjetoLoja.Models;

namespace ProjetoLoja.Repositorio
{
    public interface IUsuarioRepositorio
    {
        LoginViewModel Validar(string email, string senha);
    }
}
