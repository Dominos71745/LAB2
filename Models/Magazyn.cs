using System.ComponentModel.DataAnnotations;

namespace LAB2.Models
{
    public class Magazyn
    {
        public int Id { get; set; }
        public string Produkt { get; set; }
        public int Cena { get; set; }   
        public int Ilosc { get; set; }  

    }
}