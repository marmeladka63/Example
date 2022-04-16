int[] array={1,2,4,56,8,4,56,62,3};

int n=array.Length;
int find = 56;

int index =0;

while (index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}