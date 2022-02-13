using System.ComponentModel.DataAnnotations;

namespace SecondByksWebsite.Models
{
    public class Bike
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public string model { get; set; }
        public DateTime Cretaedtime { get; set; } = DateTime.Now;
        public DateTime dateTime { get; set; }= DateTime.Now;

    }
}
