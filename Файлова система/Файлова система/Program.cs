using System;

namespace RestaurantReviews
{
    class Program
    {
        static Review InputReview()
        {
            var r = new Review();

            do
            {
                Console.Write("Введите ник: ");
                r.Nickname = Console.ReadLine() ?? string.Empty;
                if (!Validator.IsValidNickname(r.Nickname))
                    Console.WriteLine("Ошибка! Ник должен быть 3-15 символов, только буквы, цифры и _");
            } while (!Validator.IsValidNickname(r.Nickname));

    
            do
            {
                Console.Write("Введите email: ");
                r.Email = Console.ReadLine() ?? string.Empty;
                if (!Validator.IsValidEmail(r.Email))
                    Console.WriteLine("Ошибка! Некорректный email");
            } while (!Validator.IsValidEmail(r.Email));

       
            do
            {
                Console.Write("Введите номер телефона: ");
                r.Phone = Console.ReadLine() ?? string.Empty;
                if (!Validator.IsValidPhone(r.Phone))
                    Console.WriteLine("Ошибка! Некорректный номер телефона");
            } while (!Validator.IsValidPhone(r.Phone));

        
            Console.Write("Название ресторана: ");
            r.RestaurantName = Console.ReadLine() ?? string.Empty;

            Console.Write("Адрес ресторана: ");
            r.RestaurantAddress = Console.ReadLine() ?? string.Empty;

            Console.Write("Кухня ресторана: ");
            r.Cuisine = Console.ReadLine() ?? string.Empty;

            do
            {
                Console.Write("Контактный номер ресторана: ");
                r.RestaurantPhone = Console.ReadLine() ?? string.Empty;
                if (!Validator.IsValidPhone(r.RestaurantPhone))
                    Console.WriteLine("Ошибка! Некорректный номер телефона ресторана");
            } while (!Validator.IsValidPhone(r.RestaurantPhone));

            
            Console.Write("Оценка ресторана: ");
            r.Rating = Console.ReadLine() ?? string.Empty;

           
            Console.Write("Отзыв о ресторане: ");
            r.UserReview = Console.ReadLine() ?? string.Empty;

            return r;
        }

        static void Main()
        {
            Console.WriteLine("=== Система отзывов о ресторанах ===\n");

            while (true)
            {
                Review review = InputReview();
                FileManager.SaveReviewToFile(review, "reviews.txt");

                
                Console.Write("\nХотите добавить еще отзыв? (д/н): ");
                string? input = Console.ReadLine();
                string answer = (input != null) ? input.ToLower() : "н";

                if (answer != "д" && answer != "y")
                    break;

                Console.WriteLine();
            }

            Console.WriteLine("Программа завершена.");
        }
    }
}
