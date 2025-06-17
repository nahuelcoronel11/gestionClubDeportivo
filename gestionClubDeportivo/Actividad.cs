using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionClubDeportivo
{
        public class Actividad
        {
            public string Nombre { get; set; }
            public string Dias { get; set; }
            public string Horarios { get; set; }

            private List<Socio> socios = new List<Socio>();
            public IReadOnlyList<Socio> Socios => socios.AsReadOnly();

            public Actividad(string nombre, string dias, string horarios)
            {
                Nombre = nombre;
                Dias = dias;
                Horarios = horarios;
            }

            public void AgregarSocio(Socio socio)
            {
                if (!socios.Contains(socio))
                    socios.Add(socio);
            }

            public void QuitarSocio(Socio socio)
            {
                socios.Remove(socio);
            }
        }

}
