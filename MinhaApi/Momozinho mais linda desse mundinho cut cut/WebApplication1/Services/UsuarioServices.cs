using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface UsuarioServices
    {
        public Task<Usuario> LoginUsuario(string email, string senha);

    }
}
