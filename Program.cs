using System;
using static System.Console;

namespace assessment
{
    class Program
    {
        public static void Show(int[] array) // Функция вывода массива с оценками
        {
            for (int i = 0; i < 10; i++)
            {
                WriteLine($"{i+1} оценка: {array[i]}");
            }
        }

        public static void Change(int[] array) // Функция, которая меняет оценку
        {
            Write("Введите номер оценки, которую нужно изменить: "); 
            int pos = Convert.ToInt32(ReadLine());
            Write("Введите саму оценку: ");
            array[pos-1] = Convert.ToInt32(ReadLine());
        }

        public static void Scholarship(int[] array) // Функция, которая возвращает ответ о наличии степендии
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += array[i];
            }
            double average = total / 10;
            if(average>=10.7)
            {
                WriteLine("You have scholarship!");
            }
            else
            {
                WriteLine("Sorry! You have to study better!");
            }
        }

        static void Main(string[] args) // Основная программа
        {
            int[] assessments = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Write($"Введите {i + 1} оценку: "); assessments[i] = Convert.ToInt32(ReadLine());
            }

            int flag = 0;
            do
            {
                WriteLine("Если вы хотите вывести оценки на экран введите 1");
                WriteLine("Если вы хотите заменить оценку введите 2");
                WriteLine("Если вы хотите узнать о налачии степендии введите 3");
                int punkt = Convert.ToInt32(ReadLine());
                switch (punkt)
                {
                    case 1:
                        Show(assessments);
                        break;
                    case 2:
                        Change(assessments);
                        break;
                    case 3:
                        Scholarship(assessments);
                        break;
                }
                Write("Если вы хотите продолжить работу с оценками нажмите 1, если нет то 0: "); flag = Convert.ToInt32(ReadLine());
            } while (flag == 1);
        }
    }
}
