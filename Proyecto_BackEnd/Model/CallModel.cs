using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_BackEnd.Model
{
    public class CallModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string p2p { get; set; }
        public Estado estado { get; set; }
        public DateTime date { get; set; }

        [ForeignKey("id_user")]
        public virtual UserModel? user { get; set; }
        [ForeignKey("id_cajero")]
        public virtual CajeroModel? cajero { get; set; }

    }
}
