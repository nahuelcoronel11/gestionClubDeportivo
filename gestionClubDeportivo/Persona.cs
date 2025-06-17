using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionClubDeportivo
{
    public class Persona : IMiembroDelClub
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public int DiaNacimiento { get; set; }
        public int MesNacimiento { get; set; }
        public int AnioNacimiento { get; set; }

        public Persona() { }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"{Nombre} {Apellido}, DNI: {Dni}, Fecha Nac: {{DiaNacimiento:D2}}/{{MesNacimiento:D2}}/{{AnioNacimiento}}");
        }
    }
}