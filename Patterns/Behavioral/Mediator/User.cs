﻿namespace Mediator
{
    public class User
    {
        private readonly string _name;
        private readonly IChatRoom _chatRoom;

        public User(string name, IChatRoom chatRoom)
        {
            _name = name;
            _chatRoom = chatRoom;
        }

        public string GetName()
        {
            return _name;
        }

        public void SendMessage(string message)
        {
            _chatRoom.ShowMessage(this, message);
        }
    }
}