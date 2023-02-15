// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~START MAIN~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
int response = 0;
while(response != 3)
{
    Console.WriteLine("Press...\n 1) Full Triangle \n 2) Worn Triangle \n 3) Exit");
    response = int.Parse(Console.ReadLine());
        if(response == 1)
        {
            GetFull();
        }
        if(response == 2)
        {
            GetPartial();
        }
        if(response != 1 && response != 2 && response != 3)
        {
                System.Console.WriteLine("Invalid input");
        }
}
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~END MAIN~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~FULL TRIANGLE METHOD~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
static void GetFull()
{
Random rnd = new Random();
int number = rnd.Next(3,9);
    for(int i = 1; i <= number; i++)
    {
        for(int j = i; j > 0; j--)
        {
            Console.Write("o");
        }
    System.Console.WriteLine();
    }
}
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ END FULL TRIANGLE METHOD~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ PARTIAL TRIANGLE METHOD~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
static void GetPartial()
{
    for(int i = 1; i <= 10; i++)
        {
        for(int j = i; j > 0; j--)
        {
            Random rnd = new Random();
            int num = rnd.Next(2);
           if (num == 1)
           {
            Console.Write("o");
           }
           else{
            Console.Write(" ");
           }
        }
    System.Console.WriteLine();
        }
}
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~END PARTIAL TRIANGLE METHOD~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

