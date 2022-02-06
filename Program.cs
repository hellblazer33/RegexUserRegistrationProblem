// See https://aka.ms/new-console-template for more information
using RegexPattern;

//Console.WriteLine("Hello, World!");
Patterns patterns = new Patterns();
if (patterns.validateEmail("abc+100@gmail.com"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
if (patterns.validateFirstName("Pankaj"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
if (patterns.validateLastName("Kumar"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
if (patterns.validateMobile("91 7883773486"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
if (patterns.password1("helloworld123"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
if (patterns.password2("Helloworld123"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Helloworld123");
if (patterns.password3("123@tEst"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
if (patterns.password4("123@tEst"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
Console.ReadKey();
