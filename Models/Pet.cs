using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoPet.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Raca { get; set; }
        public Especie Especie { get; set; }
        [ForeignKey("Tutor")]
        public int TutorId { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}