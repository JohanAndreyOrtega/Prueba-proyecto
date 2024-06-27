using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Reporte todos los pagos");
            Console.WriteLine("2. Reporte ver pagos por tipos de servicios");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ReporteTodosLosPagos();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el tipo de servicio que desea ver en el reporte: ");
                    string tiposervicio = Console.ReadLine();
                    ReportePagosPorTipoServicio(tiposervicio);
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }

        static void ReporteTodosLosPagos()
        {
            Console.WriteLine("Mostrando reporte de todos los pagos realizados");

        }

        static void ReportePagosPorTipoServicio(string tiposervicio)
        {
            Console.WriteLine($"Mostrando reporte de pagos realizados para el tipo de servicio :{tiposervicio}");
        }
    }
}
