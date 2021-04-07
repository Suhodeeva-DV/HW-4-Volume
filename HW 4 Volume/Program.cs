using System;
using System.Collections.Generic;

namespace HW_4_Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            double valumeBox = ValumeBox(box);
            Console.WriteLine("Объём куба Box: " + valumeBox);

            double valumeAdd = 0;

            List<Shape> elementsInBox = new List<Shape>();

            while (valumeAdd < valumeBox)
            {
                Shape newModel = FillingBoxModel();

                if (box.Add((valumeBox-valumeAdd), newModel.Valume()))
                {
                    valumeAdd += newModel.Valume();
                    Console.WriteLine("В Box добавлен новый элемент с объёмом: " + newModel.Valume());
                    Console.WriteLine("Свободный объем в Box: " + (valumeBox - valumeAdd));
                    elementsInBox.Add(newModel);
                }
                else
                {
                    Console.WriteLine("Данное тело не помещается в Box.");
                    break;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Содержимое Box: ");

            foreach (Shape k in elementsInBox)
            {
                Console.WriteLine($"{k.Name()}, V = {k.Valume()}");
            }

        }

        public static double ValumeBox (Box model)
        {
            int h = 10;
            model.Height = h;
            double valume = model.Valume();
            return valume;
        }

        static Shape FillingBoxModel()
        {
            Console.WriteLine($"Какое тело добавить в Box?\n{(int)AddModels.Culynder} - цилиндр, {(int)AddModels.Pyramid} - пирамида, {(int)AddModels.Ball} - шар");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int userInput))
            {
                if (AddModels.IsDefined(typeof(AddModels), userInput))
                {
                    AddModels addModel = (AddModels)userInput;
                    Shape newModel = ValumeModel(addModel);
                    return newModel;
                    //double valumeAddModel = newModel.Valume();
                    //Console.WriteLine(valumeAddModel);
                }
                else
                {
                    Console.WriteLine("Вы указали неизвестное тело =(");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Вы указали неверное число =(");
                Environment.Exit(0);
            }

            return (null);
        }

        static Shape ValumeModel(AddModels nameModel)
        {
            switch (nameModel)
            {
                case AddModels.Culynder:
                    {
                        Cylinder model = new Cylinder();
                        Console.WriteLine("Введите, пожалуйста, высоту цилиндра и радиус основания цилиндра:");
                        Console.Write("H = ");
                        if (int.TryParse(Console.ReadLine(), out int h))
                        {
                            model.Height = h;
                        }
                        else
                        {
                            Console.WriteLine("Вы указали неверное значение =(");
                            Environment.Exit(0);
                        }
                        Console.Write("R = ");
                        if (int.TryParse(Console.ReadLine(), out int r))
                        {
                            model.Radius = r;
                        }
                        else
                        {
                            Console.WriteLine("Вы указали неверное значение =(");
                            Environment.Exit(0);
                        }

                        return model;
                    }
                case AddModels.Pyramid:
                    {
                        Pyramid model = new Pyramid();
                        Console.WriteLine("Введите, пожалуйста, площадь основания пирамиды и высоту:");
                        Console.Write("S = ");
                        if (int.TryParse(Console.ReadLine(), out int s))
                        {
                            model.Area = s;
                        }
                        else
                        {
                            Console.WriteLine("Вы указали неверное значение =(");
                            Environment.Exit(0);
                        }
                        Console.Write("H = ");
                        if (int.TryParse(Console.ReadLine(), out int h))
                        {
                            model.Height = h;
                        }
                        else
                        {
                            Console.WriteLine("Вы указали неверное значение =(");
                            Environment.Exit(0);
                        }

                        return model;
                    }
                case AddModels.Ball:
                    {
                        Ball model = new Ball();
                        Console.WriteLine("Введите, пожалуйста, радиус шара:");
                        Console.Write("R = ");
                        if (int.TryParse(Console.ReadLine(), out int r))
                        {
                            model.Radius = r;
                        }
                        else
                        {
                            Console.WriteLine("Вы указали неверное значение =(");
                            Environment.Exit(0);
                        }

                        return model;
                    }

            }
            return (null);
        }
    }
}
