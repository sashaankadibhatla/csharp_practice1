using System;

namespace palindrome_program{
    
    public class palindrome{
        public int palindrome_fun(string sequence){
            int l=sequence.Length;
            int []array=new int[l];
            int sum=0;
            char []chararray=sequence.ToCharArray();
            Array.Reverse(chararray);
            string newsequence= new string(chararray);
            bool result=Array.Equals(sequence,newsequence);
            int i;
            for(i=0;i<l;i++)
                array[i]=sequence[i]-'0';
            for(i=0;i<l;i++){
                if(array[i]%2==0)
                sum+=array[i];
            }
            
            if(result==true&&sum<25)
                Console.WriteLine("palindrome and sum of even numbers is less than 25");
            else if(result==true&&sum>25)
                Console.WriteLine("palindrome and sum of even number is greater than 25");
            else 
                Console.WriteLine("not a palindrome");
            
            return sum;
        }
    }
}

