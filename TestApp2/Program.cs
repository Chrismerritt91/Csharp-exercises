
using ClassLibrary;

class Sample
{
    static void Main()
    {
        //    String name = "Scott";
        //    int age = 23;

        //    System.Console.Write("hey ");
        //    System.Console.Write(name);
        //    System.Console.Write(" your age is ");
        //    System.Console.Write(age);

        //    System.Console.ReadKey();

        //---------------------------------------
        //area of a circle assignment
        //int radius = 3;

        //System.Console.Write(3.14 * radius * radius);

        //-----------------------------------------------
        //height in inches to centimeters
        //double feet = 6;
        //double inches = 2;
        //double oneInch = 2.54;
        //double oneFoot = 12;

        //double feetInInches = (feet * oneFoot) + inches;

        //System.Console.Write(feetInInches * oneInch);

        //-------------------------------------------------------------------
        //how to round to the nearest thousandth without using commands
        //int input = 417;
        //decimal decimalInput = input;

        //int prevThousand = (input / 1000) * 1000;

        //decimal lastThree1 = decimalInput / 1000;
        //decimal lastThree2 = input /1000;
        //decimal getLastThree = (lastThree1 - lastThree2) * 1000;

        //int round = (getLastThree >= 500) ? 1000 : 0;
        //int lessThanfiveHundred = (input < 500) ? 1000 : 0;

        //int nearestThousand = prevThousand + round + lessThanfiveHundred;

        //System.Console.WriteLine(nearestThousand);

        //-----------------------------------------------------
        //how to convert seconds to days, hours, minutes
        //int seconds = 288970;
        // int minutes = seconds / 60;
        // int hours = seconds / 60 / 60;
        // int days = seconds / 60 / 60 / 24;

        // int secondsLeft = seconds - (minutes * 60);
        // int minutesLeft = minutes - (hours * 60);
        // int hoursLeft = hours - (days * 24);


        // System.Console.WriteLine(days + " days, " + hoursLeft + " hours, " + minutesLeft + " minutes, " + secondsLeft + " seconds");

        //----------------------------------------
        //classify people by height
        //double input = 75;
        //double inch = 2.54;
        //string classification;

        //double height = input * inch;

        //if(height < 150)
        //{
        //    classification = "Dwarf";
        //    System.Console.Write(classification);
        //}
        //else if(height >= 150 && height < 165)
        //{
        //    classification = "Average height";
        //    System.Console.Write(classification);
        //}
        //else if(height >= 165 && height < 195)
        //{
        //    classification = "Tall";
        //    System.Console.Write(classification);
        //}
        //else if(height >= 195)
        //{
        //    classification = "Abnormal height";
        //    System.Console.Write(classification);
        //}

        //-----------------------------------------------------
        //find the biggest number out of the three inputs
        //int num1 = 60;
        //int num2 = 200;
        //int num3 = 123;
        //int bigNum = 0;

        //if(num1 > bigNum)
        //{
        //    bigNum = num1;
        //}
        //if(num2 > bigNum)
        //{
        //    bigNum = num2;
        //}
        //if(num3 > bigNum)
        //{
        //    bigNum = num3;
        //}

        //System.Console.WriteLine(bigNum);

        //-------------------------------------------------
        //pattern printing exercise

        //for (int i = 0; i < 3; i++)
        //{

        //    for (int j = 1; j <= 10; j++)
        //    {

        //        if (j == 5 || j == 6)
        //        {
        //            continue;
        //        }

        //        System.Console.Write(j + " ");
        //    }
        //    System.Console.WriteLine();
        //}

        //for (int i = 0; i < 5; i++)
        //{

        //    for (int j = 10; j >= 1; j--)
        //    {

        //        if (i == 2)
        //        {
        //            if (j < 3)
        //            {
        //                continue;
        //            }

        //        }

        //        if (i == 4)
        //        {
        //            if (j == 3)
        //            {
        //                continue;
        //            }

        //            System.Console.Write((11 - j) + " ");
        //            continue;
        //        }
        //        System.Console.Write(j + " ");
        //    }
        //    System.Console.WriteLine();
        //}
        //System.Console.ReadKey();


        //----------------------------------------------------------------------------------------------------
        //create another project withing the same solution and connect the class library using uses instead of import to use publicly made classes.

        //Customer c1, c2;

        //c1 = new Customer();

        //------------------------------------------------------------------------------------

        //experimenting with fields creating product objects

        //create reference variables
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        product2 = new Product();
        product3 = new Product();

        //initialize fields
        product1.productId = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantitiyInStock = 1200;
        product2.productId = 1002;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantitiyInStock = 3400;
        product3.productId = 1003;
        product3.productName = "Speakers";
        product3.cost = 36000;
        product3.quantitiyInStock = 800;

        //Get values from field
        Console.WriteLine("Product 1:");
        Console.WriteLine("Product ID:" + product1.productId);
        Console.WriteLine("Product Name:" + product1.productName);
        Console.WriteLine("Product Cost:" + product1.cost);
        Console.WriteLine("Product Quantity" + product1.quantitiyInStock);

        Console.WriteLine("\nProduct 2:");
        Console.WriteLine("Product ID:" + product2.productId);
        Console.WriteLine("Product Name:" + product2.productName);
        Console.WriteLine("Product Cost:" + product2.cost);
        Console.WriteLine("Product Quantity" + product2.quantitiyInStock);

        Console.WriteLine("\nProduct 3:");
        Console.WriteLine("Product ID:" + product3.productId);
        Console.WriteLine("Product Name:" + product3.productName);
        Console.WriteLine("Product Cost:" + product3.cost);
        Console.WriteLine("Product Quantity" + product3.quantitiyInStock);

        System.Console.ReadKey();
        


    }


}