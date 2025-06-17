using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace gestionClubDeportivo
{
   
        public class Club
        {
            public List<Socio> Socios { get; private set; } = new List<Socio>();
            public List<Empleado> Empleados { get; private set; } = new List<Empleado>();
            public List<Actividad> Actividades { get; private set; } = new List<Actividad>();
            public List<Instalacion> Instalaciones { get; private set; } = new List<Instalacion>();

            public void AgregarSocio(Socio socio) => Socios.Add(socio);
            public void AgregarEmpleado(Empleado empleado) => Empleados.Add(empleado);
            public void AgregarActividad(Actividad actividad) => Actividades.Add(actividad);
            public void AgregarInstalacion(Instalacion instalacion) => Instalaciones.Add(instalacion);

            public void GuardarEnJson(string ruta)
            {
                var opciones = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(ruta, JsonSerializer.Serialize(this, opciones));
            }

            public static Club CargarDesdeJson(string ruta)
            {
                if (!File.Exists(ruta)) return new Club();
                return JsonSerializer.Deserialize<Club>(File.ReadAllText(ruta)) ?? new Club();
            }
        }


}
