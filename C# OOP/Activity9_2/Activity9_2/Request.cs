using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9_2
{
    public class Request
    {
        string _requestor;
        int _priority;
        DateTime _date;

        public Request(string requestor, int priority, DateTime date)
        {
            this.Requestor = requestor;
            this.Priority = priority;
            this.Date = date;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", this.Requestor, this.Priority.ToString(), this.Date);
        }

        public string Requestor { get => _requestor; set => _requestor = value; }
        public int Priority { get => _priority; set => _priority = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
