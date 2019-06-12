using Laba10;
using System;
using System.Collections.Generic;

namespace Laba12
{
    class TestCollections
    {
        Queue<Working> queueTKey;
        Queue<string> queueString;
        SortedDictionary<Working, Engineer> sortedDictTKey;
        SortedDictionary<string, Engineer> sortedDictString;
        private int size;

        public TestCollections(int number)
        {
            size = number;
            queueTKey = new Queue<Working>(number);
            queueString = new Queue<string>(number);
            sortedDictTKey = new SortedDictionary<Working, Engineer>(new Dictionary<Working, Engineer>(number));
            sortedDictString = new SortedDictionary<string, Engineer>(new Dictionary<string, Engineer>(number));
        }

        public override string ToString()
        {
            string str = "";
            str += "queueTKey:\n";
            foreach (Working t in queueTKey)
            {
                str += $"{t.ToString()}\n";
            }
            str += "\nqueueString:\n";
            foreach (string t in queueString)
            {
                str += $"{t}\n";
            }
            str += "\nsortedDictTKey:\n";
            foreach (var t in sortedDictTKey)
            {
                str += $"Key: {t.Key.ToString()} :::::::: Value: {t.Value.ToString()}\n";
            }
            str += "\nsortedDictString:\n";
            foreach (var t in sortedDictString)
            {
                str += $"Key: {t.Key} :::::::: Value: {t.Value.ToString()}\n";
            }
            return str;
        }

        public bool ContainsToQueueTKey(Working obj)
        {
            return queueTKey.Contains(obj);
        }

        public bool ContainsToQueueString(string obj)
        {
            return queueString.Contains(obj);
        }

        public bool ContainsKeyToSortedDictTKey(Working obj)
        {
            return sortedDictTKey.ContainsKey(obj);
        }

        public bool ContainsKeyToSortedDictString(string obj)
        {
            return sortedDictString.ContainsKey(obj);
        }

        public bool ContainsValueToSortedDictTKey(Engineer obj)
        {
            return sortedDictTKey.ContainsValue(obj);
        }

        private static Engineer[] Engineers = new Engineer[]
        {
            new Engineer("Алена", "Ивина", Gender.Female, Category.Beginner),
            new Engineer("Катя", "Краснюкова", Gender.Female, Category.God),
            new Engineer("Иван", "Бетев", Gender.Male, Category.Middle),
            new Engineer("Андрей", "Иванов", Gender.Male, Category.God),
            new Engineer("Мария", "Шнайдер", Gender.Female, Category.Beginner),
            new Engineer("Анастасия", "Филлипова", Gender.Female, Category.Middle),
            new Engineer("Алексей", "Вотяков", Gender.Female, Category.Beginner),
            new Engineer("Максим", "Ярыжнов", Gender.Female, Category.Beginner),
            new Engineer("Василий", "Колтуклу", Gender.Female, Category.Beginner),
            new Engineer("Валерия", "Слипуха", Gender.Female, Category.Beginner),
            new Engineer("Сергей", "Ивин", Gender.Female, Category.Beginner),
            new Engineer("Сергей", "Тучин", Gender.Female, Category.Beginner),
            new Engineer("Анастасия", "Бызова", Gender.Female, Category.Beginner),
            new Engineer("Эля", "Гатауллина", Gender.Female, Category.Beginner),
            new Engineer("Екатерина", "Краснюкова", Gender.Female, Category.Beginner),
            new Engineer("Слава", "Айваседо", Gender.Female, Category.Beginner),
            new Engineer("Алена", "Шмигирилова", Gender.Female, Category.Beginner),
            new Engineer("Дана", "Гаук", Gender.Female, Category.Beginner)
        };

        public static Engineer GetEngineer(int n)
        {
            if (n >= 0 && n < Engineers.Length)
            {
                return Engineers[n];
            }
            else
            {
                return null;
            }
        }

        public void AddRandom()
        {
            Random r = new Random();
            List<int> masRand = new List<int>(size);
            int i = 0;
            if (size > Engineers.Length)
            {
                throw new Exception("Невозможно заполнить коллекцию рандомно без повторений.");
            }
            while (i < size)
            {
                int randomNum = r.Next(0, Engineers.Length);
                if (masRand.IndexOf(randomNum) == -1)
                {
                    Engineer engineer = TestCollections.GetEngineer(randomNum);
                    sortedDictTKey.Add(engineer.BaseWorking, engineer);
                    masRand.Add(randomNum);
                    i++;
                }
            }
            queueTKey = new Queue<Working>(sortedDictTKey.Keys);
            queueString = new Queue<string>();
            sortedDictString = new SortedDictionary<string, Engineer>();
            foreach (var obj in sortedDictTKey)
            {
                queueString.Enqueue(obj.Key.ToString());
                sortedDictString.Add(obj.Key.ToString(), obj.Value);
            }
        }

        public void Add(Engineer engineer)
        {
            string engineerString = engineer.BaseWorking.ToString();
            if (!queueTKey.Contains(engineer))
            {
                sortedDictTKey.Add(engineer.BaseWorking, engineer);
            }
            else
            {
                throw new MyException("Объект с данными фамилией и именем уже существует!", engineer.Firstname, engineer.Surname);
            }
            queueTKey = new Queue<Working>(sortedDictTKey.Keys);
            queueString = new Queue<string>();
            sortedDictString = new SortedDictionary<string, Engineer>();
            foreach (var obj in sortedDictTKey)
            {
                queueString.Enqueue(obj.Key.ToString());
                sortedDictString.Add(obj.Key.ToString(), obj.Value);
            }
        }

        public void Del(string Firsname, string Surname)
        {
            if (sortedDictTKey.Count == 0)
            {
                throw new Exception("Коллекция пуста.");
            }
            Engineer engineer = new Engineer(Firsname, Surname, Gender.Female, Category.Beginner);
            if (sortedDictTKey.ContainsValue(engineer))
            {
                sortedDictTKey.Remove(engineer.BaseWorking);
                queueTKey = new Queue<Working>(sortedDictTKey.Keys);
                queueString = new Queue<string>();
                sortedDictString = new SortedDictionary<string, Engineer>();
                foreach (var obj in sortedDictTKey)
                {
                    queueString.Enqueue(obj.Key.ToString());
                    sortedDictString.Add(obj.Key.ToString(), obj.Value);
                }
            }
            else
            {
                throw new Exception("Такого элемента не существует.");
            }
        }
    }
}
