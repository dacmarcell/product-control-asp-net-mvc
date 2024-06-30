using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ProductControl.Models
{
    [Index(nameof(BarCode), IsUnique=true)]
    public class ProductModel
    {
        public Int64? Id { get; set; }

        [Required(ErrorMessage ="This field is required!")]
        public string Description { get; set; } = string.Empty;

        [StringLength(12, MinimumLength =12, ErrorMessage ="Minimum 12 characters.")]
        [Required(ErrorMessage ="This field is required!")]
        public string BarCode { get; set; } = string.Empty;

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Date)]
        public DateTime ValidityDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime RegistryDate { get; set; }

        [Range(1,1000)]
        public int Quantity { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName="decimal(18,2)")]
        public Decimal? Price { get; set; }

        [MaybeNull]
        public string? PhotoName { get; set; }

        [MaybeNull]
        public byte[]? Photo { get; set; }

        [MaybeNull]
        public bool Active { get; set; }

    }
}
