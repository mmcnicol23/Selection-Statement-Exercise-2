namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("What's your favorite subject at school?");
          string favoriteSubject = Console.ReadLine();
          
          switch (favoriteSubject)
          {
              case "Math":
                Console.WriteLine("Math is cool because it's all about solving problems!");
                break;
                
              case "English":
                  Console.WriteLine("English is awesome, I love to write!");
                  break;
              
              case "History":
                  Console.WriteLine("History is so interesting. I love to learn about Ancient Rome!");
                  break;
              
              case "Science":
                  Console.WriteLine("Like Bill Nye said... science rules!");
                  break;
              
              default:
                Console.WriteLine("Interesting choice! School is cool!");
                break;

          }

        }
    }
}