namespace Elias_Ortiz_ExpressCargo
{
    public class Drone : VehiculoEnvio
    {
        // Propiedad para almacenar el número de motores del dron. Puede ser un valor entero positivo.
        public int NroMotores { get; set; }

        //  Constructor de la clase Drone que recibe los parámetros necesarios para inicializar un objeto de tipo Drone, incluyendo el número de motores.
        public Drone(
            string idPatente,
            double capacidadCargaKg,
            int nivelCombustiblePorcentaje,
            double costoBaseEnvio,
            int nroMotores
        ) : base(idPatente, capacidadCargaKg, nivelCombustiblePorcentaje, costoBaseEnvio)
        {
            NroMotores = nroMotores;
        }

        // imprimir en pantalla la ficha técnica del vehículo de envío, incluyendo patente, capacidad de carga, nivel de combustible, costo base de envío, número de motores y costo total de envío
        public override void MostrarFichaTecnica()
        {
            // Encabezado específico del tipo (Cyan)
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n========= TIPO: DRONE ==========\n");
            Console.ResetColor();

            // Llamar a la base para que imprima el título y datos comunes
            base.MostrarFichaTecnica();

            // --- Propiedades extra de Drone ---

            // Número de motores
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Número de motores".PadRight(23));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(NroMotores);

            // Costo total
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Costo total envío ".PadRight(23));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{CalcularCostoTotal():C0}");

            // Separador final (gris)
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================================");

            // Restaurar color a blanco para el resto del programa
            Console.ResetColor();
        }

        


        // Calcular el costo total de envío, que puede ser diferente según el tipo de vehículo (drone, camión, etc.)
        public override double CalcularCostoTotal()
        {
            return CostoBaseEnvio + (CapacidadCargaKg * 500);
        }
    }
}