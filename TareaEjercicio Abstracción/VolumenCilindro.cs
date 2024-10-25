

namespace TareaEjercicio_Abstracción
{
    public class VolumenCilindro : FormulaMatematica
    {
        private double radio;
        private double altura;

        public VolumenCilindro(double radio, double altura)
        {
            this.radio = radio;
            this.altura = altura;
        }

        public override void Calcular()
        {
            // Volumen = π * r^2 * h
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;
            Console.WriteLine($"El volumen del cilindro es: {volumen}");
        }

        public override void Imprimir()
        {
           
        }
    }
}
