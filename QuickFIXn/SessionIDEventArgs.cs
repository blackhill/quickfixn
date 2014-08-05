using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    public class SessionIDEventArgs : EventArgs
    {
        public SessionID SessionID { get; private set; }

        public SessionIDEventArgs(SessionID sessionId)
        {
            SessionID = sessionId;
        }
    }
}
