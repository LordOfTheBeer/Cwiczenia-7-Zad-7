namespace Cwiczenia_7_Zad_7
{
    static class FunkcjePrzeciazone
    {
        static public double Dzielenie(int a, int b)
        {
            return a / b;
        }
        static public double Dzielenie(double a, double b)
        {
            return a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FunkcjePrzeciazone.Dzielenie(12, 5));
            Console.WriteLine(FunkcjePrzeciazone.Dzielenie(12.0, 5.0));
        }
    }
}