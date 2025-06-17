using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionClubDeportivo
{

    public class Empleado : Persona
    {
        public PuestoEmpleado Puesto { get; set; }
        public decimal Sueldo { get; set; }

        public Empleado(string nombre, string apellido, string dni, int dia, int mes, int anio, PuestoEmpleado puesto, decimal sueldo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.DiaNacimiento = dia;
            this.MesNacimiento = mes;
            this.AnioNacimiento = anio;
            this.Puesto = puesto;
            this.Sueldo = sueldo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Empleado - Puesto: {Puesto}, Sueldo: ${Sueldo}");
        }
    }
}