using System;
using System.Collections.Generic;
namespace collection_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array to hold from 0 to 9
            int [] array_num={1,2,3,4,5};
            Console.WriteLine(array_num[0]);

            //String Array
            string [] names={"Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine(names[0]);

            //length 10 that alternates between true and false
            int [] num={1,2,3,4,5,6,7,8,9,10};
            for(int m=0; m < num.Length; m++)
            {
                if(num[m] %2 != 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }

            //a list of ice cream flavors that holds at least 5 different flavors 
           List<string> ice_cream = new List<string>();
            ice_cream.Add("a");
            ice_cream.Add("b");
            ice_cream.Add("c");
            ice_cream.Add("d");
            ice_cream.Add("e");
            
            for(int variable=0; variable < ice_cream.Count; variable++)
            {
                Console.WriteLine(ice_cream[variable]);
            }
            //length of this list
            Console.WriteLine(ice_cream.Count);

            //Output the third flavor in the list, then remove this value
            Console.WriteLine(ice_cream[2]);
            ice_cream.RemoveAt(2);

            for(int variable=0; variable < ice_cream.Count; variable++)
            {
                Console.WriteLine(ice_cream[variable]);
            }
            //Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(ice_cream.Count);

            Dictionary<string,string> profile = new Dictionary<string,string>();
            foreach (var name in names)
            {
                profile.Add(name,null);
            }
            Random rand = new Random();
            
            foreach (var keypair in profile)
            {
                profile[keypair.Key]=ice_cream[rand.Next(ice_cream.Count)];  
            }
        }
    }
}
