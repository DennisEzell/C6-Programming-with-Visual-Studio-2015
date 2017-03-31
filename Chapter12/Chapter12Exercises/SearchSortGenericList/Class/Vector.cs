using static System.Math;
using System.Collections.Generic;
using System.Text;

namespace SearchSortGenericList.Class
{
    public class Vector
    {
        public double? R = null;
        public double? Theta = null;

        //Convert degrees to radians
        public double? ThetaRadians
        {
            get { return (Theta * PI / 180.0); }
        }

        public Vector(double? r, double? theta)
        {
            //Normalize
            if (r < 0)
            {
                r = -r;
                theta += 180;
            }

            theta = theta % 360;

            //Assign fields.
            R = r;
            Theta = theta;
        }

        public static Vector operator +(Vector op1, Vector op2)
        {
            try
            {
                //Get (x,y) coordinates for new vector
                double newX = op1.R.Value * Sin(op1.ThetaRadians.Value)
                    + op2.R.Value * Sin(op2.ThetaRadians.Value);

                double newY = op1.R.Value * Cos(op1.ThetaRadians.Value)
                    + op2.R.Value * Cos(op2.ThetaRadians.Value);

                //Convert to (r, theta)
                double newR = Sqrt(newX * newX + newY * newY);
                double newTheta = Atan2(newX, newY) * 180.0 / PI;

                return new Vector(newR, newTheta);
            }
            catch
            {
                //Return "null" Vector
                return new Vector(null, null);
            }
        }

        //Unary - operator overload
        public static Vector operator -(Vector op1) => new Vector(-op1.R, -op1.Theta);
        //Binary - operator overload
        public static Vector operator -(Vector op1, Vector op2) => op1 + (-op2);

        public override string ToString()
        {
            string rString = R?.ToString() ?? "null";
            string thetaString = Theta?.ToString() ?? "null";

            return $"({rString}, {thetaString})";
        }

        public class Vectors : List<Vector>
        {
            public Vectors() { }

            public Vectors(IEnumerable<Vector> intialItems)
            {
                foreach(Vector vector in intialItems)
                {
                    Add(vector);
                }
            }

            public string Sum()
            {
                StringBuilder sb = new StringBuilder("origin");
                Vector currentPoint = new Vector(0.0, 0.0);
                ForEach( (v) => 
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
}
