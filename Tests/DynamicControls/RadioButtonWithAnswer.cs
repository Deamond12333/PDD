using System;
using System.Windows.Forms;

namespace Tests
{
    internal class RadioButtonWithAnswer : RadioButton
    {
        public Answer Answer { get; internal set; }
    }
}
