using System;

namespace CSharp.HardToReadReverse
{
    public class HardToReadReverse
    {
        // static void Main(string[] args)
        public static void Reverse()
        {
            int[] m1 = { 082,101,118,101,114,115,105,110,103,032,039,115,117,112,101,114,099,097,108,105,102,114,097,103,105,108,105,115,116,105,099,101,120,112,105,097,108,105,100,111,099,105,111,117,115,039,046,046,046,032 }; int[] m2 = { 115, 117, 112, 101, 114, 099, 097, 108, 105, 102, 114, 097, 103, 105, 108, 105, 115, 116, 105, 099, 101, 120, 112, 105, 097, 108, 105, 100, 111, 099, 105, 111, 117, 115 }; for (var i = 0; i < m1.Length; ++i) { Console.Write((char)m1[i]); } Array.Reverse(m2); for (var i = 0; i < m2.Length; ++i) { Console.Write((char)m2[i]); }
        }
    }
}
