using System;
class StringOperation 
{
    static void Main()
    {
        Console.WriteLine("\nPlease enter a String to find length :");
        string? Str = Console.ReadLine();
        Console.WriteLine("The String is :"+Str);
        Console.WriteLine("The length of the String is :"+Str?.Length);

        Console.WriteLine("\nPlease enter a sentence to Identify it's type :");
        string Sentence = Console.ReadLine();

        if( isDeclarative(Sentence) )
        {
            Console.WriteLine("It is Declarative Sentence!!!");
        }
        else if(isInterrogatory(Sentence))
        {
            Console.WriteLine("It is Interrogatory Sentence!!!");
        }
        else if(isExclamatory(Sentence))
        {
            Console.WriteLine("It is Exclamatory Sentence!!!");
        }
        else
        {
            Console.WriteLine("It is Not a Sentence!!!");
        }

        Console.WriteLine("\nPlease enter your Full Name :");
        string fName = Console.ReadLine();
        Change(fName);
    }
    public static bool isDeclarative(string s)
    {
        return s[s.Length-1]=='.';
    }
     public static bool isInterrogatory(string s)
    {
        return s[s.Length-1]=='?';
    }
     public static bool isExclamatory(string s)
    {
        return s[s.Length-1]=='!';
    }
    public static void Change(string s)
    {
         string[] splitName = s.Split(' ');
        if(splitName.Length==1)
            Console.WriteLine("Your Name is : "+splitName[0]);
        else
            Console.WriteLine("Your Name is : "+splitName[1]+", "+splitName[0]);
    }
}