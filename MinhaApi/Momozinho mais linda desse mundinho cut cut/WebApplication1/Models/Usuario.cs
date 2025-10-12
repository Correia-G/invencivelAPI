using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace WebApplication1.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        [Column("id_usuario")]
        public int Id_usuario { get; set; }
        [Column("nome")]
        public string Nome_Usuario { get; set; }
        [Column("email")]
        public string Email_Usuario { get; set; }
        [Column("maquinista")]
        public bool Maquinista { get; set; }
        [Column("trem_id")]
        public int Trem_Id { get; set; }
        [Column("destino")]
        public Point Destino_Usuario { get; set; }
        [Column("localizacao")]
        public Point Localizacao_Usuario { get; set; }
        [Column("senha")]
        public string Senha_Usuario { get; set; }
    }
}
