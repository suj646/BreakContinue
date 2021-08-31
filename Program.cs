using System;

namespace breakcontinue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            con2 obj1 = new con2();
            obj1.con1();
            

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}

class con2
{
    public void con1()

    {

        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }

}