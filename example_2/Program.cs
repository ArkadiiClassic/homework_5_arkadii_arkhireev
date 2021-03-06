using ClassMessage;
using System;

namespace example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашняя работа №5 пример_2
            // Архиреев Аркадий 
            /* 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            а) Вывести только те слова сообщения, которые содержат не более n букв.
            б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            в) Найти самое длинное слово сообщения.
            г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            д) ***Создать метод, который производит частотный анализ текста.
                В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает
                сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.*/
            Console.WriteLine("Статический класс Message, содержащий следующие статические методы для обработки текста");

            Console.WriteLine("\nТекст: \n" + Message.text);

            Console.WriteLine("\nВыведем слова текста, которые содержат не более 5 букв:");
            Message.GetWordsByLength(5);

            Console.WriteLine();
            Console.Write("\nУдалим из текста слова, заканчивающиеся на 'm': ");
            Message.DeleteWordByEndChar('m');

            Console.WriteLine();
            Console.WriteLine("\nСамое длинное слово в тексте: " + Message.FindMaxLengthWord());


            Console.WriteLine("\nСформированная строка StringBuilder из самых длинных слов сообщения: \n" + Message.GetLongWordsString());

            Console.WriteLine("\nПроизведём частотный анализ текста: ");
            string[] arr = { "in", "eu", "esse"};
            Message.FrequencyAnalysis(arr, Message.text);

            Console.ReadKey();
        }
    }
}
