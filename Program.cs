using uppgift5_lexicon;

Garage garage = new Garage();
Vehicle vehicle = new Vehicle();



static void Examine()
{


}

while (true)
{
    Console.WriteLine("Garage App - Selection \n(1, 2, 3 ,4, 0)"
        + "\n1. List vehicles"
        + "\n2. Garage functionality"
        + "\n3. Search"
        + "\n0. Exit the application");
    char input = ' '; //Creates the character input to be used with the switch-case below.
    try
    {
        input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
    }
    catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
    {
        Console.Clear();
        Console.WriteLine("Please enter some input!");
        input = Console.ReadLine()![0];
    }
    switch (input)
    {
        case '1':
            Examine();
            break;
        case '2':
            GarageFunc();
            break;
        case '3':
            Search();
            break;
        case '0':
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Please enter some valid input (0, 1, 2, 3)");
            break;
    }
}