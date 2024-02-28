using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmak zorundadır")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Display(Name = "Açıklama")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmak zorundadır")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Display(Name = "Ad")]

        public int Stock { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Display(Name = "Popüler")]
        public bool Popular { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Display(Name = "Onay")]

        public bool IsApproved { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Display(Name = "Ürün Resmi")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Cart> Cart { get; set;}
        public virtual List<Sales> Sales { get; set; }
    }
}
