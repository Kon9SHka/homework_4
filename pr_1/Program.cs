Console.Clear();

int first_number = GetNumberFromUser("Введите первое число: ");
int second_number = GetNumberFromUser("Введите второе число: ");
Console.WriteLine($"{DegreeResolution(first_number, second_number)}");


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

int DegreeResolution (int fp, int degree) 
{
    int result = fp;
    for (int i = 1; i < degree; i++) 
    {
        result = result * fp;
    }
    return result;
}