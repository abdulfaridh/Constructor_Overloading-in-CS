// See https://aka.ms/new-console-template for more information
namespace one
{
    public class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("a empty constructor");
        }
        public Constructor(int i)
        {
            Console.WriteLine("your number is {0}",i);
        }
        public Constructor(int i,string s)
        {
            Console.WriteLine("your number is {0} and your string is  {1}",i,s);
        }
    }
}