using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (var number = 0; number < 5; number++)
            { 
            QuoteGenerator.KanyeQwote();
            QuoteGenerator.RonSwansonQuote();
        }
        }//main method
        
    }//public class
}//
