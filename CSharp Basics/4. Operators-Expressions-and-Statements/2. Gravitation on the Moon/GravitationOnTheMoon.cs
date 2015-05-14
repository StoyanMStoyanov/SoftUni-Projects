using System;

namespace _2.Gravitation_on_the_Moon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Enter float value for earth's weight: ");
            float earthWeight = float.Parse(Console.ReadLine());
            Console.WriteLine("The Moon's weight is: {0:F45}.", earthWeight * 0.17);
        }
    }
}
