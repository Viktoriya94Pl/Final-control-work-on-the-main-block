void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void CreateNewArray(string[] array, string[] array2)
{
    int maxSynmol = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if(array[i].Length <= maxSynmol)
        {
          array2[count] = array[i];
          count++;
        }
    }
    
}

int FindSumElements (string[] array)
{
    int count = 0;
    int maxSynmol = 3;
    for (int i = 0; i < array.Length; i++)
    { 
        if(array[i].Length <= maxSynmol)
        {
          count++;
        }
    }return count;
}

void FinalTask()
{
string [] array = {"Hello","2","world","dr","-4","cat","dog","print","ty"};
int size = FindSumElements(array);
string [] array2 = new string [size];
CreateNewArray(array, array2);
PrintArray(array2);
}
FinalTask();
