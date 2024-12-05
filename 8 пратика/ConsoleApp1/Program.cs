using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {

                case 1:
                    Console.Write("Задние: Порядковый номер его минимальной цифры, считая номера от начала числа;\nРешение: Введите число ");
                    string number = Console.ReadLine(); 

                    int minDigit = 9; 
                    int minIndex = -1; 

                    for (int i = 0; i < number.Length; i++)
                    {
                        int currentDigit = int.Parse(number[i].ToString()); 

                        if (currentDigit < minDigit)
                        {
                            minDigit = currentDigit; 
                            minIndex = i + 1; 
                        }
                    }

                    Console.WriteLine($"Минимальная цифра: {minDigit}");
                    Console.WriteLine($"Порядковый номер минимальной цифры: {minIndex}");

                    break;
                case 2:
                    Console.Write("Задание: Известно число учеников в каждом из 20 классов школы. На сколько численность самого большого (по числу учеников) класса превышает численность самого маленького класса?\nРешение: ");
                    Random random = new Random(); 

                   
                    int[] studentsInClasses = new int[20];
                    for (int i = 0; i < studentsInClasses.Length; i++)
                    {
                        studentsInClasses[i] = random.Next(20, 41);
                    }

             
                    int maxStudents = studentsInClasses.Max(); 
                    int minStudents = studentsInClasses.Min(); 

               
                    int difference = maxStudents - minStudents;

                    Console.WriteLine($"Количество учеников в классах: {string.Join(", ", studentsInClasses)}");
                    Console.WriteLine($"Разница между самым большим и самым маленьким классом: {difference}");

                    break;


                case 3:
                    Console.Write("Задание: Известны максимальные скорости каждой из 20 марок легковых автомобилей. Определить какую максимальную скорость имеет самый быстрый автомобиль.\nРешение: ");
                    Random randomm = new Random(); 
 
                    int[] carSpeeds = new int[20];
                    for (int i = 0; i < carSpeeds.Length; i++)
                    {
                        carSpeeds[i] = randomm.Next(100, 301);
                    }

                 
                    int maxSpeed = carSpeeds.Max(); 

                    Console.WriteLine($"Скорости автомобилей: {string.Join(", ", carSpeeds)}");
                    Console.WriteLine($"Максимальная скорость самого быстрого автомобиля: {maxSpeed}км/ч");


                    break;
                default:
                    Console.WriteLine("Введите правильный номер задачи!"); break;
            }
                    Console.ReadKey();
            }
    }
}
