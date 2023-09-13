using static System.Console;

namespace marioStair;

class Program
{
    public static void Main()
    {
        while(true)
        {
            Write("Digite um número de 1 a 8: ");
            int userChoice = int.Parse(ReadLine()!);

            if(ValidateUserInput(userChoice))
            {
                PrintStairs(userChoice);
            }
        }
    }

    private static bool ValidateUserInput(int userChoice)
    {
        return userChoice > 0 && userChoice < 9;
    }

    private static void PrintStairs(int userChoice)
    {
        int hashTags = 1;
        int spaces = userChoice - 1;

        for(int i = 0; i < userChoice; i++)
        {
            for(int k = 0; k < spaces; k++)
            {
                Write(" ");
            }

            for(int j = 0; j < hashTags; j++)
            {
                Write("#");
            }
            hashTags++;
            spaces--;
         
            WriteLine();
        }

        hashTags = 1;
     
        for(int i = 0; i < userChoice; i++)
        {
            for(int j = 0; j < hashTags; j++)
            {
                Write("#");
            }
            hashTags++;
            WriteLine();
        }
    }
}