using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
    class Events
    {
        public delegate void EventHandler(string message);
        public event EventHandler Inform;
        public delegate int Operation(int x, int y);
        Operation operation = (x, y) => x + y;

        public void Add(List<string> vs, string _str)
        {

            Inform?.Invoke("Строку додано!");
            vs.Add(_str);
        }
        public void Remove(List<string> vs, int index)
        {
            Inform?.Invoke("Строку видалено!");
            vs.RemoveAt(index);
        }
        public void Sort(List<string> vs)
        {
            Inform?.Invoke("Список відсортовано!");
            vs.Sort();
        }
        public void SymbolNumber(List<string> vs)
        {
            Inform?.Invoke("Кількість літер і цифр розрахована!");
            foreach (String str in vs)
            {
                Console.WriteLine("В строці: " + str);
                int[] s = new int[2];
                char[] ch = str.ToCharArray();
                var count = ch.Where((n) => n >= '0' && n <= '9').Count();
                Console.WriteLine("Кількість цифр в списку: " + count);
                s[0] = count;
                count = 0;
                foreach (var el in str) if (char.IsLetter(el)) count++;
                Console.WriteLine("Кількість літер в списку: " + count);
                s[1] = count;
                if (s[0] > s[1]) Console.WriteLine("Цифр більше ніж літер.");
                if (s[0] < s[1]) Console.WriteLine("Літер більше ніж цифр.");
                if (s[0] == s[1]) Console.WriteLine("Літер і цифер порівну");
                Console.WriteLine("_________________________________________\n");
            }
        }
        public void SumSymbol(List<string> vs)
        {
            Inform?.Invoke("Суму символів розраховано!");
            foreach (String str in vs)
            {
                Console.WriteLine("В строці: " + str);
                int[] s = new int[2];
                char[] ch = str.ToCharArray();
                var count = ch.Where((n) => n >= '0' && n <= '9').Count();

                s[0] = count;
                count = 0;
                foreach (var el in str) if (char.IsLetter(el)) count++;

                s[1] = count;
                Console.WriteLine("Кількість літер і цифр: " + operation(s[0], s[1]));
            }
        }
        public void GetList(List<string> vs)
        {
            Inform?.Invoke("Список строк виведено!");
            int a = 0;
            foreach (String str in vs)
            {
                a++;
                Console.WriteLine(a + ". " + str);
            }
        }            
    }
}

