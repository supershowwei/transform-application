using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransformApplication.Utilities
{
    static class Extension
    {
        /// <summary>
        /// 若有需要的話，做援引呼叫。
        /// </summary>
        /// <param name="control"></param>
        /// <param name="action"></param>
        public static void InvokeIfNecessary(this System.Windows.Forms.Control control, MethodInvoker action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
