using System;

namespace program4{
    public class loop{
        public void loop_fun(int number)
        {
            int i;
            for(i=1;i<=number;i++){
                for(int j=1;j<=i;j++)
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine("");
        }
    }
}