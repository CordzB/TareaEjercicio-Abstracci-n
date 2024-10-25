

namespace TareaEjercicio_Abstracción
{
    internal class AreaTriangulo : FormulaMatematica
    {
        private double baseTriangulo;
        private double alturaTriangulo;

        public AreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public override void Calcular()
        {
            // Área = (base * altura) / 2
            double area = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine($"El área del triángulo es: {area}M");
        }

        public override void Imprimir()
        {

        }
    }
}
