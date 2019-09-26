using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayLearn
{
    class Program
    {// this is part of the new features wooooo!
        static void Main(string[] args)
        {
            //Step 1: Read in Name Files in Array
            string[] Names = File.ReadAllLines(@"Names.txt", Encoding.UTF8);//the names of the people who have birthdays

            //Step 2: Read in Statements 
            string[] BirthdayStatements = File.ReadAllLines(@"BirthdayStatements.txt", Encoding.UTF8);// the birthday statements we wanna use
            int count = BirthdayStatements.Length;//how many birthday statements there are to choose from.

            string[] NewBirthdayStatements = new string[Names.Length];// where the update birthday statements go

            Random r = new Random(); //get a new random object. It's outside for loop so it can actually randomize properly. See definition for more details

            for (int x = 0; x < Names.Length; x++)//go through each name and do the below stuff with it. x is the current iteration count. It counts up with every loop until the condition is no longer met
            {

                int index = r.Next(0, count);  //tell it to pick a name between 0 and whatever count is. if Count is 6 then choose either 0,1,2,3,4, or 5
                string statement = BirthdayStatements[index];// grab the statement that is located at the randomly chosen index
                string name = Names[x]; // gets name we want to replace with from Names array
                ////Step 4: Replace Placeholder "Name" in Statement With a Name
                string UpdatedStatement = statement.Replace("{Name}", name);   // everytime you see the "{Name]" placeholder, replace it with name
                NewBirthdayStatements[x] = UpdatedStatement;// place new statement inside New BirthdayStatements array. 

            }     
            // another change!
            //Step 5: Output Updated Statement into a File
            File.AppendAllLines(@"NewBirthdayStatments.txt", NewBirthdayStatements, Encoding.UTF8);// push new birthday statement array into txt file


        }
    }
}
