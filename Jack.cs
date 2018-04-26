using System;

namespace _20180320_Task1_Pattern_Observer
{
    class Jack : IObserver
    {
        public string Name { get; set; }
        IObservable Rose;

        public Jack(string name, IObservable obs)
        {
            Name = name;
            Rose = obs;
            Rose.RegisterObserver(this);
        }

        // Метод обработчик события.
        public void Update(object ob)
        {
            RoseChoice notice = (RoseChoice)ob;

            if (notice.Choice == "Jack")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{Name} теперь встречается с Rose");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine($"{Name} расстроился и убежал...");
                Console.WriteLine($"Rose больше не общается с {Name}");
            }
        }
    }
}