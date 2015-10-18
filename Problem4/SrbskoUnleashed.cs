using System;



    class SrbskoUnleashed
{
        static void Main()
        {

        const string SplitPattern = @"(([a-zA-Z]{1,}\s[a-zA-Z]{0,}\s[a-zA-Z]{0,})(@[a-zA-Z]{1,}\s[a-zA-Z]{0,}\s[a-zA-Z]{0,})(\d{1,3})\s(\d{1,6}))";
        Regex regex = new Regex(SplitPattern);

        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] data = input.Split(' ');

            input = Console.ReadLine();
        }

        Console.WriteLine(data));
    
        }
}