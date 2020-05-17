using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MytinyurlAPI.Services
{
    //https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings

    public class GenerateStringService
    {
        private static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public string getString()
        {
            var stringChars = new char[10];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString;
        }
    }
}