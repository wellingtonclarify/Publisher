using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publisher.Core.Helpers
{
    public static class MessageHelper
    {
        public static DialogResult Info(string message, string caption = "Info")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Warning(string message, string caption = "Warning")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult Error(string message, string caption = "Error")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Question(string message, string caption = "Question", MessageBoxButtons buttons = MessageBoxButtons.YesNo)
        {
            return MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
        }
    }
}
