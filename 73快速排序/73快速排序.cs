// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] a = new int[] { 9, 10, 7, 6, 8, 5, 19 };
Sort_Fast(ref a);

Console.ReadKey();
static void Sort_Fast(ref int[] array)
{

    void Sort(ref int[] array,int l,int r)
    {
        if (l>=r)
        {
            return;
        }

        int point = l;
        int point_Value = array[l];

        while (l < r)
        {
            while(r>l && array[r] > point_Value)
            {
                r--;
            }

            array[l] = array[r];

            if (l<r)
            {
                l++;
            }  

            while (l<r && array[l] < point_Value)
            {
                l++;
            }
            array[r] = array[l];
            if (r>l)
            {
                r--;
            }
        }

        array[l] = point_Value;

        if (l==r&&l ==0)
        {
            return;
        }

        Sort(ref array, 0, l-1);
        Sort(ref array, l,array.Length-1);
    }

    Sort(ref array, 0, array.Length-1);
}   