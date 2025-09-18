using Learn.Dominio.Interfaces;
using Learn.Dominio.DTOs;
using Learn.Infraestrutura.DB;
using Learn.Dominio.Entidades;


namespace Learn.Dominio.Servicos;

public class AdmServico : IAdmServico
{
    private readonly DbContexto _contexto;

    public AdmServico(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public List<Adm> Login(LoginDTO loginDTO)
    {
        return _contexto.Adms
        .Where(a => a.Email == loginDTO.UserName && a.Senha == loginDTO.Password)
        .ToList();
        
    }
}