using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.ViewModels
{
    class WorkingMessage
    {
        public WorkingMessage(DateTime time, string status, string message)
        {
            this.Time = time;
            this.Status = status;
            this.Message = message;
        }

        public DateTime Time { get; set; }

        public string Status { get; set; }

        public string Message { get; set; }
    }
}
