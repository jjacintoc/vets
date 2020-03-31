using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vets.Models
{
    public class Veterinarios
    {
        public Veterinarios()
        {
            //estou a colocar dados na lista
            //na pratica e como se fizesse
            //consultas = select *
            //          from consultas c, veterinario v
            //          where c.veterinarioFK = v.ID AND v.id
            Consultas = new HashSet<Consultas>();
        }
        public int ID { get; set; }

        public string Nome { get; set; }

        public string NumCedulaProf { get; set; }

        public string Fotografia { get; set; }

        //lista das consulta a que um veterinario esta associado
        public ICollection<Consultas> Consultas { get; set; }
    }
}
