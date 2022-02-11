using System.ComponentModel.DataAnnotations;

namespace bronzetti.christian._5H.WebCRUD.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Titolo", Prompt = "Inserire il titolo...", Description = "Inserisci una descrizione" )]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data di pubblicazione", Prompt = "Inserire la data di pubblicazione...", Description = "Inserisci una descrizione" )]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Genere", Prompt = "Inserire il genere...", Description = "Inserisci una descrizione" )]
        public string? Genre { get; set; }

        [Display(Name = "Prezzo", Prompt = "Inserire il prezzo...", Description = "Inserisci una descrizione" )]
        public decimal Price { get; set; }
    }
}