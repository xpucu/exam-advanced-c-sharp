using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
    {
        static void Main()
        {

        StringBuilder inputCode = new StringBuilder();
        const string CapturePatternInt = @"(int\s[a-zA-Z]{1,25})";
        const string CapturePatternDouble = @"(double\s[a-zA-Z]{1,25})";

        string input = Console.ReadLine();
        while (input != "//END_OF_CODE")
        {
            inputCode.Append(input);
            input = Console.ReadLine();
        }
        //Console.WriteLine(inputCode);

        StringBuilder result = new StringBuilder();

        string text = Regex.Replace(inputCode.ToString(), @"\s+", " ");
        //Regex stringMatcher = new Regex(CapturePatternInt);
        //var matches = stringMatcher.Matches(text);

        //StringBuilder ints = new StringBuilder();

        Match m = Regex.Match(text, CapturePatternInt);
        List<string> listInts = new List<string>();
        while (m.Success)
        {
            listInts.Add((m.Value.Split(' ')[1]));
            m = m.NextMatch();
        }


        Match n = Regex.Match(text, CapturePatternDouble);
        List<string> listDoubles = new List<string>();
        while (n.Success)
        {
            //Console.WriteLine("'{0}' found at position {1}", m.Value, m.Index);
            //string b = a.Split(',')[0];
            listDoubles.Add((n.Value.Split(' ')[1]));
            n = n.NextMatch();
        }
        //Console.WriteLine(listInts.Count);
        
        

        if (listDoubles.Count == 0)
        {
            Console.WriteLine("Doubles: None");
        }
        else
        {
            listDoubles.Sort();
            Console.WriteLine("Doubles: {0}", String.Join(", ", listDoubles));
        }


        if (listInts.Count == 0)
        {
            Console.WriteLine("Ints: None");
        }
        else
        {
            listInts.Sort();
            Console.WriteLine("Ints: {0}", String.Join(", ",listInts) );
        }





        //Console.WriteLine(m);



    }


}

