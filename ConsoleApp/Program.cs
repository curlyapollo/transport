using System.Text;
using EKRLib;
using System;
using System.IO;

namespace ConsoleApp
{
    /// <summary>
    /// Класс консольного приложения.
    /// </summary>
    public class Program
    {
        private static readonly Random RandomOperator = new();

        private static Transport CreatingPower(string model)
        {
            switch (RandomOperator.Next(2))
            {
                case 0:
                    return new Car(model, (uint) RandomOperator.Next(10, 100));
                default:
                    return new MotorBoat(model, (uint) RandomOperator.Next(10, 100));
            }
        }

        private static void Cleaning()
        {
            try
            {
                if (File.Exists("../../../MotorBoats.txt"))
                {
                    File.WriteAllText("../../../MotorBoats.txt", string.Empty);
                }

                if (File.Exists("../../../Cars.txt"))
                {
                    File.WriteAllText("../../../Cars.txt", string.Empty);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void AddingInformation(Transport transport)
        {
            try
            {
                if (transport is Car)
                {
                    File.AppendAllText("../../../Cars.txt", transport.ToString() + '\n', Encoding.Unicode);
                }
                else
                {
                    File.AppendAllText("../../../MotorBoats.txt", transport.ToString() + '\n', Encoding.Unicode);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Main()
        {
            do
            {
                Cleaning();
                string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                Transport[] transports = new Transport[RandomOperator.Next(6, 10)];
                for (int i = 0; i < transports.Length; i++)
                {
                    string model = string.Empty;
                    for (int j = 0; j < 5; j++)
                    {
                        model += symbols[RandomOperator.Next(symbols.Length)];
                    }

                    try
                    {
                        transports[i] = CreatingPower(model);
                        Console.WriteLine(transports[i].StartEngine());
                    }
                    catch (TransportException transportException)
                    {
                        Console.WriteLine(transportException.Message);
                        i--;
                        continue;
                    }

                    AddingInformation(transports[i]);
                }

                Console.WriteLine("Хотите повторить? Ответьте 'да', если хотите.");
            } while (Console.ReadLine() == "да");
        }
    }
}
