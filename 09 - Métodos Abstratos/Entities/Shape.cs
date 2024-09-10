using _09___Métodos_Abstratos.Entities.Enums;

namespace _09___Métodos_Abstratos.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
