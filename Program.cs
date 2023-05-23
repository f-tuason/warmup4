//get input from user
Console.Write("Enter x: ");
int input = Convert.ToInt32(Console.ReadLine());

//variable to show # of columns
int columns = 5;
int lastvalue = 0;

//I have tried this using an array to store the previous values
//but in this case I did not use the array version since I could
//just store to a variable
for (int r = 1; r <= input; r++)
{
    for (int c = 1; c <= columns; c++)
    {
        if (c == 1)
        {
            lastvalue = r;
            Console.Write("{0}\t", r);
        } else
        {
            Console.Write("{0}\t", lastvalue * (r + 1));
            lastvalue = lastvalue * (r + 1);
        }
    }
    Console.WriteLine("");
}
