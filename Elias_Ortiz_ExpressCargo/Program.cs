using System;
using System.Collections.Generic;

namespace Elias_Ortiz_ExpressCargo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista para almacenar los vehículos de envío
            List<VehiculoEnvio> flotaLogistica = new List<VehiculoEnvio>();

            // Crear instancias de vehículos de envío y agregarlas a la flota logística
            Drone drone = new Drone(
                "DR-001",
                4.5,
                90,
                3000,
                4
            );

            // Crear instancias de camiones sin refrigerante
            Camion camionSinRefrigerante = new Camion(
                "CAM-001",
                1200.0,
                10,
                25000,
                5
            );

            // Crear instancias de camiones con refrigerante
            Camion camionConRefrigerante = new Camion(
                "CAM-002",
                850.0,
                80,
                25000,
                -5
            );

            // Asignar el tipo de refrigerante al camión con refrigerante
            camionConRefrigerante.TipoRefrigerante = "EcoChill-R410";


            flotaLogistica.Add(drone);
            flotaLogistica.Add(camionSinRefrigerante);
            flotaLogistica.Add(camionConRefrigerante);


            // Mostrar la ficha técnica de cada vehículo de envío en la flota logística
            foreach (VehiculoEnvio vehiculo in flotaLogistica)
            {
                vehiculo.MostrarFichaTecnica();

                // Verificar el nivel de combustible y mostrar una alerta si es crítico
                if (vehiculo.NivelCombustiblePorcentaje < 15)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("⚠️  ALERTA: Combustible crítico. Detener ruta ⚠️");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("✅ Energía: Autonomía segura ✅");
                    Console.ResetColor();
                }

                Console.WriteLine();
            }


            // Intentar activar el frío extremo en los camiones y manejar excepciones
            try
            {
                camionSinRefrigerante.ActivarFrioExtremo(-20);
            }
            catch (Exception error)
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"❌ ERROR: {error.Message} ❌");
                Console.ResetColor();
            }


            // Intentar activar el frío extremo en el camión con refrigerante y manejar excepciones
            try
            {
                camionConRefrigerante.ActivarFrioExtremo(-25);
            }
            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"❌ ERROR: {error.Message} ❌");
                Console.ResetColor();
            }


            Console.WriteLine("\nProceso finalizado.");
            Console.ReadKey();
        }
    }
}