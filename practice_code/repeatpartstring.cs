using System;

namespace program6{

    public class repeatpart{

        public void repeatpart_fun(string sequence,int number){
            int l=sequence.Length;
            int i,j;
            Console.Write(sequence);
            for(j=0;j<number;j++)
            {
            for(i=l-number;i<l;i++){
                Console.Write(sequence[i]);

            }
        }
        Console.WriteLine("");
    }
    }
}