namespace D1Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Sentence : ");
            string line=Console.ReadLine();

            int charcount=Countcharacter(line); 
            int wordcount=Countwords(line);
            string Rsentence=Reversesentence(line);
            bool Palin = Palindrome(line);
            int vcount, ccount, intcount, spclcount;

            CountcharacterType(line, out vcount, out ccount, out intcount, out spclcount);


            Console.WriteLine($"No. of characters : {charcount}");
            Console.WriteLine($"No. of words : {wordcount}");
            Console.WriteLine($"Reversed Sntence : {Rsentence}");
            Console.WriteLine($"IsPalindrome : {Palin}");
            Console.WriteLine($"No. of Vowels : {vcount}");
            Console.WriteLine($"No. of Consonants : {ccount}");
            Console.WriteLine($"No. of Integer : {intcount}");
            Console.WriteLine($"No. of Special Character : {spclcount}");
        }

        static int Countcharacter (string line)
        {return line.Length;}

        static int Countwords (string line)
            { return line.Length; }

        static string Reversesentence (string line)
        {
            string[] line1 = line.Split (' ');
            Array.Reverse (line1);
            return string.Join (" ", line1);

        }

        static bool Palindrome (string line)
        {
            string palinline = line.ToLower().Replace(" ", "");
            return palinline==ReverseString (palinline);
        }

        static string ReverseString (string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }

        static void CountcharacterType (string line, out int vcount,out int ccount, out int intcount,out int spclcount)
        {
            vcount = 0;
            ccount = 0;
            intcount = 0;
            spclcount = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                    {
                       if ( char.ToLower(c)=='a'|| char.ToLower(c)=='e' || char.ToLower(c)=='i' || char.ToLower(c)=='o' || char.ToLower(c)=='u' )
                            { vcount++; }
                       else { ccount++; }
                    }
                else if (char.IsDigit(c))
                { intcount++; }

                else { spclcount++; }



            }

        }
    }

}
