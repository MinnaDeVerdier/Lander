namespace GrundläggandeObjekt_lander
{
    internal class Program
    {

        public class Land
        {
            public string namn = "", styrestyp = "", huvudstad = "";
            public int invånare = 0;
            public void Print()
            {
                Console.WriteLine($"{namn}    {styrestyp}    {huvudstad}    {invånare}");
            }
        }
        static void Main(string[] args)
        {
            Land sverige = new Land() { namn = "Sverige", styrestyp = "monarki", huvudstad = "Stockholm", invånare = 101010 };
            Land tyskland = new Land() { namn = "Tyskland", styrestyp = "republik", huvudstad = "Berlin", invånare = 202020 };
            Land sanMarino = new Land() { namn = "San Marino", styrestyp = "republik", huvudstad = "San Marino", invånare = 303030 };

            sverige.Print();
            tyskland.Print();
            sanMarino.Print();
            Land[] länder = new Land[7] { sverige, tyskland, sanMarino, null, null, null, null };
            länder[3] = new Land() { namn = "Danmark", styrestyp = "monarki", huvudstad = "Köpenhamn", invånare = 404040 };
            länder[4] = new Land { namn = "Italien", styrestyp = "republik", huvudstad = "Rom", invånare = 505050 };
            länder[5] = new Land { namn = "Tjeckien", styrestyp = "republik", huvudstad = "Warsawa", invånare = 606060 };
            länder[6] = new Land { namn = "Rumänien", styrestyp = "republik", huvudstad = "Bukarest", invånare = 707070 };
            Console.WriteLine();
            foreach(Land l in länder) { l.Print(); };
            Console.WriteLine();
            foreach(Land l in länder) 
            { 
                if(l.styrestyp=="republik")
                    Console.WriteLine(l.namn);
            };
        }
    }
}