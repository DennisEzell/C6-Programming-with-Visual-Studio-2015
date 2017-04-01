
namespace SearchSortGenericList.Class
{
    public class VectorDelegate
    {
        public static int Compare(Vector x, Vector y)
        {
            return (x.R == y.R) ? 0
                  : (x.R > y.R) ? 1
                  : -1;
        }

        public static bool TopRightQuadrant(Vector x) => (x.Theta >= 0.0 && x.Theta <= 90.0) ? true : false;        
    }
}
