using static System.Console;

namespace ConsoleApp
{
    //одинак
    public class Odinak
    {
        public static Odinak Instance()
        {
            if (_odinak == null)
            {
                _odinak = new Odinak();
                return _odinak;
            }
            else
            {
                return _odinak;
            }
        }
        Odinak()
        {
        }
        static Odinak _odinak = null;
        int d;
        public int D
        {
            get { return d; }
            set { d = value; }
        }

        public void Print(string text)
        {
            WriteLine("{0}. d = {1}", text, d);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Odinak first = Odinak.Instance();


            if (first != null)
            {
                first.D = 25;
                first.Print("first");
            }
            else
                WriteLine("first == null");
        }
    }
}