using System;
using static System.Console;

namespace lesson___2_7_1
{
    internal class Program
    {
        static void Main(string[] args)  // точка входа
        {
            string fName = "Михаил";
            string lName = "Козин";
            string Email = "Vasago85@mail.ru";
            string Sprogramming = "0";
            string Smathematics = "3";
            string Sphysics = "3";



            WriteLine($"Имя: {fName} \nФамилия: {lName} \nпочта: {Email} \nбаллы по программированию: {Sprogramming} \nбаллы по математике: {Smathematics} \nбаллы по физике: {Sphysics}");

            ReadLine();  // задержка закрывается Enter
        }
    }
}