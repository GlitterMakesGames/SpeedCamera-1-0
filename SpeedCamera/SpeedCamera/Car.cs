/*
 * Author: Delaina Hardwick
 * Date: 2/4/2023
 * 
 * This is the class for "Car" objects
 */

class Car
{
    //Backing Fields
    private string _make;
    private string _model;
    private int _speed;
    private int _demerits;

    //Main Fields
    public string make { get => this._make; set => this._make = value; }
    public string model { get => this._model; set => this._model = value; }
    public int speed { get => this._speed; set => this._speed = value; }
    public int demerits { get => this._demerits; set => this._demerits = value; }

    public Car(string a, string b, int c)
    {
        make = a;
        model = b;
        speed = c;
    }

    public void calculateDemerits(int speedLimit)
    {
        demerits = 0;
        if (speed <= speedLimit)
        {
            demerits = 0;
        }
        else
        {
            int tempSpeed = speed - (speed % 5);
            do
            {
                demerits++;
                tempSpeed -= 5;
            }
            while (tempSpeed > speedLimit);
        }
    }

    public void outputCarInfo()
    {
        Console.Write(make + " " + model + " " + speed + "mph: ");
        if (demerits == 0)
        {
            Console.Write("OK");
        }
        else if (demerits == -1)
        {
            Console.Write("Too Slow!");
        }
        else
        {
            Console.Write(demerits + " demerits");
        }

        if (demerits >= 10)
        {
            Console.Write(" <LICENSE SUSPENDED>");
        }
        Console.Write("\n");
    }
}