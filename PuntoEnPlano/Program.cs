namespace PuntoEnPlano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            PuntoPlano puntoPlano = new PuntoPlano();
            string digitaX;
            string digitaY;
            double x;
            double y;

            try
            {
                // SOLICITA LA COORDENADA X
                Console.Write("Favor ingrese la coordenada X: ");
                digitaX = Console.ReadLine();

                // VALIDACIONES
                if (double.TryParse(digitaX, out x))
                {
                    // SOLICITA LA COORDENADA Y
                    Console.Write("\nFavor ingrese la coordenada Y: ");
                    digitaY = Console.ReadLine();

                    // VALIDACIONES
                    if (double.TryParse(digitaY, out y))
                    {
                        // CARGA LAS CORRDENADAS
                        puntoPlano.CargaValor(x, y);

                        // MUESTRA EL RESULTADO
                        Console.WriteLine("\nResultado:");
                        puntoPlano.Resultado();
                    }

                }
                else
                {
                    Console.WriteLine($"ERROR: Favor ingrese un valor valido");
                }

               
            }
            catch (Exception)
            {
                Console.WriteLine($"ERROR: Favor ingrese un valor valido");
            }
        }
    }
}
