using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TanıtımWebSitesi.Models
{
    public class iletisimViewModel
    {
        [DisplayName("Adı *")]
        [StringLength(50)]
        public string Ad { get; set; }
        [DisplayName("Soyadı *")]
        [StringLength(50)]
        public string Soyad { get; set; }
        [DisplayName("Eposta")]
        [StringLength(250)]
        [EmailAddress]
        public string? Eposta { get; set; }
        [DisplayName("Telefon *")]
        [StringLength(18)]
        [Phone]
        public string Telefon { get; set; }
        [DisplayName("Adres")]
        [StringLength(300)]
        public string? Adres { get; set; }
        [DisplayName("Konu")]
        [StringLength(50)]
        public string? Konu { get; set; }
        [DisplayName("Mesajınız *")]
        [StringLength(500)]
        public string Mesaj { get; set; }
    }
}
