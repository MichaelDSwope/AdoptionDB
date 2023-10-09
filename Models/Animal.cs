

namespace AdoptionDB.Models
{
    public class Animal
    {
        public int Id { get; set; } 
        public int Age { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Breed { get; set; }
        public bool AnimalAdoptionReady { get; set; }
    }
}
