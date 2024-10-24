using TareaEjercicio_Abstracción;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calcular área del triángulo");
            Console.WriteLine("2. Convertir metros a kilómetros");
            Console.WriteLine("3. Calcular volumen de un cilindro");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
           
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la base del triángulo: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                    FormulaMatematica triangulo = new AreaTriangulo(baseTriangulo, alturaTriangulo);
                    triangulo.Calcular();
                    triangulo.Imprimir();
                    break;

                case "2":
                    Console.Write("Ingrese la cantidad de metros: ");
                    double metros = Convert.ToDouble(Console.ReadLine());
                    FormulaMatematica conversion = new ConversionMetrosKilometros(metros);
                    conversion.Calcular();
                    conversion.Imprimir();
                    break;

                case "3":
                    Console.Write("Ingrese el radio del cilindro: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del cilindro: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    FormulaMatematica cilindro = new VolumenCilindro(radio, altura);
                    cilindro.Calcular();
                    cilindro.Imprimir();
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}
