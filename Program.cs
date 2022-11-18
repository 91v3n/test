string[] FillArray(string[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.Write("введите значение ");
        A[i] = Console.ReadLine();
    }
    return A;
}

void PrintArray(string[] A)
{
    for (int i = 0; i < A.Length; i++) Console.Write($"{A[i]} ");
    Console.WriteLine();
}

string[] CutArray(string[] A, string[] B)
{
    int c = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i].Length <= 3)
        {
            B[c] = A[i];
            c++;
        }
    }
    return B;
}


Console.Write ("введите размер массива ");
int lng = Convert.ToInt32(Console.ReadLine()); 

string[] A = new string[lng];
string[] B = new string[lng];

A = FillArray(A);
PrintArray(A);
B = CutArray(A, B);
PrintArray(B);