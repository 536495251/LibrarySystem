using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemVersion2
{
    internal class Message
    {
        public int messageid;
        public string message;
        public int userid;
        public DateTime datetime;
        public Message() { }
        public Message( string message, int userid, DateTime datetime)
        {
            this.message = message;
            this.userid = userid;
            this.datetime = datetime;
        }
        public Message( int messageid, string message, int userid, DateTime datetime)
        {   this.messageid = messageid;
            this.message = message;
            this.userid = userid;
            this.datetime = datetime;
        }
    }
}
