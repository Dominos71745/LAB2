using System.ComponentModel.DataAnnotations;

namespace LAB2.Models
{
    public class Zamowienia
    {
        public int Id { get; set; }
        public string Produkt { get; set; }

        [Display(Name = "Data zamówienia")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        [Display(Name = " Wartość zamówienia")]
        public int WartoscZamowienia { get; set; }
        [Display(Name = " Status zamówienia")]

        public string StatusZamowienia { get; set; }
    }
}