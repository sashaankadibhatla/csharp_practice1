using System;

namespace program3{
    public class vowel_consonant{
        public void vowel_consonant_fun(string sequence){
                int i;
                int l=sequence.Length;
                for(i=0;i<l;i++)
                {
                    if(sequence[i]=='a'||sequence[i]=='e'||sequence[i]=='i'||sequence[i]=='o'||sequence[i]=='u'
                        || sequence[i]=='A'||sequence[i]=='E'||sequence[i]=='I'||sequence[i]=='O'||sequence[i]=='U'){
                            Console.Write("{0}-Vowel ",sequence[i]);
                        }
                    else Console.Write("{0}-Consonant ",sequence[i]);
                }
                Console.WriteLine("");
        }
    } 
}