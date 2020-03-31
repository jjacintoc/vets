using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vets.Models
{
    public class Consultas
    {
        [Key]
       public int ID { get; set; }


        public DateTime Data { get; set; }

        public string Observacoes { get; set; }

        [ForeignKey(nameof(Animal))]
        //fk para animais
        public int AnimalFK { get; set; }
        
        public Animais Animal { get; set; }


        [ForeignKey(nameof(Veterinario))]
        //fk para veterinarios
        public int VeterinariosFK { get; set; }

        public Veterinarios Veterinario { get; set; }

    }
}
