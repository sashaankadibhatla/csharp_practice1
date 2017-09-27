using System;
 
 namespace program2{
public class Tom_Jerry{

    public void Tom_Jerry_fun(int number){
            if(number%2!=0 &&number>20&&number<30)
                Console.WriteLine("tom");
            if(number%2==0 &&number>20&&number<30)
                Console.WriteLine("jerry");
    }

}
 }