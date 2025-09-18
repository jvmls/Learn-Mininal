using Learn.Dominio.Entidades;
using Learn.Dominio.DTOs;


namespace Learn.Dominio.Interfaces;

public interface IAdmServico
{
    List<Adm> Login(LoginDTO loginDTO);
  
}