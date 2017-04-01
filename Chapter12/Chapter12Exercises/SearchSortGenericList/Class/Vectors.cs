using System.Collections.Generic;
using System.Text;

namespace SearchSortGenericList.Class
{
    public class Vectors : List<Vector>
    {
        public Vectors() { }

        public Vectors(IEnumerable<Vector> intialItems)
        {
            foreach (Vector vector in intialItems)
            {
                Add(vector);
            }
        }

        public string Sum()
        {
            StringBuilder sb = new StringBuilder("origin");
            Vector currentPoint = new Vector(0.0, 0.0);
            ForEach((v) =>
            {
                sb.AppendFormat($" + {v}");
                currentPoint += v;
            }
            );
            sb.AppendFormat($" = {currentPoint}");
            return sb.ToString();
        }
    }
}
