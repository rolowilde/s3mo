using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s3mo
{
    public partial class TextBoxForm : Form
    {
        Predicate<string> _validate;

        public TextBoxForm(string label, Predicate<string> textValidate)
        {
            InitializeComponent();

            label1.Text = label;
            _validate = textValidate;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!_validate.Invoke(textBox.Text))
                return;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
