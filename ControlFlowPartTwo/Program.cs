using System;

namespace ControlFlowPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada PIN-koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234
            //programm kuvas konsoolis "Tere tulemast"
            //kui sisestatud PIN-kood on vale ,programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti"

            {
                Console.WriteLine("Palun, sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Vale PIN. Proovi uuesti.");
                }
                else
                {
                    Console.WriteLine("Tere tulemast");
                }
            }
        }
    }
}
