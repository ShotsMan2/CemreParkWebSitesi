using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TanıtımWebSitesi.Models.Admin
{
    public class Afirma
    {
        public int Id { get; set; }
        [DisplayName("Firma Adı")]
        [StringLength(100)]
        public string Ad { get; set; }
        [DisplayName("WhatsApp Numarası")]
        [StringLength(20)]
        public string WhatsApp { get; set; }
        [DisplayName("Telefon Numarası")]
        [StringLength(20)]
        public string Telefon { get; set; }
        [DisplayName("Adres")]
        [StringLength(500)]
        public string Adres { get; set; }
        [DisplayName("FaceBook Adresi")]
        [StringLength(500)]
        public string? FaceBook { get; set; }
        [DisplayName("Instagram Adresi")]
        [StringLength(500)]
        public string? Instagram { get; set; }
        [DisplayName("Youtube Adresi")]
        [StringLength(500)]
        public string? YouTube { get; set; }
        [DisplayName("Twitter adresi")]
        [StringLength(500)]
        public string? Twitter { get; set; }
        [DisplayName("Linkedln Adresi")]
        [StringLength(500)]
        public string? Linkedln { get; set; }
        [DisplayName("Kurumsal Bilgi")]
        public string? Kurumsal { get; set; }
        [DisplayName("Logo")]
        public string Logo { get; set; }
        


    }
}
