using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPsicologia.Models
{
    public class RegistrarPaciente
    {
        public int Terapeuta { get; set; }
        public DateTime Registro { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Fecha_Nacimiento{get;set;}
        public string Escolaridad { get; set; }
        public string Nombre_de_Escuela { get; set; }
        public string Estado_Civil { get; set; }
        public string Ocupacion { get; set; }
        public string Religion { get; set; }
        public string Domicilio { get; set; }
        public Int64 Telefono_Casa { get; set; }
        public Int64 Telefono_Trabajo { get; set; }
        public Int64 Telefono_Celular { get; set; }

        //Historia de Migracion
        public string Lugar_de_Nacimiento { get; set; }
        public string Lugares_donde_ha_vivido_en_el_pais { get; set; }
        public string Tiempo_de_radicar_en_Tijuana { get; set; }
        public string Tiempo_de_radicar_en_USA { get; set; }


        //Evaluacion Socioeconomica
        public string Principal_Fuente_deIngresos { get; set; }
        public int Ingreso_Mensual_Madre { get; set; }
        public int Ingreso_Mensual_Padre { get; set; }
        public int Ingreso_Mensual_Otro { get; set; }
        public Boolean Habita_en_casa_Propia { get; set; }
        //public Boolean Habita_en_casa_Alquilada { get; set; }
        //public Boolean Habita_en_casa_Otro { get; set; }
        public Boolean Tipo_de_Construccion_Madera { get; set; }
        public int Cuantas_personas_habitan_en_la_casa { get; set; }

    }
}
