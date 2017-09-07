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

            #region string manipulation 

            //concatenating strings

            string one = "abc";
            string two = "defg";
            string combined = one + two; //will write out "abcdefg"

            Console.WriteLine(combined);

            //built in string formatting 
            string question = "What are you doing?";
            string angryQuestion = question.ToUpper(); //WHAT ARE YOU DOING?

            string quietQuestion = question.ToLower(); //what are you doing?

            string anotherQuietQuestion = "THIS WILL BE QUIET AS WELL".ToLower();

            //concatonate some strings, make them loud or quiet. 

            //trimming strings

            //sometimes if you have user input you might want to trim the white space from their response

            string userInput = " James ";
            string noBlankSpaceStart = userInput.TrimStart(); // "James " 
            string noBlankSpaceEnd = userInput.TrimEnd(); // " James" 
            string totallyClean = userInput.Trim(); // "James"

            string shortenedName = userInput.Trim().Substring(0, 3);
            Console.WriteLine(shortenedName);

            //make some messy strings and trim them 

            #endregion

            #region conditionalStatements
            Console.WriteLine("Enter Your Name");
            string myName = Console.ReadLine().ToLower();

            // == equal to
            // != not equal to
            // > greater then
            // < less then
            // >= greater then or equal
            // || or 

            if (myName == "james") // equals false or true
            {
                Console.WriteLine("Hello David");
            }
            else
            {
                Console.WriteLine("No Its not");
            }

            if (5 > 4 && 6 < 7)
            {
                Console.WriteLine("This is how you can check for conditions at the same time");
            }

            if (5 == 7 || 9 < 10)
            {
                //this code will run because it checks if EITHER of these statements are true 
                Console.WriteLine("This is an 'or' conditional statement. Either can be true for the code to run");
            }

            if (4 == 5)
            {
                Console.WriteLine("This code will never run");
            }
            else
            {
                Console.WriteLine("This code will never run");
            }

           

            Console.WriteLine("Press any key to end");
            Console.ReadKey();

            #endregion

            #region assignments

            ////assignment one
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");

            ////assignment two
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");

            //if (name.ToLower() == "john") //
            //{
            //    Console.WriteLine("Wow, I can't believe your name is john!");
            //}

            //if (name.Length > 6)
            //{
            //    Console.WriteLine("Wow, thats a really long name");
            //}

            ////assignment 3
            //Console.Write("Please write first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please write second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 > 100 && num2 > 100)
            //{
            //    Console.WriteLine("BOth numbers are bigger than 100");
            //}

            ////assignment 4
            //Console.Write("Please write first number: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please write second number: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please write second number: ");
            //int n3 = Convert.ToInt32(Console.ReadLine());

            //if (n1 == n2 && n2 == n3)
            //{
            //    Console.WriteLine("All three numbers are equal");
            //}

            ////Assignment 4
            //Console.WriteLine("Please write you first name:");
            //string fname = Console.ReadLine();
            //Console.WriteLine("Please write your last name:");
            //string lname = Console.ReadLine();
            //Console.WriteLine("Please write your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //// fullname.Contains(" ");
            //if (fname != "" && lname != "" && age > 18)
            //{
            //    Console.WriteLine("Awesome");
            //}
            //else
            //{
            //    Console.WriteLine("You either don't have a name or are too young to be here.... Leave now");
            //}


            ////assignment 5
            //Console.WriteLine("Write a sentence:");
            //string text = Console.ReadLine();
            //if (text.Contains("ä") || text.Contains("ö") || text.Contains("å"))
            //{
            //    Console.WriteLine("You must be swedish! Tjena....");
            //}

            #endregion

        }
    }
}
