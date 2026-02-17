using System.Text.RegularExpressions;

namespace RestaurantReviews
{
    public static class Validator
    {
        public static bool IsValidNickname(string nick) =>
            !string.IsNullOrEmpty(nick) && Regex.IsMatch(nick, @"^[a-zA-Z0-9_]{3,15}$");

        public static bool IsValidEmail(string email) =>
            !string.IsNullOrEmpty(email) && Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

        public static bool IsValidPhone(string phone) =>
            !string.IsNullOrEmpty(phone) && Regex.IsMatch(phone, @"^\+?[0-9]{10,15}$");

        public static bool IsValidRating(int rating) => rating >= 1 && rating <= 5;
    }
}
