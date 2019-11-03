using System;

namespace Task1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string RUalp = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string ENalp = "abcdefghijklmnopqrstuvwxyz";
            char[] En = ENalp.ToCharArray(); //РУ Алфавит в масиве
            char[] Ru = RUalp.ToCharArray(); //EN Алфавит в масиве
            string n = Console.ReadLine();// Ввод строки шифрования
            n=n.ToLower();
            char[] InStr = n.ToCharArray();// Входящая строка в масив
            Console.WriteLine("Задайте смещение.");
            int num=0, i, offset=Convert.ToInt32(Console.ReadLine());//Ввод смещения
            for (i = 0; i < n.Length; i++)
            {
                num = RUalp.IndexOf(InStr[i]);
                if (num < 0)
                {
                    num = ENalp.IndexOf(InStr[i]);
                    if (num + offset > ENalp.Length) num -= ENalp.Length;
                    Console.Write(En[num + offset]);
                }
                else
                {
                    if (num + offset > RUalp.Length) num -= RUalp.Length;
                    Console.Write(Ru[num + offset]);
                }
            }
        }
    }
}
