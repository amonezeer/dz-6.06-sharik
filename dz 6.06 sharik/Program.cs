using System;

namespace ResumePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResume();
        }

        static void PrintResume()
        {
            string name = "Юсыпив Александр";
            string title = "Студент-программист";
            string contactInfo = "Email: yusypiv07@gmail.com\nТелефон: +380 98 059 32 91";
            string summary = "Талантливый студент с сильным интересом к программированию и разработке программного обеспечения";
            string skill1 = "C++";
            string skill2 = "ООП";
            string skill3 = "UML диаграммы";
            string skill4 = "Паттерны проектирования";
            string skill5 = "Python(база)";
            string skill6 = "Робототехника";
            string skill7 = "Основы информационных технологий";
            string education1 = "Школа: Усатовский Лицей\nПериод: Сентябрь 2013 - Май 2024";
            string education2 = "\nКурсы: Академия ITStep\nПериод: Ноябрь 2022 - Настоящее время";

            Console.WriteLine("|---------------------------------------------------|");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                       Резюме");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("|---------------------------------------------------|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Имя: {name}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Должность: {title}");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Контактная информация:");
            Console.ResetColor();
            Console.WriteLine(contactInfo);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Краткое описание:");
            Console.ResetColor();
            Console.WriteLine(summary);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Навыки:");
            Console.ResetColor();
            Console.WriteLine($"- {skill1}");
            Console.WriteLine($"- {skill2}");
            Console.WriteLine($"- {skill3}");
            Console.WriteLine($"- {skill4}");
            Console.WriteLine($"- {skill5}");
            Console.WriteLine($"- {skill6}");
            Console.WriteLine($"- {skill7}");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Образование:");
            Console.ResetColor();
            Console.WriteLine(education1);
            Console.WriteLine(education2);
        }
    }
}
