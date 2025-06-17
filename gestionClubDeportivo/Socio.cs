using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionClubDeportivo
{
    public class Socio : Persona
    {
        public CategoriaSocio Categoria { get; set; }
        public decimal CuotaMensual { get; set; }

        public Socio(string nombre, string apellido, string dni, int dia, int mes, int anio, CategoriaSocio categoria, decimal cuotaMensual)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.DiaNacimiento = dia;
            this.MesNacimiento = mes;
            this.AnioNacimiento = anio;
            this.Categoria = categoria;
            this.CuotaMensual = cuotaMensual;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Socio - Categoría: {Categoria}, Cuota: ${CuotaMensual}");
        }
    }
}
