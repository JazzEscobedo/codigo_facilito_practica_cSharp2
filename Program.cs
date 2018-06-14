using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo_facilito
{
    class Program
    {
        static void Main(string[] args)
        {
           clsEmpleados empleado;
           empleado = new clsEmpleados();
           empleado.Edad=24;
           empleado.Nombre="Jazz";
           empleado.SueldoDiario=100.0m;
           decimal total;
           total = empleado.CalculaSalarioMensual(20);
           Console.WriteLine("El salario mensual del empleado " + empleado.Nombre);
           Console.WriteLine("es " + total.ToString() );
           Console.ReadKey();

           

        }
    }
}
