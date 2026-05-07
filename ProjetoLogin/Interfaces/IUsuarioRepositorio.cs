using ProjetoLogin.Models;

namespace ProjetoLogin.Interfaces
{
    public interface IUsuarioRepositorio
    {
        //a interface não contem código apenas a promessa do que deve
        //ser feito
        LoginViewModel Validar(string Email, String Senha);

        void CriarConta(LoginViewModel usuario);
    }
}
