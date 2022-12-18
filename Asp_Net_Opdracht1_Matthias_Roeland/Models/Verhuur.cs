namespace Asp_Net_Opdracht1_Matthias_Roeland.Models
{
    public class Verhuur
    {
        [Required]
        [Display(Name = "VerhuurId")]
        public int VerhuurId { get; set; }

        [Required]
        [Display(Name = "LidId")]
        public int LidId { get; set; }

        [Required]
        [Display(Name = "UitleenDatum")]
        public string UitleenDatum { get; set; }

        [Display(Name = "TerugDatum")]
        public string TerugDatum { get; set; }
        [Required]
        [Display(Name = "TotaalPrijs")]
        public float TotaalPrijs { get; set; }
    }
}
