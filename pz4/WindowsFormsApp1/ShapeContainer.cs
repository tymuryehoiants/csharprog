using System.Collections.Generic;
using System.Linq;

namespace Lab4_Shapes
{
    
    public class ShapeContainer
    {
        private List<Shape> shapes;

        public ShapeContainer()
        {
            shapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void RemoveShape(int index)
        {
            if (index >= 0 && index < shapes.Count)
            {
                shapes.RemoveAt(index);
            }
        }

        public List<Shape> GetAllShapes()
        {
            return shapes;
        }

        
        public double GetTotalArea()
        {
            return shapes.Sum(s => s.CalculateArea());
        }
    }
}