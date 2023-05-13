namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Console.ReadLine();
            Application.Run(new SeleccionarMetodo());
        }
    }
}