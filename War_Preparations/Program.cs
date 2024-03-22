using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using War_Preparations.Types.Records;

namespace War_Preparations
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Declarations
            Sword orginSword = new Sword(Types.Material.iron, Types.Gemstones.None, 4);
            Sword betterSword = orginSword with { swrdGem = Types.Gemstones.emerald, crsGaurdWidth = 3.5f };
            Sword okSword = betterSword with { swrdMat = Types.Material.steel, swrdGem = Types.Gemstones.diamond };

                //create array to easily loop through and display results
            Sword[] swords = new Sword[] { orginSword, betterSword, okSword };
            
                //OUPUT
            
            //Console.WriteLine(okSword.ToString());

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(swords[i]);

            }
        }
    }
}
