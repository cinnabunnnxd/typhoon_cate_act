using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace typhoon_categorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string typhoon;
            int intensity;

            Console.WriteLine("Enter Typhoon Name");
            typhoon = Console.ReadLine();

            Console.WriteLine("Enter Wind Intensity");
            intensity = Convert.ToInt32(Console.ReadLine());

            if (intensity < 62)
            {
                Console.WriteLine(typhoon + " is a Tropical Depression (TD) Signal No. 1");
                Console.WriteLine("WIND THREAT: 39-61 km/h (22-33 kt, 10.8-17.1 m/s)");
                Console.WriteLine("WARNING LEAD TIME: 36 hours");
                Console.WriteLine("WAVE HEIGHT: 1.25 - 4.0 meters");
                Console.WriteLine("POTENTIAL IMPACTS: Slight damge to high risk structures and makeshift houses in exposed communities");
                Console.WriteLine("Banana platnts are tilted, trees' twigs are broken & reice crops in flowering stage are significantly damaged.");
            }
            else if (62 <= intensity && intensity <= 88)
            {
                Console.WriteLine(typhoon + " is a Tropical Storm (TS) Sigal No. 2 ");
                Console.WriteLine("WIND THREAT: 62-88 km/h (34-47 kt, 17.2-24.4 m/s");
                Console.WriteLine("WARNING LEAD TIME: 24 hours");
                Console.WriteLine("WAVE HEIGHT: 4.1 - 14.0 meters");
                Console.WriteLine("POTENTIAL IMPACTS: Moderate damage to high risk structures, old roofs, electric posts nd poorly constructed signs are damaged  ");
                Console.WriteLine("Banana, mango and ipil-ipil trees are broken, coconut trees are tilted, rice and coren adversely affected");
            }
            else if (89 <= intensity && intensity <= 117)
            {
                Console.WriteLine(typhoon + " is a Severe Tropical Storm (STS) Signal No. 3  ");
                Console.WriteLine("WIND THREAT: 89-117 km/h (48-63 kt, 24.5-32.6 m/s)");
                Console.WriteLine("WARNING LEAD TIME: 18 hours");
                Console.WriteLine("WAVE HEIGHT: > 14.0 meters");
                Console.WriteLine("POTENTIAL IMPACTS: Heavy damage to high risk structures & house of light materials. Old houses of medium strength materials are unrooted ");
                Console.WriteLine("Almost all bananas and big trees are uprooted. Hybrid coconut trees are downed and trees with heavy foliage blown off.");
            }
            else if (118 <= intensity && intensity <= 184)
            {
                Console.WriteLine(typhoon + " is a Typhoon (TY) Signal No. 4 ");
                Console.WriteLine("WIND THREAT: 118-184 km/h (64-99 kt, 32.7-51.2 m/s)");
                Console.WriteLine("WARNING LEAD TIME: 12 hours");
                Console.WriteLine("WAVE HEIGHT: > 14.0 meters");
                Console.WriteLine("POTENTIAL IMPACTS: Very heavy damage to medium and high-risk structures. Up to 75% of structures in a community are totally destroyed. ");
                Console.WriteLine("Banana plants are totally damaged, large trees are broken, coconut, rice and corn plantations suffer severe losses. ");
            }
            else
            {
                Console.WriteLine(typhoon + " is a Super Typhoon (STY) Signal No. 5 ");
                Console.WriteLine("WIND THREAT: 185km/h or higher (100 kt or higher, 51.3 m/s or higher) ");
                Console.WriteLine("WARNING LEAD TIME: 12 hours");
                Console.WriteLine("WAVE HEIGHT: > 14.0 meters");
                Console.WriteLine("POTENTIAL IMPACTS: Heavy damage to all structures, complete roof, window & door damage to residences and industrial buildings. ");
                Console.WriteLine("Electrical power distribution & communication services severely disrupted.");
                Console.WriteLine("Total damage to banana & coconut plantations. Most tall trees are broken and few plants can survive");
            }
            Console.ReadKey();
        }
    }
}