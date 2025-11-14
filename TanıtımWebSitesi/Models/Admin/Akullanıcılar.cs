using System.ComponentModel;

namespace TanıtımWebSitesi.Models.Admin
{
    public class Akullanıcılar
    {
        public int Id { get; set; }
        [DisplayName("E-posta")]
        public string Eposta { get; set; }
        [DisplayName("Şifre")]
        public string Sifre { get; set; }
        [DisplayName("Onay Durumu")]
        public bool Onay { get; set; } = false;
    }
}
