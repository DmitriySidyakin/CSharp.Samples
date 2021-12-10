using System;

namespace CSharp1_0
{
    class Program
    {

        static string Version = "C# 1.0";

        static void Main(string[] args)
        {
            /**
             * Примеры эелементов C# 1.0
             */
            Console.WriteLine("C# 1.0 Примеры:");
            Console.WriteLine("__________________________________");
            /**
             * Классы +
             * Структуры
             * Интерфейсы
             * События +
             * Свойства +
             * Делегаты + 
             * Операторы и выражения 
             * Операторы
             * Атрибуты
            */

            /* Классы, События, Свойства, Делегаты */

            Test.Wrap(CSharp1_0.Program.Test1, 1, Version);
            Test.Wrap(CSharp1_0.Program.Test2, 2, Version);
            Test.Wrap(CSharp1_0.Program.Test3, 3, Version);
            Test.Wrap(CSharp1_0.Program.Test4, 4, Version);
            Test.Wrap(CSharp1_0.Program.Test5, 5, Version);


            /* Структуры, Интерфейсы, Операторы и выражения, Операторы, Атрибуты*/

            Console.ReadLine();

        }

        /// <summary>
        /// Тест проверки класса, делегата и свойства
        /// </summary>
        private static void Test1()
        {
            MathOperationExecutor executor = new MathOperationExecutor();

            executor.Execute(5, 5);
        }

        /// <summary>
        /// Тест проверки Событий 1
        /// </summary>
        private static void Test2()
        {
            MathOperationExecutor executor = new MathOperationExecutor();

            executor.MathSequence += MathOperationExecutor.Div;
            executor.MathSequence += MathOperationExecutor.Mul;
            executor.MathSequence += MathOperationExecutor.Rem;
            executor.MathSequence += MathOperationExecutor.Sub;
            executor.MathSequence += MathOperationExecutor.Sum;

            executor.ExecuteMathSequence(5, 5);
        }

        /// <summary>
        /// Тест проверки Событий 2
        /// </summary>
        private static void Test3()
        {
            MathOperationExecutor executor = new MathOperationExecutor();

            executor.MathSequence += MathOperationExecutor.Div;
            executor.MathSequence += MathOperationExecutor.Mul;
            executor.MathSequence += MathOperationExecutor.Rem;
            executor.MathSequence += MathOperationExecutor.Sub;

            executor.MathSequence += MathOperationExecutor.Sum;
            executor.MathSequence += MathOperationExecutor.Sum;

            executor.ExecuteMathSequence(5, 5);
        }

        /// <summary>
        /// Тест проверки Событий 3
        /// </summary>
        private static void Test4()
        {
            MathOperationExecutor executor = new MathOperationExecutor();

            executor.MathSequence += MathOperationExecutor.Div;
            executor.MathSequence += MathOperationExecutor.Mul;
            executor.MathSequence += MathOperationExecutor.Rem;
            executor.MathSequence += MathOperationExecutor.Sub;
            executor.MathSequence += MathOperationExecutor.Sub;
            executor.MathSequence += MathOperationExecutor.Sum;
            executor.MathSequence -= MathOperationExecutor.Sub;

            executor.ExecuteMathSequence(5, 5);
        }

        /// <summary>
        /// Тест проверки Событий 4
        /// </summary>
        private static void Test5()
        {
            MathOperationExecutor executor = new MathOperationExecutor();

            executor.MathSequence += MathOperationExecutor.Div;
            executor.MathSequence += MathOperationExecutor.Mul;
            executor.MathSequence += MathOperationExecutor.Rem;
            executor.MathSequence += MathOperationExecutor.Sub;
            executor.MathSequence += MathOperationExecutor.Sub;
            executor.MathSequence += MathOperationExecutor.Sum;
            executor.MathSequence -= MathOperationExecutor.Sub;
            executor.MathSequence -= MathOperationExecutor.Sub;

            executor.ExecuteMathSequence(5, 5);
        }
    }
}
