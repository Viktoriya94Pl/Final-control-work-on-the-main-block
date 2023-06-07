void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void CreateNewArray(string[] array, string [] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if(array[i].Length <=3)
        {
          array2[count] = array[i];
          count++;
        }
    }
    
}
