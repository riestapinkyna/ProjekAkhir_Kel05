using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2_UserControl_KEL05
{
    public partial class CharTextBoxt : TextBox
    {
        public CharTextBoxt()
        {
            InitializeComponent();
        }
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                try
                {
                    base.Text = value;
                    return;
                }
                catch { }
                if (value == null)
                {
                    base.Text = value;
                    return;
                }
            }
        }
        // Raising & Overriding onKeyPress Event
        public delegate void InvalidUserEntryEvent(Object sender, KeyPressEventArgs e);
        public event InvalidUserEntryEvent InvalidUserEntry;

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            int asciiInteger = Convert.ToInt32(e.KeyChar);
            if (asciiInteger == 32 || asciiInteger >= 65 && asciiInteger <= 122)
            {
                //if the value of the ASCII converted char type (e.Keychar) represents 0-9
                //pass the event to windwos for default processing
                e.Handled = false;
                return;
            }
            //if the value of te ASCII convertde char type(e.Keychar) reprents BACKSPACE
            //pass the event to windows for defaukt processing
            if (asciiInteger == 8)
            {
                e.Handled = false;
                return;
            }
            //if the value of the ASCII COnvrtde type (e.keycahr)
            //handle the event here bt setting handled=true
            //passed Widnows for default processing
            e.Handled = true;
            if (InvalidUserEntry != null)
                InvalidUserEntry(this, e);
        }
    }
}
