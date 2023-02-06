/*
 * Author: Delaina Hardwick
 * Date: 2/4/2023
 * 
 * This is the class containing main
 */
class SpeedCamera
{
    public static void Main(String[] args)
    {
        int speedLimit;

        Car car1;
        Car car2;
        Car car3;

        string tempM1;
        string tempM2;
        int tempSp;
        int tempDem;

        //---------------------------USER INPUT---------------------------//

        Console.Write("Please enter the speed limit: ");
        speedLimit = Int32.Parse(Console.ReadLine());
        Console.Write("\n");

        //USER INPUT FOR THE CAR1 OBJECT//
        Console.Write("Please enter the make of the first car: ");
        tempM1 = Console.ReadLine();
        //------------------
        Console.Write("Please enter the model of the first car: ");
        tempM2 = Console.ReadLine();
        //------------------
        Console.Write("Please enter the speed of the first car: ");
        tempSp = Int32.Parse(Console.ReadLine());
        //------------------
        car1 = new Car(tempM1, tempM2, tempSp);

        //USER INPUT FOR THE CAR2 OBJECT//
        Console.Write("Please enter the make of the second car: ");
        tempM1 = Console.ReadLine();
        //------------------
        Console.Write("Please enter the model of the second car: ");
        tempM2 = Console.ReadLine();
        //------------------
        Console.Write("Please enter the speed of the second car: ");
        tempSp = Int32.Parse(Console.ReadLine());
        //------------------
        car2 = new Car(tempM1, tempM2, tempSp);

        //USER INPUT FOR THE CAR3 OBJECT//
        Console.Write("Please enter the make of the third car: ");
        tempM1 = Console.ReadLine();
        //------------------
        Console.Write("Please enter the model of the third car: ");
        tempM2 = Console.ReadLine();
        //------------------
        Console.Write("Please enter the speed of the third car: ");
        tempSp = Int32.Parse(Console.ReadLine());
        //------------------
        car3 = new Car(tempM1, tempM2, tempSp);

        //---------------------------CALCULATIONS & FINAL OUTPUT---------------------------//

        car1.calculateDemerits(speedLimit); //infinite loop?
        car2.calculateDemerits(speedLimit);
        car3.calculateDemerits(speedLimit);

        Console.WriteLine();
        Console.WriteLine("Speed Limit: " + speedLimit + "mph");

        car1.outputCarInfo();
        car2.outputCarInfo();
        car3.outputCarInfo();
    }
}