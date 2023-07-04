using FlyApp.Entity;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FlyApp
{
    internal class Program
    {
         static WorkWithDb wWdB = new WorkWithDb();
        static void Main(string[] args)
        {
            Console.WriteLine("Доступные команды:");
            Console.WriteLine();

            List<string> availableAction = new List<string>()
    {
        "Добавить пассажира",
        "Добавить рейс",
        "Зарегестрировать пассажира",
        "Показать всех пассажиров",
        "Показать все рейсы"
    };
            foreach (string action in availableAction)
            {
                Console.WriteLine(action);
            }
            string userChoise = Console.ReadLine();
            switch (userChoise)
            {
                case "Добавить пассажира":
                    Console.WriteLine("Введите ФИО, серию и номер паспорта, номер рейса пассажира:");
                    string fullName = Console.ReadLine();
                    int passportSeries = int.Parse(Console.ReadLine());
                    int passportId = int.Parse(Console.ReadLine());
                    int flightsId = int.Parse(Console.ReadLine());
                    wWdB.AddPassenger(fullName, passportSeries, passportId, flightsId);
                    break;
                case "Добавить рейс":

                    break;
                case "Зарегестрировать пассажира":

                    break;
                case "Показать всех пассажиров":

                    break;
                case "Показать все рейсы":

                    break;

            }
        }
    }
}