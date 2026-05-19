using System;

namespace Eliza
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(CreateElizaResponse(Console.ReadLine()));
        }

        static string CreateElizaResponse(string s)
        {
            string[] defaultResponses = {
                "Please go on.",
                "Tell me more.",
                "Continue."};
            string response = defaultResponses[new Random().Next(0, 3)];

            //check if s contains or starts with 'love' or 'hate' 
            if(s.Contains("love") || s.Contains("hate")) 
                response = "You have strong feelings about that!";

            //check if s has or starts with 'my'
            if(s.Contains(" my ") || s.Length > 3 && s.Substring(0, 3).ToLower() == "my ")
            {
                
                
                string name = s.Substring(s.IndexOf( " my ") + 4);
                name = name.Contains(" ") ? name.Substring(0, name.IndexOf(" ")) : name;
                response = "tell me more about your " + name + ".";
            }

            return response;
        }
    }
}
