namespace Asp_Net_Opdracht1_Matthias_Roeland.Models
{
    public class VerhuurLijn
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "VerhuurId")]
        public int VerhuurId { get; set; }

        [Required]
        [Display(Name = "FilmId")]
        public int FilmId { get; set; }

        [Required]
        [Display(Name = "Prijs")]
        public float Prijs { get; set; }

        [Required]
        [Display(Name = "UitleenDatum")]
        public string UitleenDatum { get; set; }

        [Display(Name = "TerugDatum")]
        public string TerugDatum { get; set; }
    }
}
