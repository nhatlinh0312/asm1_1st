
// See https://aka.ms/new-console-template for more information
Console.WriteLine("******************* Water bill calculation program ****************");

void Calculate_water_bill()
{
    Console.WriteLine("Enter the customer's full name : ");
    string customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Enter number 1 if you are a household customer type and press enter");
    Console.WriteLine("Enter number 2 if you are a public administration customer type and press enter");
    Console.WriteLine("Enter number 3 if you are a production unit customer type and press enter");
    Console.WriteLine("Enter number 4 if you are a business service type customer and press enter");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {

        Console.WriteLine("Enter the number of family members");
        int numberMember = Convert.ToInt32(Console.ReadLine());
        if (numberMember >= 1)
        {
            Console.WriteLine("Enter the previous month's water index");
            int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter this month's water index");
            int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterNumberCurrentMonth >= waterNumberLastMonth)
            {
                int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
                double waterNumberPeople = waterNumber / numberMember;
                double money = 0;
                if (waterNumberPeople > 0 && waterNumber <= 10)
                {
                    money = waterNumber * 5973 * 1.1;
                }
                else if (waterNumberPeople > 10 && waterNumberPeople <= 20)
                {
                    money = waterNumber * 7051 * 1.1;
                }
                else if (waterNumberPeople > 20 && waterNumberPeople <= 30)
                {
                    money = waterNumber * 8699 * 1.1;
                }
                else
                {
                    money = waterNumber * 15929 * 1.1;
                }
                Console.WriteLine("Your family's water bill: {0}", money);
            }
            else
            {
                Console.WriteLine("The amount of water in the previous month is not greater than the amount of water in the current month");
            }
        }
        else
        {
            Console.WriteLine("You are not a household customer ");
        }
    }
    else if (typeCustomer == 2)
    {

        Console.WriteLine("Please enter last month's water meter reading");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the current month's water meter reading");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
            Console.WriteLine("Water fees of public administrative agencies  {0}", m);
        }
        else
        {
            Console.WriteLine("The previous month's water meter reading is not greater than the current month's");
        }
    }
    else if (typeCustomer == 3)
    {

    }
    else if (typeCustomer == 4)
    {

    }
    else
    {
        Console.WriteLine("Please enter the correct customer category");
    }
}

Calculate_water_bill();
