using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Slot_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;
            

            Console.SetCursorPosition(6, 1);
            Console.Write("_____________");
            Console.SetCursorPosition(6, 2);
            Console.Write("|");
            Console.SetCursorPosition(6, 3);
            Console.Write("|");
            Console.SetCursorPosition(6, 4);
            Console.Write("|");
            Console.SetCursorPosition(7, 4);
            Console.Write("____________");
            Console.SetCursorPosition(18, 2);
            Console.Write("|");
            Console.SetCursorPosition(18, 3);
            Console.Write("|");
            Console.SetCursorPosition(18, 4);
            Console.Write("|");
            Console.SetCursorPosition(10, 2);
            Console.Write("|");
            Console.SetCursorPosition(10, 3);
            Console.Write("|");
            Console.SetCursorPosition(10, 4);
            Console.Write("|");
            Console.SetCursorPosition(14, 2);
            Console.Write("|");
            Console.SetCursorPosition(14, 3);
            Console.Write("|");
            Console.SetCursorPosition(14, 4);
            Console.Write("|");
            Console.SetCursorPosition(19, 3);
            Console.Write("___");
            Console.SetCursorPosition(22, 3);
            Console.Write("|");
            Console.SetCursorPosition(22, 2);
            Console.Write("o");


            Console.SetCursorPosition(8, 3);
            a = Convert.ToChar(Console.ReadLine());
            Console.SetCursorPosition(8, 3);
            Console.Write(a);

            while ((a != 'x' && a != 'X' && a != 'y' && a != 'Y' && a != 'z' && a != 'Z' && a != 'J'))
            {
                
                Console.SetCursorPosition(8, 3);
                Console.Write(' ');
                Console.SetCursorPosition(0, 0);
                Console.Write("You can only enter X,Y,Z,x,y,z and Joker(J) values.");
                Console.SetCursorPosition(8, 3);
                a = Convert.ToChar(Console.ReadLine());
                Console.SetCursorPosition(8, 3);
                Console.Write(a);
            }
            

            Console.SetCursorPosition(0, 0);
            Console.Write("                                                                    ");

            Console.SetCursorPosition(12, 3);
            b = Convert.ToChar(Console.ReadLine());
            Console.SetCursorPosition(12, 3);
            Console.Write(b);

            while ((b != 'x' && b != 'X' && b != 'y' && b != 'Y' && b != 'z' && b != 'Z' && b != 'J')) 
            {
                Console.SetCursorPosition(12, 3);
                Console.Write(' ');
                Console.SetCursorPosition(0, 0);
                Console.Write("You can only enter X,Y,Z,x,y,z and Joker(J) values.");
                Console.SetCursorPosition(12, 3);
                b = Convert.ToChar(Console.ReadLine());
                Console.SetCursorPosition(12, 3);
                Console.Write(b);
            }
            
            Console.SetCursorPosition(0, 0);
            Console.Write("                                                                    ");

            Console.SetCursorPosition(16, 3);
            c = Convert.ToChar(Console.ReadLine());
            Console.SetCursorPosition(16, 3);
            Console.Write(c);

            while ((c != 'x' && c != 'X' && c != 'y' && c != 'Y' && c != 'z' && c != 'Z' && c != 'J'))
            {
                Console.SetCursorPosition(16, 3);
                Console.Write(' ');
                Console.SetCursorPosition(0, 0);
                Console.Write("You can only enter X,Y,Z,x,y,z and Joker(J) values.");
                Console.SetCursorPosition(16, 3);
                c = Convert.ToChar(Console.ReadLine());
                Console.SetCursorPosition(16, 3);
                Console.Write(c);
            }
            
            Console.SetCursorPosition(0, 0);
            Console.Write("                                                                    ");

            if ((a == 'X' && b == 'X' && c == 'X') || (a == 'Y' && b == 'Y' && c == 'Y') || (a == 'Z' && b == 'Z' && c == 'Z')
                || (a == 'J' && b == 'J' && c == 'J') || (a == 'J' && b == 'J' && c == 'X') || (a == 'J' && b == 'J' && c == 'Y')
                || (a == 'J' && b == 'J' && c == 'Z') || (a == 'J' && b == 'X' && c == 'J') || (a == 'J' && b == 'Y' && c == 'J')
                || (a == 'J' && b == 'Z' && c == 'J') || (a == 'X' && b == 'J' && c == 'J') || (a == 'Y' && b == 'J' && c == 'J')
                || (a == 'Z' && b == 'J' && c == 'J') || (a == 'J' && b == 'X' && c == 'X') || (a == 'J' && b == 'Y' && c == 'Y')
                || (a == 'J' && b == 'Z' && c == 'Z') || (a == 'X' && b == 'X' && c == 'J') || (a == 'Y' && b == 'Y' && c == 'J')
                || (a == 'Z' && b == 'Z' && c == 'J') || (a == 'X' && b == 'J' && c == 'X') || (a == 'Y' && b == 'J' && c == 'Y')
                || (a == 'Z' && b == 'J' && c == 'Z'))
            {
                Console.SetCursorPosition(6, 6);
                Console.WriteLine("You earned $30");               
            }
            else if ((a == 'x' && b == 'x' && c == 'x') || (a == 'y' && b == 'y' && c == 'y') || (a == 'z' && b == 'z' && c == 'z')
                || (a == 'J' && b == 'J' && c == 'x') || (a == 'J' && b == 'J' && c == 'y') || (a == 'J' && b == 'J' && c == 'z')
                || (a == 'J' && b == 'x' && c == 'J') || (a == 'J' && b == 'y' && c == 'J') || (a == 'J' && b == 'z' && c == 'J')
                || (a == 'x' && b == 'J' && c == 'J') || (a == 'y' && b == 'J' && c == 'J') || (a == 'z' && b == 'J' && c == 'J')
                || (a == 'J' && b == 'x' && c == 'x') || (a == 'J' && b == 'y' && c == 'y') || (a == 'J' && b == 'z' && c == 'z')
                || (a == 'x' && b == 'x' && c == 'J') || (a == 'y' && b == 'y' && c == 'J') || (a == 'z' && b == 'z' && c == 'J')
                || (a == 'x' && b == 'J' && c == 'x') || (a == 'y' && b == 'J' && c == 'y') || (a == 'z' && b == 'J' && c == 'z'))
            {
                Console.SetCursorPosition(6, 6);
                Console.WriteLine("You earned $28");              
            }
            else if ((a == 'X' && b == 'x' && c == 'x') || (a == 'x' && b == 'X' && c == 'x') || (a == 'x' && b == 'x' && c == 'X') ||
                (a == 'Y' && b =='y' &&  c == 'y') || (a == 'y' && b == 'Y' && c == 'y') || (a == 'y' && b == 'y' && c == 'Y')
                || (a == 'Z' && b == 'z' && c == 'z') || (a == 'z' && b == 'Z' && c == 'z') || (a == 'z' && b == 'z' && c == 'Z') ||
                (a == 'X' && b == 'X' && c == 'x') || (a == 'x' && b == 'X' && c == 'X') || (a == 'X' && b == 'x' && c == 'X')
                || (a == 'Y' && b == 'Y' && c == 'y') || (a == 'y' && b == 'Y' && c == 'Y') || (a == 'Y' && b == 'y' && c == 'Y') ||
                (a == 'Z' && b == 'Z' && c == 'z') || (a == 'z' && b == 'Z' && c == 'Z') || (a == 'Z' && b == 'z' && c == 'Z')
                || (a == 'J' && b == 'X' && c == 'x') || (a == 'J' && b == 'x' && c == 'X') || (a == 'J' && b == 'Y' && c == 'y')
                || (a == 'J' && b == 'y' && c == 'Y') || (a == 'J' && b == 'Z' && c == 'z') || (a == 'J' && b == 'z' && c == 'Z')
                || (a == 'X' && b == 'x' && c == 'J') || (a == 'x' && b == 'X' && c == 'J') || (a == 'Y' && b == 'y' && c == 'J')
                || (a == 'y' && b == 'Y' && c == 'J') || (a == 'Z' && b == 'z' && c == 'J') || (a == 'z' && b == 'Z' && c == 'J')
                || (a == 'X' && b == 'J' && c == 'x') || (a == 'x' && b == 'J' && c == 'X') || (a == 'Y' && b == 'J' && c == 'y')
                || (a == 'y' && b == 'J' && c == 'Y') || (a == 'Z' && b == 'J' && c == 'z') || (a == 'z' && b == 'J' && c == 'Z'))
            {
                Console.SetCursorPosition(6, 6);
                Console.WriteLine("You earned $26");
            }
            else if ((a == 'X' && b == 'Y' && c == 'Z') || (a == 'Y' && b == 'Z' && c == 'X') || (a == 'Z' && b == 'X' && c == 'Y') ||
                (a == 'Z' && b == 'Y' && c == 'X') || (a == 'Y' && b == 'X' && c == 'Z') || (a == 'X' && b == 'Z' && c == 'Y')
                || (a == 'J' && b == 'X' && c == 'Y') || (a == 'J' && b == 'Y' && c == 'X') || (a == 'J' && b == 'Y' && c == 'Z')
                || (a == 'J' && b == 'Z' && c == 'Y') || (a == 'J' && b == 'X' && c == 'Z') || (a == 'J' && b == 'Z' && c == 'X')
                || (a == 'X' && b == 'Y' && c == 'J') || (a == 'Y' && b == 'X' && c == 'J') || (a == 'Y' && b == 'Z' && c == 'J')
                || (a == 'Z' && b == 'Y' && c == 'J') || (a == 'X' && b == 'Z' && c == 'J') || (a == 'Z' && b == 'X' && c == 'J')
                || (a == 'X' && b == 'J' && c == 'Y') || (a == 'Y' && b == 'J' && c == 'X') || (a == 'Y' && b == 'J' && c == 'Z')
                || (a == 'Z' && b == 'J' && c == 'Y') || (a == 'X' && b == 'J' && c == 'Z') || (a == 'Z' && b == 'J' && c == 'X'))
            {
                Console.SetCursorPosition(6, 6);
                Console.WriteLine("You earned $24");
            }
            else if ((a == 'x' && b == 'y' && c == 'z') || (a == 'y' && b == 'z' && c == 'x') || (a == 'z' && b == 'x' && c == 'y')
                || (a == 'z' && b == 'y' && c == 'x') || (a == 'y' && b == 'x' && c == 'z') || (a == 'x' && b == 'z' && c == 'y')
                || (a == 'J' && b == 'x' && c == 'y') || (a == 'J' && b == 'y' && c == 'x') || (a == 'J' && b == 'y' && c == 'z')
                || (a == 'J' && b == 'z' && c == 'y') || (a == 'J' && b == 'x' && c == 'z') || (a == 'J' && b == 'z' && c == 'x')
                || (a == 'x' && b == 'y' && c == 'J') || (a == 'y' && b == 'x' && c == 'J') || (a == 'y' && b == 'z' && c == 'J')
                || (a == 'z' && b == 'y' && c == 'J') || (a == 'x' && b == 'z' && c == 'J') || (a == 'z' && b == 'x' && c == 'J')
                || (a == 'x' && b == 'J' && c == 'y') || (a == 'y' && b == 'J' && c == 'x') || (a == 'y' && b == 'J' && c == 'z')
                || (a == 'z' && b == 'J' && c == 'y') || (a == 'x' && b == 'J' && c == 'z') || (a == 'z' && b == 'J' && c == 'x'))
            {
                Console.SetCursorPosition(6, 6);
                Console.WriteLine("You earned $22");
            }
            else if ((a == 'X' && b == 'y' && c == 'z') || (a == 'x' && b == 'y' && c == 'Z') || (a == 'x' && b == 'Y' && c == 'z')
                || (a == 'X' && b == 'Y' && c == 'z') || (a == 'x' && b == 'Y' && c == 'Z') || (a == 'X' && b == 'y' && c == 'Z')
                || (a == 'Y' && b == 'z' && c == 'x') || (a == 'y' && b == 'z' && c == 'X') || (a == 'y' && b == 'Z' && c == 'x')
                || (a == 'Y' && b == 'Z' && c == 'x') || (a == 'y' && b == 'Z' && c == 'X') || (a == 'Y' && b == 'z' && c == 'X')
                || (a == 'Z' && b == 'x' && c == 'y') || (a == 'z' && b == 'x' && c == 'Y') || (a == 'z' && b == 'X' && c == 'y')
                || (a == 'Z' && b == 'X' && c == 'y') || (a == 'z' && b == 'X' && c == 'Y') || (a == 'Z' && b == 'x' && c == 'Y')
                || (a == 'Z' && b == 'y' && c == 'x') || (a == 'z' && b == 'y' && c == 'X') || (a == 'z' && b == 'Y' && c == 'x')
                || (a == 'Z' && b == 'Y' && c == 'x') || (a == 'z' && b == 'Y' && c == 'X') || (a == 'Z' && b == 'y' && c == 'X')
                || (a == 'Y' && b == 'x' && c == 'z') || (a == 'y' && b == 'x' && c == 'Z') || (a == 'y' && b == 'X' && c == 'z')
                || (a == 'Y' && b == 'X' && c == 'z') || (a == 'y' && b == 'X' && c == 'Z') || (a == 'Y' && b == 'x' && c == 'Z')
                || (a == 'X' && b == 'z' && c == 'y') || (a == 'x' && b == 'z' && c == 'Y') || (a == 'x' && b == 'Z' && c == 'y')
                || (a == 'X' && b == 'Z' && c == 'y') || (a == 'x' && b == 'Z' && c == 'Y') || (a == 'X' && b == 'z' && c == 'Y')
                || (a == 'J' && b == 'X' && c == 'y') || (a == 'J' && b == 'x' && c == 'Y') || (a == 'J' && b == 'Y' && c == 'x')
                || (a == 'J' && b == 'y' && c == 'X') || (a == 'X' && b == 'y' && c == 'J') || (a == 'x' && b == 'Y' && c == 'J')
                || (a == 'Y' && b == 'x' && c == 'J') || (a == 'y' && b == 'X' && c == 'J') || (a == 'X' && b == 'J' && c == 'y')
                || (a == 'x' && b == 'J' && c == 'Y') || (a == 'Y' && b == 'J' && c == 'x') || (a == 'y' && b == 'J' && c == 'X')
                || (a == 'J' && b == 'Y' && c == 'z') || (a == 'J' && b == 'y' && c == 'Z') || (a == 'J' && b == 'Z' && c == 'y')
                || (a == 'J' && b == 'z' && c == 'Y') || (a == 'Y' && b == 'z' && c == 'J') || (a == 'y' && b == 'Z' && c == 'J')
                || (a == 'Z' && b == 'y' && c == 'J') || (a == 'z' && b == 'Y' && c == 'J') || (a == 'Y' && b == 'J' && c == 'z')
                || (a == 'y' && b == 'J' && c == 'Z') || (a == 'Z' && b == 'J' && c == 'y') || (a == 'z' && b == 'J' && c == 'Y')
                || (a == 'J' && b == 'X' && c == 'z') || (a == 'J' && b == 'x' && c == 'Z') || (a == 'J' && b == 'Z' && c == 'x')
                || (a == 'J' && b == 'z' && c == 'X') || (a == 'X' && b == 'z' && c == 'J') || (a == 'x' && b == 'Z' && c == 'J')
                || (a == 'Z' && b == 'x' && c == 'J') || (a == 'z' && b == 'X' && c == 'J') || (a == 'X' && b == 'J' && c == 'z')
                || (a == 'x' && b == 'J' && c == 'Z') || (a == 'Z' && b == 'J' && c == 'x') || (a == 'z' && b == 'J' && c == 'X'))
            {
                Console.SetCursorPosition(6, 6);
                Console.WriteLine("You earned $20");
            }
            else if ((a == 'X' && b == 'Y' && c == 'X') || (a == 'X' && b == 'Y' && c == 'Y') || (a == 'X' && b == 'X' && c == 'Y')
                || (a == 'Y' && b == 'X' && c == 'Y') || (a == 'Y' && b == 'Y' && c == 'X') || (a == 'Y' && b == 'X' && c == 'X')
                || (a == 'X' && b == 'Z' && c == 'X') || (a == 'X' && b == 'Z' && c == 'Z') || (a == 'X' && b == 'X' && c == 'Z')
                || (a == 'Z' && b == 'X' && c == 'Z') || (a == 'Z' && b == 'Z' && c == 'X') || (a == 'Z' && b == 'X' && c == 'X')
                || (a == 'Y' && b == 'Z' && c == 'Y') || (a == 'Y' && b == 'Z' && c == 'Z') || (a == 'Y' && b == 'Y' && c == 'Z')
                || (a == 'Z' && b == 'Y' && c == 'Z') || (a == 'Z' && b == 'Z' && c == 'Y') || (a == 'Z' && b == 'Y' && c == 'Y'))
            {
                Console.SetCursorPosition(6, 6);
                Console.WriteLine("You earned $18");
            }
            else if ((a == 'x' && b == 'y' && c == 'x') || (a == 'x' && b == 'y' && c == 'y') || (a == 'x' && b == 'x' && c == 'y')
                || (a == 'y' && b == 'x' && c == 'y') || (a == 'y' && b == 'y' && c == 'x') || (a == 'y' && b == 'x' && c == 'x')
                || (a == 'x' && b == 'z' && c == 'x') || (a == 'x' && b == 'z' && c == 'z') || (a == 'x' && b == 'x' && c == 'z')
                || (a == 'z' && b == 'x' && c == 'z') || (a == 'z' && b == 'z' && c == 'x') || (a == 'z' && b == 'x' && c == 'x')
                || (a == 'y' && b == 'z' && c == 'y') || (a == 'y' && b == 'z' && c == 'z') || (a == 'y' && b == 'y' && c == 'z')
                || (a == 'z' && b == 'y' && c == 'z') || (a == 'z' && b == 'z' && c == 'y') || (a == 'z' && b == 'y' && c == 'y'))
            {
                Console.SetCursorPosition(6, 6);
                Console.WriteLine("You earned $16");
            }

            
                else
            {
                Console.SetCursorPosition(6, 6);
                Console.WriteLine("You earned $0");
            }
            

    

            Console.ReadLine();
        }
    }
}
