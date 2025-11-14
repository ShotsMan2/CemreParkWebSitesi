using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TanıtımWebSitesi.Models.Admin
{
    public class Agaleri
    {
        public int Id { get; set; }
        [DisplayName("Görsel Adı")]
        [StringLength(100)]
        public string Ad { get; set; }
        public string Gorsel { get; set; }
        public bool AnaSlaytMi { get; set; }= false;

    }
}
