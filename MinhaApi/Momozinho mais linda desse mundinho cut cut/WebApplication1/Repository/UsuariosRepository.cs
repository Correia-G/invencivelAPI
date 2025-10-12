using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Repository
{
    public class UsuariosRepository : UsuarioServices
    {
        private readonly AppDbContext appDbContext;

        public UsuariosRepository(AppDbContext appDb)
        {
            appDbContext = appDb;
        }
        public async Task<Usuario> LoginUsuario(string email, string senha)
        {
            var Usuarios = appDbContext.usuarios.ToList();

            var loginUsuario = await appDbContext.usuarios.FirstOrDefaultAsync(u => u.Email_Usuario == email && u.Senha_Usuario == senha);

            if (loginUsuario != null)
            {
                return loginUsuario;
            }
            else
            {
                return null;
            }
        }
    }
}
