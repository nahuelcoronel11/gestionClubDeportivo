using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionClubDeportivo
{
    public class Instalacion
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Actividad ActividadAsignada { get; private set; }

        public Instalacion(string nombre, string tipo, Actividad actividad)
        {
            Nombre = nombre;
            Tipo = tipo;
            ActividadAsignada = actividad ?? throw new ArgumentNullException(nameof(actividad));
        }
    }


}
