
bool end = false;

while (!end)
{
    string command = string.Empty;
    bool success = false;
    int[] numbers = [];

    while (!success)
    {
        command = Console.ReadLine();
        command = string.Join("-", command.ToCharArray().Where(Char.IsDigit));
        if (!string.IsNullOrWhiteSpace(command))
        {
            numbers = command.Split('-').Select(int.Parse).ToArray();
            if (numbers.Length > 11)
            {
                Console.WriteLine("You charge too much!");
                continue;
            }
            else
            {
                success = true;
            }
            
        } 
        else
        {
            Console.WriteLine("Something went wrong with input!");
            continue;
        }
    }

    Console.WriteLine(numbers.Length);
}
