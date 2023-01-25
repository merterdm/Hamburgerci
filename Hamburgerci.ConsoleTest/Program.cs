namespace Hamburgerci.ConsoleTest
{
    //Herseyi babasi bu delegate kavramidir.
    public delegate void SayiHandler(int a);
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //SayiHandler kareAlHandler = KAreAl;
            //kareAlHandler.Invoke(5);

            SayiHandler kare = (a) => { global::System.Console.WriteLine(a*a); };
            kare.Invoke(5);
 
            var action = new Action<int>(KAreAl);
            action.Invoke(5);

            var func = new Func<int, double>(KupAl);
             Console.WriteLine(func.Invoke(3));
           
            //Kendi Olusturdugumuz Nesne Tipimizden bir sonuc donmek istersek
            //func delegate kullanmak zorundayiz
            var funcDelegate = new Func<int, int, MathSonuc>(DortIslem);

            var sonuc = funcDelegate.Invoke(8, 4);
            Console.WriteLine("Toplam:"+sonuc.Toplam);
            Console.WriteLine("Cikarma:" + sonuc.Cikarma);
            Console.WriteLine("Carpma:" + sonuc.Carpma);
            Console.WriteLine("Bolme:" + sonuc.Bolme);
            

            
            Console.WriteLine("Hello, World!");
        }
       
        
        
        public static void KAreAl(int a)
        {
            Console.WriteLine(a * a);
        }
        public static double KupAl(int a)
        {
           return a * a*a;
        }

        public static MathSonuc DortIslem(int a, int b)
        {
            MathSonuc sonuc = new MathSonuc();
            sonuc.Toplam = a + b;
            sonuc.Cikarma = a - b;
            sonuc.Carpma = a * b;
            sonuc.Bolme = a / b;
            return sonuc;

        }

    }

    class MathSonuc
    {
       public  double Toplam = 0;
       public  double Carpma= 0;
       public  double Bolme = 0;
       public  double Cikarma = 0;
    }
}