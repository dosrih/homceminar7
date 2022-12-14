int dayNumber = ReadInt("Enter a number from 1 to 7:  ");
Console.WriteLine(WorkHoliday(dayNumber));


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Under the digit " + a + " - Output");
        }
        else
        {
            Console.Write("Under the number " + a + " - Worker");
        }
    }
    else
    {
        Console.Write("You entered a number not in the range from 1 to 7, so it is not possible to determine");
    }
    return " day.";
};