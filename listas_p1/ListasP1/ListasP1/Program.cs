using System;
using System.Collections.Generic;

namespace ListasP1 {
    internal class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>() { "Alexandre", "Amanda", "João", "Marina", "Miguel" };

            string s1 = list.Find(x => x[0] == 'A');
            string s2 = list.FindLast(x => x[0] == 'A');

            int s3 = list.FindIndex(x => x[0] == 'A');
            int s4 = list.FindLastIndex(x => x[0] == 'A');

            List<string> listaHasA = list.FindAll(x => x.Contains('A') || x.Contains('a'));

            foreach (var item in listaHasA) {
                Console.WriteLine(item);
            }

        }
    }
}
