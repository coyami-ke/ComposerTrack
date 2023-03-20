using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionCreator
{
    public enum MessageTypes
    {
        Info,
        Warn,
        Error,
    }
    public class MessageArgs : EventArgs
    {
        public MessageTypes MessageType;
        public string Message;
        public MessageArgs(MessageTypes type, string message)
        {
            MessageType = type;
            Message = message;
        }
    }
}
