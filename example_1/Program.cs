using System;
using System.Text.RegularExpressions;

namespace example_1
{
    class Program
    {
        /// <summary>Метод отображения слова "попытка"</summary>
        /// <param name="x">Количество попыток</param>
        /// <returns></returns>
        static string RightTryWord(int x)
        {
            string s = "";
            // Попытка
            if (x % 10 == 1) 
            {
                s += " попытка";
            }
            // Попытки
            else if (x >= 2 && x <= 4)
            {
                s += " попытки";
            }
            // Попыток
            else if ((x == 0) || (x == 5))
            {
                s += " попыток";
            }
            return s;
        }

        /// <summary>Метод проверки на соответствие логина требованиям</summary>
        /// <param name="login">Логин</param>
        /// <returns></returns>
        static bool CheckLogin(string login)
        {
            int length = login.Length;
            if (length >= 2 && length <= 10)
            {
                bool check = true;
                char letter = login[0];
                if (Char.IsDigit(letter))
                    return false;
                for (int i = 1; i < length; i++)
                {
                    letter = login[i];
                    if (!(Char.IsDigit(letter) || IsLatinLetter(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;
            }
            return false;
        }

        /// <summary>Метод проверки на соответствие логина требованиям через регулярные выражения</summary>
        /// <param name="login">Значение логина</param>
        /// <returns></returns>
        static bool CheckLoginReg(string login)
        {
            char letter = login[0];
            if (Char.IsDigit(letter))
                return false;
            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]+${2,10}"))
                return false;
            return true;
        }

        /// <summary>Метод проверяет, что символ - латинская буква</summary>
        /// <param name="letter">Символ</param>
        /// <returns></returns>
        private static bool IsLatinLetter(char letter)
        {
            int num = letter;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            // Домашняя работа №5 пример_1
            // Архиреев Аркадий 
            /* 1.  Создать программу, которая будет проверять корректность ввода логина. 
             * Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
             * при этом цифра не может быть первой:
            а) без использования регулярных выражений;
            б) **с использованием регулярных выражений.*/
            Console.WriteLine("Проверка корректности логина");
            int AmountOfTries = 5;

            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                if (CheckLogin(login) && CheckLoginReg(login))
                {
                    Console.WriteLine("Логин корректен!");
                    break;
                }
                else
                {
                    AmountOfTries--;
                    Console.WriteLine("Неверный ввод логина"
                        + "\nДолжны быть соблюдены следующие условия:"
                        + "\nдлина строки 2 до 10 символов;"
                        + "\nбуквы только латинского алфавита или цифры;"
                        + "\nцифра не может быть первой."
                        + Environment.NewLine + "У Вас осталось " + AmountOfTries + RightTryWord(AmountOfTries));
                }

            } while (AmountOfTries > 0);
        }
    }
}
