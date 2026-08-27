using System;

namespace Elias_Ortiz_ExpressCargo
{
    public class Camion : VehiculoEnvio, IEnfriamiento
    {
        // Propiedad para almacenar la temperatura de la cámara de frío del camión. Puede ser un valor negativo si el camión está refrigerado.
        public double TemperaturaCamara { get; set; }
        // Propiedad para almacenar el tipo de refrigerante del camión. Puede ser "No asignado" si no se ha especificado un refrigerante.  
        public string TipoRefrigerante { get; set; }

        // Constructor de la clase Camion que recibe los parámetros necesarios para inicializar un objeto de tipo Camion, incluyendo la temperatura de la cámara de frío.
        public Camion(
            string idPatente,
            double capacidadCargaKg,
            int nivelCombustiblePorcentaje,
            double costoBaseEnvio,
            double temperaturaCamara
        ) : base(idPatente, capacidadCargaKg, nivelCombustiblePorcentaje, costoBaseEnvio)
        {
            TemperaturaCamara = temperaturaCamara;
            TipoRefrigerante = "No asignado";
        }

        // Imprimir en pantalla la ficha técnica del camión, incluyendo patente, capacidad de carga, nivel de combustible, costo base de envío, temperatura de la cámara de frío, tipo de refrigerante y costo total de envío.
        public override void MostrarFichaTecnica()
        {   
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n========= TIPO: CAMIÓN ==========\n");
            Console.ResetColor();
            
            base.MostrarFichaTecnica();


                // --- Propiedades extra de Camión ---

            // 1. Temperatura cámara frío
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Temperatura cámara frío".PadRight(23));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{TemperaturaCamara}°C");

            // 2. Tipo refrigerante
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Tipo refrigerante".PadRight(23));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(TipoRefrigerante);

            // 3. Costo total envío
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Costo total envío".PadRight(23));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{CalcularCostoTotal():C0}");

            // Separador final en Gris
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================================");

            // Restaurar color a blanco (por si acaso)
            Console.ResetColor();
        }

        // Calcular el costo total de envío, que puede ser diferente según el tipo de vehículo (drone, camión, etc.)
        public override double CalcularCostoTotal()
        {
            return CostoBaseEnvio + (CapacidadCargaKg * 1500);
        }

        // Implementación del método ActivarFrioExtremo de la interfaz IEnfriamiento
        public void ActivarFrioExtremo(double temperaturaObjetivo)
        {
            if (TipoRefrigerante == "No asignado")
            {
                throw new Exception(
                    "No se puede activar el sistema de frío sin un refrigerante certificado instalado."
                );
            }

            TemperaturaCamara = temperaturaObjetivo;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                $"Sistema de frío activado. Temperatura estabilizada en {TemperaturaCamara}°C"
            );
            Console.ResetColor();
        }
    }
}