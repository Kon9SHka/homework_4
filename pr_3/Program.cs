Console.Clear();
int[] final_array = GetNumbersForArray(8);
FinalConclusion(final_array);

int[] GetNumbersForArray (int size) 
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(0,1000);
    }
    return array;
}

static void FinalConclusion (int[] array) 
{   
    string final_string = "";
    for (int i = 0; i<8; i++) 
    {   
        int current_number = array[i];
        if (i==7)
            {
                final_string = $"{final_string}{current_number}";
            }
        else {
            final_string = $"{final_string}{current_number}, ";
             }
    }
    Console.WriteLine($"[{final_string}]");
}