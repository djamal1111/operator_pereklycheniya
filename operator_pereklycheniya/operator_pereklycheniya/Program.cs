using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_pereklycheniya
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кириллический символ: ");
            char symbol = Console.ReadKey().KeyChar;

            switch (symbol)
            {
                case 'й':
                    Console.WriteLine("\nQ");
                    break;
                case 'ц':
                    Console.WriteLine("\nW");
                    break;
                case 'у':
                    Console.WriteLine("\nE");
                    break;
                case 'к':
                    Console.WriteLine("\nR");
                    break;
                case 'е':
                    Console.WriteLine("\nT");
                    break;
                case 'н':
                    Console.WriteLine("\nY");
                    break;
                case 'г':
                    Console.WriteLine("\nU");
                    break;
                case 'ш':
                    Console.WriteLine("\nI");
                    break;
                case 'щ':
                    Console.WriteLine("\nO");
                    break;
                case 'з':
                    Console.WriteLine("\nP");
                    break;
                case 'х':
                    Console.WriteLine("\n[");
                    break;
                case 'ъ':
                    Console.WriteLine("\n]");
                    break;
                case 'ф':
                    Console.WriteLine("\nA");
                    break;
                case 'ы':
                    Console.WriteLine("\nS");
                    break;
                case 'в':
                    Console.WriteLine("\nD");
                    break;
                case 'а':
                    Console.WriteLine("\nF");
                    break;
                case 'п':
                    Console.WriteLine("\nG");
                    break;
                case 'р':
                    Console.WriteLine("\nH");
                    break;
                case 'о':
                    Console.WriteLine("\nJ");
                    break;
                case 'л':
                    Console.WriteLine("\nK");
                    break;
                case 'д':
                    Console.WriteLine("\nL");
                    break;
                case 'ж':
                    Console.WriteLine("\n;");
                    break;
                case 'э':
                    Console.WriteLine("\n'");
                    break;
                case 'я':
                    Console.WriteLine("\nZ");
                    break;
                case 'ч':
                    Console.WriteLine("\nX");
                    break;
                case 'с':
                    Console.WriteLine("\nC");
                    break;
                case 'м':
                    Console.WriteLine("\nV");
                    break;
                case 'и':
                    Console.WriteLine("\nB");
                    break;
                case 'т':
                    Console.WriteLine("\nN");
                    break;
                case 'ь':
                    Console.WriteLine("\nM");
                    break;
                case 'б':
                    Console.WriteLine("\n,");
                    break;
                case 'ю':
                    Console.WriteLine("\n.");
                    break;
                default:
                    Console.WriteLine("\nКлавиша не найдена");
                    break;
            }

            Console.ReadKey();
        }
    }
}
