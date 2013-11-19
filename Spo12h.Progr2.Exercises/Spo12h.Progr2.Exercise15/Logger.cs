using System.Collections.Generic;

namespace Spo12h.Progr2.Exercise15
{
    public class Logger
    {
        private List<string> messages;

        /// <summary>
        /// Returns the list of messages in the logger class
        /// </summary>
        public List<string> LogPosts { get { return messages; } }

        /// <summary>
        /// Constructor
        /// </summary>
        public Logger()
        {
            messages = new List<string>();
        }

        /// <summary>
        /// Add a message to the log
        /// </summary>
        /// <param name="message">The log message</param>
        public void Log(string message)
        {
            messages.Add(message);
        }
    }
}