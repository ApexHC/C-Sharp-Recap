//---------C SHARP RECAP ---------


/* I am creating this new directory because I cannot (CANNOT) ge the replit to work and I want to submit the 
C Sharp Recap assignment.*/

/* My assignment is to:

Add three variables of different types, names, and values.
Display all three to the console
Test an age variable with an if statement.  If the age is greater than 17, display a message stating the person's an adult - otherwise state the person is a child.  */


// ------ THREE VARIABLES OF DIFFERENT TYPES NAMES AND VALUES

int aNumber = 500;
Console.WriteLine(aNumber);  //Checks out!


decimal feetInMeter = 3.28m;
Console.WriteLine($"The number of feet in a meter is: " + (feetInMeter));

double myCoffee = 10.5;
Console.WriteLine($"The number of cups my coffee maker can make is: " + (myCoffee));



//------------AGE VARIABLE WITH AN IF STATEMENT

int age = 42;
if(age >= 36)
{
    Console.WriteLine("You can run for president");
}
else if(age >= 18)
{
    Console.WriteLine("You can Vote");
}
else
{
    Console.WriteLine("You are still a child");
}
