using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NationsoftheWorld
{

    public class Counters
    {
        public static int Score = 0;
        public static string Nation;
    }

    static class Program
    {
        static Program()
        {
            Countryflag.Add("NL");
            Countryflag.Add("PT");
            Countryflag.Add("BE");
            Countryflag.Add("DE");
            Countryflag.Add("ES");
            Countryflag.Add("GB");
            Countryflag.Add("PL");
            Countryflag.Add("NP");
            Countryflag.Add("IS");

            Shuffle(Countryflag);

            Counters.Nation = Countryflag[0];
        }

        public static List<string> Countryflag = new List<string>();

        private static Random rng = new Random();

        public static int Index = 0;

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static void UpdateNation() {
            Index++;
            Counters.Nation = Countryflag[Index];
        }

        public static bool Checkanswer(String Input)
        {
            if (Counters.Nation.ToUpper() == Input.ToUpper())
            {
                return true;
            }
            else { return false; }
        }

        public static bool CheckLastNation()
        {
            return Index >= Countryflag.Count - 1;
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}