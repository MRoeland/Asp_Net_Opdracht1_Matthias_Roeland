namespace Asp_Net_Opdracht1_Matthias_Roeland.Models
{
    public class Leden
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Naam")]
        public String Naam { get; set; }

        [Required]
        [Display(Name = "Adres")]
        public string Adres { get; set; }

        [Required]
        [Display(Name = "TelNr")]
        public string TelNr { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
