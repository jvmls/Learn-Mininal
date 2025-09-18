namespace Learn.Dominio.Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Adm
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;
    [Required]
    [StringLength(255)]
    public string Email { get; set; } = default!;
    [StringLength(50)]
    public string Senha { get; set; } = default!;
    [StringLength(10)]
    public string Perfil { get; set; } = default!;
}