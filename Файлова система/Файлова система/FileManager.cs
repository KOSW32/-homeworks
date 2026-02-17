using System;
using System.IO;

namespace RestaurantReviews
{
    public static class FileManager
    {
        public static void SaveReviewToFile(Review r, string filename)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(filename, true))
                {
                    file.WriteLine($"Ник: {r.Nickname}");
                    file.WriteLine($"Email: {r.Email}");
                    file.WriteLine($"Телефон: {r.Phone}");
                    file.WriteLine($"Ресторан: {r.RestaurantName}");
                    file.WriteLine($"Адрес: {r.RestaurantAddress}");
                    file.WriteLine($"Кухня: {r.Cuisine}");
                    file.WriteLine($"Телефон ресторана: {r.RestaurantPhone}");
                    file.WriteLine($"Оценка: {r.Rating}"); 
                    file.WriteLine($"Отзыв: {r.UserReview}");
                    file.WriteLine(new string('-', 30));
                }
                Console.WriteLine("Отзыв успешно сохранен!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при сохранении файла: " + ex.Message);
            }
        }
    }
}
