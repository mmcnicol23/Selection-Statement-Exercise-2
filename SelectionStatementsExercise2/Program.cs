namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("What's your favorite subject at school?");
          string favoriteSubject = Console.ReadLine();
          switch (favoriteSubject.ToUpper())
          {
              case "MATH":
                Console.WriteLine("Math is cool because it's all about solving problems!");
                break;
                
              case "ENGLISH":
                  Console.WriteLine("English is awesome, I love to write!");
                  break;
              
              case "HISTORY":
                  Console.WriteLine("History is so interesting. I love to learn about Ancient Rome!");
                  break;
              
              case "SCIENCE":
                  Console.WriteLine("Like Bill Nye said... science rules!");
                  break;
              
              default:
                Console.WriteLine("Interesting choice! School is cool!");
                break;

          }

        }
    }
}