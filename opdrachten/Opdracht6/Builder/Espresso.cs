using System;

namespace Builder
{
    public class Espresso: Koffie
    {
        public override void Test() {
            Console.WriteLine("Espresso klaar!");
        }
    }
}