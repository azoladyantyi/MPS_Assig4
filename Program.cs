using System;

namespace Assignment_4
{
    class Program
    {
    
        static void Main(string[] args)
        {
          Console.WriteLine("Enter a word:");
          string input = Console.ReadLine();
           
          input = input.Replace(" ", string.Empty);
          

          while (input.Length>0)
          {
            int counter = 0;
              for (int i = 0; i < input.Length; i++)
              {
                  if (input[0] == input[i])
                  {
                      counter++;
                  }
              }
              Console.WriteLine(input[0]+":" + counter );
              input = input.Replace(input[0].ToString(), string.Empty); 
          }

        
               
            }
            
        }

}
