namespace Elias_Ortiz_ExpressCargo
{
    public class VehiculoEnvio
    {
        // Propiedades comunes a todos los vehículos de envío, como patente, capacidad de carga, nivel de combustible y costo base de envío.
        public string IdPatente { get; set; }
        //  Propiedad para almacenar la capacidad de carga del vehículo en kilogramos. Puede ser un valor decimal positivo.
        public double CapacidadCargaKg { get; set; }
        //  Propiedad para almacenar el nivel de combustible del vehículo en porcentaje. Puede ser un valor entero entre 0 y 100.   
        public int NivelCombustiblePorcentaje { get; set; }
        //  Propiedad para almacenar el costo base de envío del vehículo. Puede ser un valor decimal positivo.
        public double CostoBaseEnvio { get; set; }

        // Constructor de la clase VehiculoEnvio que recibe los parámetros necesarios para inicializar un objeto de tipo VehiculoEnvio, incluyendo patente, capacidad de carga, nivel de combustible y costo base de envío.
        public VehiculoEnvio(
            string idPatente,
            double capacidadCargaKg,
            int nivelCombustiblePorcentaje,
            double costoBaseEnvio
        )
        {
            IdPatente = idPatente;
            CapacidadCargaKg = capacidadCargaKg;
            NivelCombustiblePorcentaje = nivelCombustiblePorcentaje;
            CostoBaseEnvio = costoBaseEnvio;
        }

        // imprimir en pantalla la ficha técnica del vehículo de envío, incluyendo patente, capacidad de carga, nivel de combustible y costo base de envío
        public virtual void MostrarFichaTecnica()
        {

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("=========");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" FICHA TÉCNICA ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=========");

            // Patente
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Patente".PadRight(23));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(IdPatente);

            // Capacidad
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Capacidad de carga".PadRight(23));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{CapacidadCargaKg:N0} kg");

            // Combustible
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Nivel de combustible".PadRight(23));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{NivelCombustiblePorcentaje}%");

            // Costo base
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Costo base de envío".PadRight(23));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{CostoBaseEnvio:C0}");

            // Restaurar color a blanco para el resto del programa
            Console.ResetColor();
        }





        //  Calcular el costo total de envío, que puede ser diferente según el tipo de vehículo (drone, camión, etc.)
        public virtual double CalcularCostoTotal()
        {
            return CostoBaseEnvio;
        }
    }
}