using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("trem")]
    public class Trem
    {
        [Key]
        [Column("id")]
        public int id_trem { get; set; }
        [Column("modelo")]
        public string modelo { get; set; }
        [Column("numero_serie")]
        public string numero_serie { get; set; }
        [Column("data_aquisicao")]
        public DateTime data_aquisicao { get; set; }
        [Column("localizacao_trem")]
        public Point localizacao_trem { get; set; }
    }
}
