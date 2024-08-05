namespace FizzBuzz;

public class WordCreation
{
    public string FizzBuzzChallange(int input)
    {
        string word = "";
        if(input % 3 == 0)
        {
            word = "fizz";
        }
	
        if(input % 5 == 0)
        {
            word = "buzz";
        }

        if(input % 3 == 0 && input % 5 == 0)
        {
            word = "fizzbuzz";
        }

        Console.WriteLine(word);
        return word;
    }
}