using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatMess = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                string[] info = input.Split();

                string command = info[0];

                /*
                   •	Chat {message} - add the message at last position in the chat
                    •	Delete {messageToDelete} - delete the message if it exists
                    •	Edit {messageToEdit} {editedVersion} - update the message with the edited version
                    •	Pin {message} - find the given message and move it to the last index
                    •	Spam {message1} {message2} {messageN} - add all messages at the end of the chat
                */

                if(command == "Chat")
                {
                    string message = info[1];

                    chatMess.Add(message);
                }
                else if(command == "Delete")
                {
                    string message = info[1];

                    if (chatMess.Contains(message))
                    {
                        chatMess.Remove(message);
                    }
                }
                else if(command == "Edit")
                {
                    string messageToEdit = info[1];
                    string edidetVersion = info[2];

                    if (chatMess.Contains(messageToEdit))
                    {
                        int index = chatMess.IndexOf(messageToEdit);

                        chatMess[index] = edidetVersion;
                    }
                }
                else if(command == "Pin")
                {
                    string message = info[1];

                    int index = chatMess.IndexOf(message);

                    if(index != -1)
                    {
                        chatMess.RemoveAt(index);
                        chatMess.Add(message);
                    }
                }
                else if(command == "Spam")
                {
                    for (int i = 1; i < info.Length; i++)
                    {
                        chatMess.Add(info[i]);
                    }
                }

            }

            Console.WriteLine(string.Join(Environment.NewLine, chatMess));
        }
    }
}
