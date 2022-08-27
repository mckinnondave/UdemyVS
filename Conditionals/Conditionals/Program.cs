namespace Conditionals
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    System.Console.WriteLine("We've got a promotion!");
                    break ;

                default:
                    System.Console.WriteLine("I don't understand this season");
                    break;
            }
        }
    }
}
