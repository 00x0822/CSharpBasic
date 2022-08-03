using System;

namespace enumTest
{

    class Program
{   
    enum City
    {
        Seoul,
        Deajun,
        Busan =5,
        JeJu = 10
    }
    [Flags]
    enum Border
    {
        None =0,
        Top =1,
        Right =2,
        Bottom = 4,
        Left = 8

    }
    static void Main(string[] args)
    {
        City myCity;
        myCity = City.Seoul;

        int cityValue = (int)myCity;
        if (myCity == City.Seoul)
        {
                Console.WriteLine("Welcome to Seoul");
        }
        // OR 연사낮로 다중 플래그 할당
        Border b = Border.Top | Border.Bottom;
        
        // & 연산자로 플래그 체크
        if ((b & Border.Top)!= 0)
            {
                //HasFlag()이용 플래그 체크
                if(b.HasFlag(Border.Bottom))
                {
                    Console.WriteLine(b.ToString());
                }
               
            }
      
    }
}
}
