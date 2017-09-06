using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initial examples
            //Initial example
            //writeline takes a string or a variable containing a string as a paramater. 
            //we are passing it a string "hello world" as an argument

            // Console.WriteLine("Hello World!");

            //Change text to have it write your name

            //Console.WriteLine("Hello James!");


            //make an error 
            //note that we get an error when the text is not in quotation marks

            //Console.WriteLine(Hello World);

            #endregion

            #region Using variables
            //Using variables

            //here we are creating a variable named "name"
            //We are defining the type of data that the variable will 
            //Contain, which is a string. (text between two quotation marks " ") 
            // we are setting our string variable name, equal to a string "James"

            //string name = "James";

            //here we write out our greeting, a blank space, and pass in our variable name 
            //which contains a string 

            //Console.WriteLine("Hello " + name);

            //make a string with a few more string variables and add them in. 
            //string name = "James";
            //string age = "26";
            //string favoriteColor = "Blue";
            //string favoriteFood = "Janssons frestelse";

            //Notice how long and ugly this string is? There must be a better way!
            //Console.WriteLine("Hello, my name is " + name + ". My favorite color is " + favoriteColor + " and my favorite food is " + favoriteFood + "!");

            #endregion

            #region Using a response
            //Add a response 
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hello " + name);
            //Console.ReadKey();
            #endregion

            #region Multiple Responses

            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("How old are you?");

            //string age = Console.ReadLine();

            //Console.WriteLine("Your name is " + name + " and you are " + age + " years old");

            #endregion

            #region putting variables into the text 

            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("How old are you?");

            //string age = Console.ReadLine();


            //Note that these are curly braces around the name of the variable. 
            //By using this convention, you're letting C# know that you want it to 
            //substitute the value of the variable name in that location. The last thing 
            //you need to do for this convention to work is prefix the string with a $ sign.

            //Console.WriteLine($"Your name is {name} and you are {age} years old!");

            #endregion

            #region using string.format 

            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("How old are you?");

            //string age = Console.ReadLine();

            //We create a string called greeting, we set it equal to another string 
            //and use a string method: string.format() which takes 2 paramaters. 
            //a string and whatever variables we made earilier. Rather than putting the 
            //variables in directly, we put place holders in for {0} and {1}, which is the order our variables appear

            //string greeting = string.Format("Your name is {0} and you are {1} years old!", name, age);

            //Console.WriteLine(greeting);

            #endregion






        }
    }
}
