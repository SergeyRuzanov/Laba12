using Laba10;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Laba12
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StopWatch
            Stopwatch stopwatch = new Stopwatch();
            TestCollections testCollections = new TestCollections(5);
            testCollections.Add(new Engineer("Анастасия", "Филлипова", Gender.Female, Category.Middle));
            testCollections.Add(new Engineer("Андрей", "Иванов", Gender.Male, Category.God));
            testCollections.Add(new Engineer("Иван", "Бетев", Gender.Male, Category.Middle));
            testCollections.Add(new Engineer("Алена", "Ивина", Gender.Female, Category.Beginner));
            testCollections.Add(new Engineer("Алексей", "Вотяков", Gender.Female, Category.Beginner));
            testCollections.Add(new Engineer("Максим", "Ярыжнов", Gender.Female, Category.Beginner));
            testCollections.Add(new Engineer("Василий", "Колтуклу", Gender.Female, Category.Beginner));
            testCollections.Add(new Engineer("Валерия", "Слипуха", Gender.Female, Category.Beginner));
            testCollections.Add(new Engineer("Сергей", "Ивин", Gender.Female, Category.Beginner));
            testCollections.Add(new Engineer("Сергей", "Тучин", Gender.Female, Category.Beginner));
            testCollections.Add(new Engineer("Анастасия", "Бызова", Gender.Female, Category.Beginner));
            testCollections.Add(new Engineer("Эля", "Гатауллина", Gender.Female, Category.Beginner));
            testCollections.Add(new Engineer("Екатерина", "Краснюкова", Gender.Female, Category.Beginner));
            testCollections.Add(new Engineer("Слава", "Айваседо", Gender.Female, Category.Beginner));
            testCollections.Add(new Engineer("Алена", "Шмигирилова", Gender.Female, Category.Beginner));
            testCollections.Add(new Engineer("Дана", "Гаук", Gender.Female, Category.Beginner));
            Console.WriteLine(testCollections);

            bool f;
            Working work;

            work = (new Engineer("Слава", "Айваседо", Gender.Female, Category.Beginner)).BaseWorking;
            stopwatch.Start();
            f = testCollections.ContainsToQueueTKey(work);
            stopwatch.Stop();
            Console.WriteLine($"ContainsToQueueTKey (Начало): Bool: {f}; Time: {stopwatch.Elapsed}");

            work = (new Engineer("Алена", "Ивина", Gender.Female, Category.Beginner)).BaseWorking;
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsToQueueTKey(work);
            stopwatch.Stop();
            Console.WriteLine($"ContainsToQueueTKey (Середина): Bool: {f}; Time: {stopwatch.Elapsed}");

            work = (new Engineer("Максим", "Ярыжнов", Gender.Female, Category.Beginner)).BaseWorking;
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsToQueueTKey(work);
            stopwatch.Stop();
            Console.WriteLine($"ContainsToQueueTKey (Конец): Bool: {f}; Time: {stopwatch.Elapsed}");

            work = (new Engineer("БлаБла", "Бла", Gender.Female, Category.Middle)).BaseWorking;
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsToQueueTKey(work);
            stopwatch.Stop();
            Console.WriteLine($"ContainsToQueueTKey (Не найдено): Bool: {f}; Time: {stopwatch.Elapsed}");
            Console.WriteLine();
            /////////=====================

            string str = (new Engineer("Слава", "Айваседо", Gender.Female, Category.Beginner)).BaseWorking.ToString();
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsToQueueString(str);
            stopwatch.Stop();
            Console.WriteLine($"ContainsToQueueString (Начало): Bool: {f}; Time: {stopwatch.Elapsed}");

            str = (new Engineer("Алена", "Ивина", Gender.Female, Category.Beginner)).BaseWorking.ToString();
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsToQueueString(str);
            stopwatch.Stop();
            Console.WriteLine($"ContainsToQueueString (Середина): Bool: {f}; Time: {stopwatch.Elapsed}");

            str = (new Engineer("Максим", "Ярыжнов", Gender.Female, Category.Beginner)).BaseWorking.ToString();
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsToQueueString(str);
            stopwatch.Stop();
            Console.WriteLine($"ContainsToQueueString (Конец): Bool: {f}; Time: {stopwatch.Elapsed}");

            str = (new Engineer("БлаБла", "Бла", Gender.Female, Category.Middle)).BaseWorking.ToString();
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsToQueueString(str);
            stopwatch.Stop();
            Console.WriteLine($"ContainsToQueueString (Не найдено): Bool: {f}; Time: {stopwatch.Elapsed}");
            Console.WriteLine();
            /////===========================

            work = (new Engineer("Слава", "Айваседо", Gender.Female, Category.Beginner)).BaseWorking;
            stopwatch.Start();
            f = testCollections.ContainsKeyToSortedDictTKey(work);
            stopwatch.Stop();
            Console.WriteLine($"ContainsKeyToSortedDictTKey (Начало): Bool: {f}; Time: {stopwatch.Elapsed}");

            work = (new Engineer("Алена", "Ивина", Gender.Female, Category.Beginner)).BaseWorking;
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsKeyToSortedDictTKey(work);
            stopwatch.Stop();
            Console.WriteLine($"ContainsKeyToSortedDictTKey (Середина): Bool: {f}; Time: {stopwatch.Elapsed}");

            work = (new Engineer("Максим", "Ярыжнов", Gender.Female, Category.Beginner)).BaseWorking;
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsKeyToSortedDictTKey(work);
            stopwatch.Stop();
            Console.WriteLine($"ContainsKeyToSortedDictTKey (Конец): Bool: {f}; Time: {stopwatch.Elapsed}");

            work = (new Engineer("БлаБла", "Бла", Gender.Female, Category.Middle)).BaseWorking;
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsKeyToSortedDictTKey(work);
            stopwatch.Stop();
            Console.WriteLine($"ContainsKeyToSortedDictTKey (Не найдено): Bool: {f}; Time: {stopwatch.Elapsed}");
            Console.WriteLine();
            /////===========================

            str = (new Engineer("Слава", "Айваседо", Gender.Female, Category.Beginner)).BaseWorking.ToString();
            stopwatch.Start();
            f = testCollections.ContainsKeyToSortedDictString(str);
            stopwatch.Stop();
            Console.WriteLine($"ContainsKeyToSortedDictString (Начало): Bool: {f}; Time: {stopwatch.Elapsed}");

            str = (new Engineer("Алена", "Ивина", Gender.Female, Category.Beginner)).BaseWorking.ToString();
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsKeyToSortedDictString(str);
            stopwatch.Stop();
            Console.WriteLine($"ContainsKeyToSortedDictString (Середина): Bool: {f}; Time: {stopwatch.Elapsed}");

            str = (new Engineer("Максим", "Ярыжнов", Gender.Female, Category.Beginner)).BaseWorking.ToString();
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsKeyToSortedDictString(str);
            stopwatch.Stop();
            Console.WriteLine($"ContainsKeyToSortedDictString (Конец): Bool: {f}; Time: {stopwatch.Elapsed}");

            str = (new Engineer("БлаБла", "Бла", Gender.Female, Category.Middle)).BaseWorking.ToString();
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsKeyToSortedDictString(str);
            stopwatch.Stop();
            Console.WriteLine($"ContainsKeyToSortedDictString (Не найдено): Bool: {f}; Time: {stopwatch.Elapsed}");
            Console.WriteLine();
            /////===========================

            Engineer eng = new Engineer("Слава", "Айваседо", Gender.Female, Category.Beginner);
            stopwatch.Start();
            f = testCollections.ContainsValueToSortedDictTKey(eng);
            stopwatch.Stop();
            Console.WriteLine($"ContainsValueToSortedDictTKey (Начало): Bool: {f}; Time: {stopwatch.Elapsed}");

            eng = new Engineer("Алена", "Ивина", Gender.Female, Category.Beginner);
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsValueToSortedDictTKey(eng);
            stopwatch.Stop();
            Console.WriteLine($"ContainsValueToSortedDictTKey (Середина): Bool: {f}; Time: {stopwatch.Elapsed}");

            eng = new Engineer("Максим", "Ярыжнов", Gender.Female, Category.Beginner);
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsValueToSortedDictTKey(eng);
            stopwatch.Stop();
            Console.WriteLine($"ContainsValueToSortedDictTKey (Конец): Bool: {f}; Time: {stopwatch.Elapsed}");

            eng = new Engineer("БлаБла", "Бла", Gender.Female, Category.Middle);
            stopwatch.Reset();
            stopwatch.Start();
            f = testCollections.ContainsValueToSortedDictTKey(eng);
            stopwatch.Stop();
            Console.WriteLine($"ContainsValueToSortedDictTKey (Не найдено): Bool: {f}; Time: {stopwatch.Elapsed}");
            Console.WriteLine();
            #endregion

            Application.Run(new Form1());
            Console.ReadKey();
        }
    }
}
