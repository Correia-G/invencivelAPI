using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace WebApplication1.Models
{
    [Table("incidente")]
    public class Incidente
    {
        [Key]
        [Column("id_incidente")]
        public int id_incidente { get; set; }
        [Column("tipo")]
        public string tipo { get; set; }
        [Column("horario")]
        public DateTime horario { get; set; }
        [Column("localizacao_incidente")]
        public Point localizacao_incidente { get; set; }
    }
}
