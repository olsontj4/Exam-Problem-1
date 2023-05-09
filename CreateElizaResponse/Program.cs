using System;

namespace CreateElizaResponse
{
    public class Program
    {
        static void Main(string[] args)
        {
            string check = "";
            Console.WriteLine("What seems to be the problem?");
            while (check != "exit")
            {
                check = Console.ReadLine();
                if (check != "exit")
                {
                    Console.WriteLine(CreateElizaResponse(check));
                }
            }
        }
        static string CreateElizaResponse(string prompt)
        {
            string[] genericResponses = { "Tell me more.", "Go on.", "I see.", "Of course." };
            string[] parse = prompt.Split(' ');
            for (int i = 0; i < parse.Length; i++)
            {
                if (parse[i] == "my")
                {
                    return "Tell me more about your " + parse[i + 1];
                }
                else if (parse[i] == "love" || parse[i] == "hate")
                {
                    return "You feel really strongly about that.";
                }
            }
            return genericResponses[parse.Length % genericResponses.Length];//Feels random, but it's based on the length of the user's input.
        }
    }
}