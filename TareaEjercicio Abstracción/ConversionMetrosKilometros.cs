

namespace TareaEjercicio_Abstracción
{
    public class ConversionMetrosKilometros : FormulaMatematica
    {
        private double metros;

        public ConversionMetrosKilometros(double metros)
        {
            this.metros = metros;
        }

        public override void Calcular()
        {
            // 1 kilómetro = 1000 metros
            double kilometros = metros / 1000;
            Console.WriteLine($"{metros} metros son {kilometros} kilómetros.");
        }

        public override void Imprimir()
        {
            
        }
    }
}
