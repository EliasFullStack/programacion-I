namespace Elias_Ortiz_ExpressCargo
{
    public interface IEnfriamiento
    {
        // Propiedad para almacenar el tipo de refrigerante del camión. Puede ser "No asignado" si no se ha especificado un refrigerante.
        string TipoRefrigerante { get; set; }

        // Método para activar el modo de enfriamiento extremo del camión, que recibe como parámetro la temperatura objetivo a alcanzar.
        void ActivarFrioExtremo(double temperaturaObjetivo);
    }
}

