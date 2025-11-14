using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TanıtımWebSitesi.Models.Admin
{
    public class Ailetişim
    {
        public int Id { get; set; }
        [DisplayName("Adınız")]
        [StringLength(50)]
        public string Ad { get; set; }
        [DisplayName("Soyadınız")]
        [StringLength(50)]
        public string Soyad { get; set; }
        [DisplayName("Telefon Nu.")]
        [StringLength(20)]
        public string Telefon { get; set; }
        [DisplayName("E-posta Adresiniz")]
        [StringLength(500)]
        public string  Eposta { get; set; }
        [DisplayName("Mesajınız")]
        [StringLength(1000)]
        public string Mesaj { get; set; }
        public DateTime Tarih { get; set; }= DateTime.Now;
        public bool Okundu { get; set; }= false;

                
    }
}
