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
                Console.WriteLine($"Land: {namn}\nStyre: {styrestyp}\nHuvudstad: {huvudstad}\nInvånarantal: {invånare}\n");
            }
        }
        static void Main(string[] args)
        {
            Land sverige = new Land() { namn = "Sverige", styrestyp = "monarki", huvudstad = "Stockholm", invånare = 565687854 };
            Land tyskland = new Land() { namn = "Tyskland", styrestyp = "republik", huvudstad = "Berlin", invånare = 4580244 };
            Land sanMarino = new Land() { namn = "San Marino", styrestyp = "republik", huvudstad = "San Marino", invånare = 15857 };

            sverige.Print();
            tyskland.Print();
            sanMarino.Print();
            
            Land[] länder = new Land[7] { sverige, tyskland, sanMarino, null, null, null, null };
            länder[3] = new Land() { namn = "Danmark", styrestyp = "monarki", huvudstad = "Köpenhamn", invånare = 458662 };
            länder[4] = new Land { namn = "Italien", styrestyp = "republik", huvudstad = "Rom", invånare = 1156635 };
            länder[5] = new Land { namn = "Tjeckien", styrestyp = "republik", huvudstad = "Warsawa", invånare = 989966 };
            länder[6] = new Land { namn = "Rumänien", styrestyp = "republik", huvudstad = "Bukarest", invånare = 878855 };
            Console.WriteLine();
            
            foreach(Land l in länder) { l.Print(); };
            Console.WriteLine();
            
            for (int i =0; i<länder.Length; i++)
            {
                if (länder[i].styrestyp=="republik")
                    Console.WriteLine($"[{i}] {länder[i].namn}");

            }
            Console.WriteLine();

            int minPop=-1;
            int maxPop=-1;

            for (int i = 0; i < länder.Length; i++)
            {
                if (länder[i].styrestyp == "republik")
                {
                    if (minPop == -1)
                    {
                        minPop = i;
                        maxPop = i;
                    }
                    else
                    {
                        minPop = (länder[i].invånare < länder[minPop].invånare) ? i : minPop;
                        maxPop = (länder[i].invånare > länder[maxPop].invånare) ? i : maxPop;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"===Republik med minsta invånarantal===");länder[minPop].Print();

            Console.WriteLine();
            Console.WriteLine($"===Republik med högsta invånarantal==="); länder[maxPop].Print();
            
        }
    }
}