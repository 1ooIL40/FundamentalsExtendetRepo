namespace _06.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class User
    {
        public string Name { get; set; }

        public List<Message> ReceivedMessages { get; set; }
    }

    public class Message
    {
        public string Content { get; set; }

        public string Sender { get; set; }
    }

    public class Messages
    {
        public static void Main()
        {

          // 60/100 judge

            List<User> registeredUsers = new List<User>();
            List<Message> registeretdMeseges = new List<Message>();

            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);


            while (input[0] != "exit")
            {
                #region Register the usersrs and take the messeges
                if(input[0] == "register")
                {
                    User newUser = new User()
                    {
                        Name = input[1],
                        ReceivedMessages = new List<Message>()
                    };
                    registeredUsers.Add(newUser);
                }
                else 
                {
                    //Chek did we have the recipient for the messeges
                    for (int i = 0; i < registeredUsers.Count; i++)
                    {
                        if (registeredUsers[i].Name.Contains(input[2]))
                        {
                            Message newMessage = new Message()
                            {
                                Sender = input[0],

                                Content = input[3]
                            };
                            registeretdMeseges.Add(newMessage);
                        }
                    }
                }
#endregion

                input = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            }
            #region Add the sender and the message
            //Add the Sender and the message send to the registeredUser.ReceivedMessages
            foreach (var user in registeredUsers)
            {
                foreach (var msg in registeretdMeseges)
                {
                    if (user.Name.Contains(msg.Sender))
                    {
                        user.ReceivedMessages.Add(msg);
                    }
                }
            }
#endregion

            input = Console.ReadLine()
               .Split(new char[] { ' ' },
               StringSplitOptions.RemoveEmptyEntries);

            string firstUserName = input[0];
            string secondUserName = input[1];

            List<string> names = new List<string>();

            bool areUsersRegistered = false;

            #region Get the registeret name and find if we have machest with the input
            //Get all names that we have in list
            foreach (var user in registeredUsers)
            {
                names.Add(user.Name);
            }

            if (input.Length >= 1)
            {
                //Chek if we have the name to start the chat
                if (names.Contains(firstUserName) && names.Contains(secondUserName))
                {
                    areUsersRegistered = true;
                }
            }

            #endregion



            if (areUsersRegistered)
            {

                //Find if there are messeges between the both of them
                bool haveMeseges = false;

                if (registeredUsers.Find(u => u.Name == firstUserName)
                    .ReceivedMessages.Count() > 0 &&
                    registeredUsers.Find(u => u.Name == secondUserName)
                    .ReceivedMessages.Count() > 0)
                {
                    haveMeseges = true;
                }

                if (haveMeseges)
                {


                    List<Message> nameOneChat = registeredUsers
                        .Find(u => u.Name == firstUserName)
                        .ReceivedMessages
                        .Where(m => m.Sender == firstUserName)
                        .ToList();
                    List<Message> nameTwoChat = registeredUsers
                        .Find(u => u.Name == secondUserName)
                        .ReceivedMessages
                        .Where(m => m.Sender == secondUserName)
                        .ToList();

                    
                    ////Get the chat in separeted lists
                    //foreach (var person in registeredUsers)
                    //{
                    //    if(person.Name == firstUserName)
                    //    {
                    //        nameOneChat = person.ReceivedMessages;
                    //    }

                    //    if(person.Name == secondUserName)
                    //    {
                    //        nameTwoChat = person.ReceivedMessages;
                    //    }
                    //}

                    ////Get the max lenght and print all messeges in order
                    int lenghtOfTheChat = Math.Max(nameOneChat.Count, nameTwoChat.Count);

                    for (int i = 0; i < lenghtOfTheChat; i++)
                    {
                        if (i < nameOneChat.Count)
                        {
                            Console.WriteLine($"{firstUserName}: {nameOneChat[i].Content}");
                        }
                        if (i < nameTwoChat.Count)
                        {
                            Console.WriteLine($"{nameTwoChat[i].Content} :{secondUserName}");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("No messages");
                }
               
            }
            else
            {
                return;
            }
        }
    }
}
