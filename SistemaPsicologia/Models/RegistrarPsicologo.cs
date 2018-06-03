using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPsicologia.Models
{
    public class RegistrarPsicologo
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Semestre { get; set; }
        public string Telefono { get; set; }

    }
}
