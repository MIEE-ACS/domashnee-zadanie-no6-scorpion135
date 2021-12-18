using System;

namespace Shapes
{
    abstract class Figure
    {
        public abstract string Area();
        public abstract string Perimeter();
        public abstract string TriangleType();

        public void ShowInfo()
        {
            Console.WriteLine(
                $"Название фигуры: {TriangleType()}\n" +
                $"Площадь: {Area()}\n" +
                $"Периметр: {Perimeter()}"
                );
            Console.WriteLine();
        }
    }

    class IsoclesesTriangle : Figure
    {
        double sideA, sideB, alpha;   // Стороны  и угол равнобедренного треугольника

        // Конструктор
        public IsoclesesTriangle(double a, double b, double alpha)
        {
            SideA = a;
            SideB = b;
            Alpha = alpha;
        }

        // Свойство, проверяем значение на отрицательность.
        // Если значение отрицательное меняем его на аналогичное положительное.
        public double SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? -value : value; }
        }

        public double SideB
        {
            get { return sideB; }
            set { sideB = value < 0 ? -value : value; }
        }

        public double Alpha
        {
            get { return alpha; }
            set { alpha = value < 0 ? -value : value; }
        }





        // Метод для вычисления площади равнобедренного треугольника
        public override string Area()
        {

            return Math.Round((0.5 * SideA * SideA * Math.Sin(Alpha*Math.PI/180)), 2).ToString();
        }

        // Метод для вычисления периметра равнобедренного треугольника
        public override string Perimeter()
        {
            return (2 * SideA + SideB).ToString();
        }

        // Метод возвращающий наименование фигуры
        public override string TriangleType()
        {
            return " Равнобедренный треугольник";
        }
    }

    class EquilateralTriangle : Figure
    {
        double sideA;  // Сторона равностороннего треугольника

        // Конструктор
        public EquilateralTriangle(double a)
        {
            SideA = a;

        }

        // Свойство, проверяем значение на отрицательность.
        public double SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? -value : value; }
        }


        // Метод для вычисления площади равностороннего треугольника
        public override string Area()
        {
            return Math.Round((0.5 * SideA * SideA * Math.Sin(60 * Math.PI / 180)), 2).ToString();
        }

        // Метод для вычисления периметра квадрата
        public override string Perimeter()
        {
            return (SideA * 3).ToString();
        }

        // Метод возвращающий наименование фигуры
        public override string TriangleType()
        {
            return "Равносторонний треугольник";
        }
    }

    class RightTriangle : Figure
    {
        double height, sideA, sideB;  // Высота прямоугольника

        // Конструктор
        public RightTriangle(double h, double a, double b)
        {
            Height = h;
            SideA = a;
            SideB = b;
        }

        // Свойство, проверяем значение на отрицательность.
        public double SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? -value : value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value < 0 ? -value : value; }
        }

        public double SideB
        {
            get { return sideB; }
            set { sideB = value < 0 ? -value : value; }
        }


        // Метод для вычисления площади прямоугольного треугольника
        public override string Area()
        {
            return Math.Round((0.5 * sideA * height), 2).ToString();
        }

        // Метод для вычисления периметра прямоугольника
        public override string Perimeter()
        {
            return (sideA + sideB + height).ToString();
        }

        // Метод возвращающий наименование фигуры
        public override string TriangleType()
        {
            return "Прямоугольный треугольник";
        }
    }

    class Program
    {
        static void Main()
        {
            bool a = true;
            double text1, text2, text3;
            

            while (a)
            {
                Console.WriteLine("Выберите тип треугольника:");
                Console.WriteLine("1.Равнобедренный");
                Console.WriteLine("2.Равносторонний");
                Console.WriteLine("3.Прямоугольный");
                Console.WriteLine("0.Выход");

                int variant = Convert.ToInt32(Console.ReadLine());

                switch (variant)
                {

                    case 0:
                        a = false;

                        break;


                    case 1:
                        Console.Clear();
                        Console.WriteLine("Введите одну из равных сторон:");
                        text1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите третью сторону:");
                        text2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите угол между равными сторонами:");
                        text3 = Convert.ToDouble(Console.ReadLine());

                        



                        while ((text1 + text1 > text2 && text1 + text2 > text1) == false)
                        {
                            Console.WriteLine("Ошибка, такого треугольника не существует! Введите данные заново!");

                            Console.WriteLine("Введите одну из равных сторон:");
                            text1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите третью сторону:");
                            text2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите угол между равными сторонами:");
                            text3 = Convert.ToDouble(Console.ReadLine());

                            


                        }

                        Figure figure1 = new IsoclesesTriangle(text1, text2, text3);
                        figure1.ShowInfo();

                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine("Введите сторону равностороннего треугольника:");
                        text1 = Convert.ToDouble(Console.ReadLine());



                        Console.Clear();


                        Figure figure2 = new EquilateralTriangle(text1);
                        figure2.ShowInfo();

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Введите первый катет:");
                        text1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второй катет:");
                        text2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите гипотенузу:");
                        text3 = Convert.ToDouble(Console.ReadLine());


                        
                        while ((text1 * text1 + text2 * text2 - text3 * text3 == 0) == false)
                        {
                            Console.WriteLine("Прямоугольный треугольник не может иметь введенные вами стороны! Введите данные заново!");

                            Console.WriteLine("Введите первый катет:");
                            text1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второй катет:");
                            text2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите гипотенузу:");
                            text3 = Convert.ToDouble(Console.ReadLine());



                        }

                        Figure figure3 = new RightTriangle(text1, text2, text3);
                        figure3.ShowInfo();

                        break;


                        



                }
            }



            Console.ReadKey();
        }
    }
}
