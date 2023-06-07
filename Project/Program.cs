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

void FinalTask()
{
string [] array = {"Hello","2","world",")","-4","cat","dog","print"};
string[] array2 = new string[array.Length];
CreateNewArray(array, array2);
PrintArray(array2);
}
FinalTask();
