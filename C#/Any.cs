using System;

namespace CSharp.Any
{
    public class AnyReverse
    {
        // static void Main(string[] args)
        public static void Reverse()
        {
            Console.Write("Reversing 'supercalifragilisticexpialidocious'... ");
            string ReverseMe = "supercalifragilisticexpialidocious";

            var r = ReverseMe.ToCharArray();
            Array.Reverse(r);
            ReverseMe = new String(r);

            Console.WriteLine(ReverseMe);
        }
    }
}
