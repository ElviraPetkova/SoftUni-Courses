namespace OnlineRadioDatabase.Exceptions
{
    using System;

    public class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException(string message = "Invalid song length.") 
            : base(message)
        {
        }
    }
}
