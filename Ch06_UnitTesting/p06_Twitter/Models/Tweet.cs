﻿namespace p06_Twitter.Models
{
    using Interfaces;

    class Tweet : IMessage
    {
        public Tweet(string messageContent)
        {
            this.Content = messageContent;
        }

        public string Content { get; private set; }
    }
}
