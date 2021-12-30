using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LabWork4
{
    class Program
    {
        delegate void DelList();
        static void Main(string[] args)
        {
            ListFillingString list_ = new ListFillingString();
            Events @event = new Events();

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            DelList delegateAddStr = delegate ()
            {
                string string_;
                Console.WriteLine("Введіть строку символів яку хочете додати:");
                string_ = Console.ReadLine();
                @event.Add(list_.list, string_);

            };
            DelList delegateDeleteStr = delegate ()
            {
                int int_;
                Console.WriteLine("Виберіть строку символів яку хочете видалити:");
                @event.GetList(list_.list);
                while (true)
                {
                    try
                    {
                        int_ = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Ви ввели неправильні дані. Спробуйте ще раз");
                    }
                }
                @event.Remove(list_.list, int_);
            };
            DelList delegateCalculateIsMore = delegate ()
            {
                @event.SymbolNumber(list_.list);
            };
            DelList delegateSortStr = delegate ()
            {
                @event.Sort(list_.list);
                @event.GetList(list_.list);
            };
            DelList delegateOutputStr = delegate ()
            {
                @event.GetList(list_.list);
            };
            DelList deegateValueLetterAndSymbols = delegate ()
            {
                @event.SumSymbol(list_.list);
            };

            
            for (int i = 0; i < 1;)
            {
                Console.WriteLine("Оберіть дію:");
                Console.WriteLine("1. Вивести список строк.");
                Console.WriteLine("2. Видалити строку.");
                Console.WriteLine("3. Сортувати список строк.");
                Console.WriteLine("4. Визначити чого більше в строках літер чи цифр.");
                Console.WriteLine("5. Вивести кількість літер і цифр з списоку строк. ");
                Console.WriteLine("6. Додати строку.");
                Console.WriteLine("7. Вийти."); @event.Inform += DisplayMessage;
                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            {
                                Console.Clear();
                                delegateOutputStr();
                                Console.WriteLine();
                                break;
                            }

                        case 2:
                            {
                                Console.Clear();
                                delegateDeleteStr();
                                Console.WriteLine();
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                delegateSortStr();
                                Console.WriteLine();
                                break;
                            }
                        case 4:
                            {
                                Console.Clear();
                                delegateCalculateIsMore();
                                Console.WriteLine();
                                break;
                            }

                        case 5:
                            {
                                Console.Clear();

                                deegateValueLetterAndSymbols();

                                Console.WriteLine();
                                break;
                            }
                        case 6:
                            {
                                Console.Clear();
                                delegateAddStr();
                                Console.WriteLine();
                                break;
                            }
                        case 7:
                            {
                                i++;
                                break;
                            }
                        default:
                            Console.WriteLine("Неправильно введені дані. Введіть цифру від 1 до 7");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ви ввели нечислові дані. Введіть цифру від 1 до 7");
                }
            }
            @event.Inform -= DisplayMessage;
        }


        private static void DisplayMessage(String message)
        {
            Console.WriteLine(message);
        }

    }
}

