using System.Xml;

namespace GrundläggandeObjekt_lander
{
    internal class Program
    {
        public class Land
        {
            public string namn = "", styrestyp = "", huvudstad = ""; 
            public int invånare = 0; 
        }
        static void Main(string[] args)
        {
            Land sverige = new Land() { namn = "Sverige", styrestyp = "Monarki", huvudstad = "Stockholm", invånare = 505050}  ;
            Land tyskland = new Land() { namn = "Tyskland", styrestyp = "republik", huvudstad = "Berlin", invånare = 898989 };
            Land sanMarino = new Land() { namn = "San Marino", styrestyp = "republik", huvudstad = "San Marino", invånare = 333333 };

            Console.WriteLine("Hello, World!");
        }
    }
}