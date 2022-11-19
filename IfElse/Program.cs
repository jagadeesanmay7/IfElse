int SNo = 1;
string[] Products = { "TableMate", "Laptop", "Wireless Mouse", "Headset", "Computer specs" };
int[] ProductPricing = { 1200, 140000, 4000, 40000, 7000 };
string USEROUTPUT = "Thanks for choosing ";
int UserInput;
Console.WriteLine("Welcome to \"Product 2 place\"");
repeat:
Console.WriteLine("What product do you like to buy?");
Console.WriteLine("Press the Number to Purchase");
foreach (string products in Products)
{
    Console.Write(SNo++);
    Console.WriteLine($" {products}");
}
retry:
try
{
    UserInput = int.Parse(Console.ReadLine());
    if (UserInput == 1)
    {
        Console.WriteLine($"{USEROUTPUT}TableMate, the pricing is 1200₹");
    }
    else if (UserInput == 2)
    {
        Console.WriteLine($"{USEROUTPUT}Laptop, the pricing is 1,40,000₹");
    }
    else if (UserInput == 3)
    {
        Console.WriteLine($"{USEROUTPUT}ergonomic Wireless Mouse, the pricing is 4000₹");
    }
    else if (UserInput == 4)
    {
        Console.WriteLine($"{USEROUTPUT}Headset, the pricing is 40,000₹");
    }
    else if (UserInput == 5)
    {
        Console.WriteLine($"{USEROUTPUT}Computer specs, the pricing is 7000₹");
    }
    else
    {
        SNo = 1;
        Console.WriteLine("Sorry you have entered invalid input, please try again");
        goto repeat;
    }
}
catch (Exception ex)
{
    Console.WriteLine("invalid input, please try again");
    goto retry;
}
retryPayment:
try
{
payment:
    int AcceptedPrice = int.Parse(Console.ReadLine());

    if (ProductPricing[UserInput - 1] == AcceptedPrice)
    {
        Console.WriteLine("Thanks for Purchasing from \"Product 2 place\", visit again");
    }
    else
    {
        Console.WriteLine("Money not debitted");
        goto payment;
    }
}
catch (Exception ex)
{
    Console.WriteLine("Payment is not sucessfully, please try again");
    goto retryPayment;
}