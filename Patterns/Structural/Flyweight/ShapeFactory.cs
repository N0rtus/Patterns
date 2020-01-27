using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class ShapeFactory
    {
        private Dictionary<string, IShape> _shapes = new Dictionary<string, IShape>();

        public int ShapesCount { get { return _shapes.Count; } }

        public IShape GetShape(string name)
        {
            if (_shapes.ContainsKey(name))      
            {
                return _shapes[name];
            }

            if (name == "Circle")
            {
                var shape = new Circle();

                _shapes.Add(name,shape);

                return shape;
            }

            if (name == "Regtangle")
            {
                var shape = new Regtangle();

                _shapes.Add(name, shape);

                return shape;
            }

            throw new InvalidOperationException();
        }
    }
}
