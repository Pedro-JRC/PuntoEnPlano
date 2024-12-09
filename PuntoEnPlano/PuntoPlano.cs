namespace PuntoEnPlano
{
    public class PuntoPlano
    {
        // PROPIEDADES DE COORDENADAS
        private double x;
        private double y;

        // METODO CARGA LOS VALORES
        public void CargaValor(double coordenadaX, double coordenadaY)
        {
            x = coordenadaX;
            y = coordenadaY;
        }

        // METODO PARA VERIFICAR DONDE SE ENCUENTRA EL PUNTO
        public string cuadrantePunto()
        {
            if (x > 0 && y > 0)
                return "El punto se encuentra en el cuadrante [1]";
            else if (x < 0 && y > 0)
                return "El punto se encuentra en el cuadrante [2]";
            else if (x < 0 && y < 0)
                return "El punto se encuentra en el cuadrante [3]";
            else if (x > 0 && y < 0)
                return "El punto se encuentra en el cuadrante [4]";
            else if (x == 0 && y == 0)
                return "El punto se encuentra en el lugar de origen";
            else if (x == 0)
                return "El punto se encuentra en el eje Y";
            else
                return "El punto se encuentra en el eje X";



        }

        // METODO MUESTRA EL RESULTADO
        public void Resultado()
        {
            Console.WriteLine(cuadrantePunto());
        }
    }
}
