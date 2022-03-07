using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuniKitchen_Final.Models
{
    [Table("Product")]
    public class Product
    {
        [Display(Name = "Product Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "{0} cannot be null")]
        public string ProductName { get; set; }

        [Display(Name = "Product Description")]
        public string ProductDesc { get; set; }

        [Display(Name = "Product Image Name")]
        public string ProductImage { get; set; }

        [Display(Name = "Product Price")]
        [Required]
        public int ProdPrice { get; set; }

        [Display(Name = "Product Stock")]
        [Required]
        public int ProdStock { get; set; }



        [Display(Name = "Category Id")]
        [ForeignKey(nameof(Product.category))]
        public int CategoryId { get; set; }

        public Category category { get; set; }
    }
}
