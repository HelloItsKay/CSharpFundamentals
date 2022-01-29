using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> usernameLikesCommentsDictionary = new Dictionary<string,int>();
            int folowers = 0;


            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Log")
                {
                    break;
                }

                if (command[0] == "New")
                {
                    string username = command[2];
                    if (!usernameLikesCommentsDictionary.ContainsKey(username))
                    {
                        usernameLikesCommentsDictionary.Add(username, 0);
                        folowers++;

                    }


                }

                else if (command[0] == "Like:")
                {
                    string usernameLikes = command[1];
                    usernameLikes = usernameLikes.Replace(":", "");
                    int count = int.Parse(command[2]);
                    if (!usernameLikesCommentsDictionary.ContainsKey(usernameLikes))
                    {
                        usernameLikesCommentsDictionary.Add(usernameLikes, count);

                    }
                    else
                    {
                        


                        try
                        {
                            usernameLikesCommentsDictionary.Add(usernameLikes, count);
                        }

                       

                    }
                }

                // }

                else if (command[0] == "Comment")
                    {

                    }
                    else if (command[0] == "Blocked")
                    {

                    }


                

                foreach (var item in usernameLikesCommentsDictionary)
                {

                }

                Console.WriteLine($@"{folowers} folowers");
            }
        }
    }
}
