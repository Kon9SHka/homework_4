Console.Clear();

int first_number = GetNumberFromUser("Введите число: ");
Console.WriteLine($"{SumResolution(first_number)}");


int GetNumberFromUser (string message) 
{
    while(true) 
    {

    Console.Write(message);
    bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
    while(isCorrect)
        return number;
    Console.WriteLine("Ошибка ввода!");

    }
}

int SumResolution (int number) 
{
    int result = 0;
    int current_number = number;
    while(current_number > 0) 
    {
        result = result + (current_number%10);
        current_number = current_number/10;
    }
    return result;
}