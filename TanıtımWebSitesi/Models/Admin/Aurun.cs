using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TanıtımWebSitesi.Models.Admin
{
    public class Aurun
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        [StringLength(100)]

        public string Ad { get; set; }
        [DisplayName("Stok Adedi")]
        public int Stok { get; set; } = 1;
        [DisplayName("Ürün Açıklama")]
        public string? Aciklama { get; set; }
        [DisplayName("Ürün Fiyatı")]
        public decimal Fiyat { get; set; } = 0;
        [DisplayName("Ürün İndirimi")]
        public decimal Indirim { get; set; } = 0;
        [DisplayName("Ürün Görseli")]
        public string? Gorsel { get; set; }
        public int Goruntulenme { get; set; } = 0;

    }
}
