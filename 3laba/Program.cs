namespace _3laba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер дня недели (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите время дня (0-24): ");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сейчас ");
            PrintDay(day);
            Console.Write(", ");
            PrintTime(time);
        }


        public static void PrintDay(int day)
        {
            switch (day){
                case 1:
                    Console.Write(Days.Monday);
                    break;
                case 2:
                    Console.Write(Days.Tuesday);
                    break;
                case 3:
                    Console.Write(Days.Wednesday);
                    break;
                case 4:
                    Console.Write(Days.Thursday);
                    break;
                case 5:
                    Console.Write(Days.Friday);
                    break;
                case 6:
                    Console.Write(Days.Saturday);
                    break;
                case 7:
                    Console.Write(Days.Sunday);
                    break;
               default:
                    Console.WriteLine("Такого номера дня нет");
                    break;
            }
        }

        public static void PrintTime(int time)
        {
            if (time >= 7 && time <= 12)
            {
                Console.Write(TimesOfDay.Morning);
            }
            else if (time >= 13 && time <= 18)
            {
                Console.Write(TimesOfDay.Day);
            }
            else if (time >= 19 && time <= 23)
            {
                Console.Write(TimesOfDay.Evening);
            }
            else if (time >= 0 && time <= 6)
            {
                Console.Write(TimesOfDay.Night);
            }
            else
            {
                Console.WriteLine("Такого времени суток нет");
            }
        }
    }
    
    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum TimesOfDay
    {
        Morning,
        Day,
        Evening,
        Night

    }
}