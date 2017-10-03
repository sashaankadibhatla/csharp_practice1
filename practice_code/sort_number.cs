using System;

namespace program5{

    public class sort_number{
        public int sort_number_fun(string sequence){
            int l=sequence.Length;
            int i,sum=0;
            int []array=new int[l];
            for(i=0;i<l;i++)
                array[i]=sequence[i]-'0';
            Array.Sort(array);
            Array.Reverse(array);
            for(i=0;i<l;i++)
            {
                if(array[i]%2==0){
                    sum+=array[i];
                }
            }
        Console.Write("Sorted number in non-increasing order: ");
        for(i=0;i<l;i++){
            Console.Write("{0} ",array[i]);
        }
        Console.WriteLine("\nSum of even numbers: {0} ",sum);
        if(sum>15){
            Console.WriteLine("True");
        }
        if(sum<15){
            Console.WriteLine("False");
        }
        return sum;

        }
    }
}