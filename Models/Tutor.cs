using System.Collections.Generic;

namespace ProjetoPet.Models
{
    public class Tutor
    {
        public int TutorId { get; set; }
        public string  Nome { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
    }
}