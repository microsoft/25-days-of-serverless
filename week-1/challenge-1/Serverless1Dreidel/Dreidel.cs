using System;
using System.Collections.Generic;
using System.Text;

namespace Serverless1Dreidel
{
    public class Dreidel
    {
        private static List<string> list = new List<string>() { "נ", "ג", "ה", "ש" };

        protected static void SetEncoding()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1252 = Encoding.GetEncoding(1255);
            Console.OutputEncoding = enc1252;
        }

        public static string GetRandom()
        {
            //returns נ Nun), ג(Gimmel), ה(Hay), or ש(Shin)       
            SetEncoding();

            Random r = new Random();
            var bytes = new byte[1];
            int d = r.Next(4);
            Console.WriteLine(list[d]);

            return list[d];
        }
    }
}
