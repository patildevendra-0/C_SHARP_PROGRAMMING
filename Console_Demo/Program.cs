using System;


class vehicle
{
    public int vehicle_number;
    public string vehicle_name;
    public int vehicle_speed;

    public vehicle(int iNo1,string sValue,int iNo2)
    {
        vehicle_number = iNo1;
        vehicle_name = sValue;
        vehicle_speed = iNo2;
    }

    public void vale_print()
    {
        Console.WriteLine($"{vehicle_number} {vehicle_name} {vehicle_speed}");
    }
}

class Equipment 
{
    public string name = "BMW";
    public int speed = 123;

    public void Print()
    {
        Console.WriteLine($"{speed} of {name}");
    }
}

class Program
{
    static void Main(string []argv)
    {
        Console.WriteLine("SHREE GANESH .....");


        int iNo = 10;
        float fNo = 12.12F;
        bool bValue = true;
        double dNo = 456.132D;
        char ch = 'D';
        string demo= "SHREE GANESH";

        Console.WriteLine(iNo);
        Console.WriteLine(fNo);
        Console.WriteLine(bValue);
        Console.WriteLine(dNo);
        Console.WriteLine(ch);
        Console.WriteLine(demo);
        
        int iNo1 = 10;
        double dValue = iNo1;
        Console.WriteLine(dValue);

        double dValue_1 = 123D;
        int iNo_2 =(int) dValue_1;
        Console.WriteLine(iNo_2);

        int iNo_3 = 456;
        string S_Value = Convert.ToString(iNo_3);
        Console.WriteLine(S_Value.GetType());

        Console.WriteLine("ENTER THE NUMBER :");
        int num =Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("VALUE OF num :"+num);

        Console.WriteLine(Math.Max(10,20));   
        int iNo_4 = 456;
        int iNo_5 = 898;

        int MIN = Math.Min(iNo_4,iNo_5);
        Console.WriteLine("MINIMUM NUMBER IS  :"+MIN);     

        string demo_1 = "SHREE";
        string demo_2 = "GANESH";
        string shree = string.Concat(demo_1,demo_2);
        Console.WriteLine(shree);


        Console.WriteLine($"first applicayion : {demo_1} {demo_2}");
        Console.WriteLine(demo_1[0]);
        Console.WriteLine(demo_1.IndexOf("E"));

        int char_pos = shree.IndexOf("G");
        Console.WriteLine(shree.Substring(char_pos));


        string[] cars = {"demo1","demo2","demo3"};

        Console.WriteLine(cars.Length);

        int iCnt = 0;
        for(iCnt=0;iCnt<cars.Length;iCnt++)
        {
            Console.WriteLine(cars[iCnt]);
        }
        
        foreach(string i in cars)
        {
            Console.WriteLine(i);
        }


        int [,] num_12 = {{0,1,02},{10,45,12}};
        Console.WriteLine(num_12[0,2]);

        Equipment obj = new Equipment();
        Console.WriteLine(obj.name);
        Console.WriteLine(obj.speed);

        obj.Print();


        vehicle vobj  = new vehicle(10,"bmw",123);
        vobj.vale_print();


    }
}