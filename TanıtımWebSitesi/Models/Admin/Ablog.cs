using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TanıtımWebSitesi.Models.Admin
{
    public class Ablog
    {
        public int Id { get; set; }
        [DisplayName("Blog Adı")]
        [StringLength(100)]

        public string Ad { get; set; }        
        public string? Aciklama { get; set; }
        public string? Gorsel { get; set; }
        public int Goruntulenme { get; set; } = 0;
        public DateTime Tarih { get; set; }

    }
}
