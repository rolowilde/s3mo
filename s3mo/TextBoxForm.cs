namespace s3mo;

public partial class TextBoxForm : Form
{
    readonly Predicate<string> _validate;

    public TextBoxForm(string label, Predicate<string> textValidate)
    {
        InitializeComponent();

        label1.Text = label;
        _validate = textValidate;
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        if (!_validate.Invoke(textBox.Text))
        {
            return;
        }

        DialogResult = DialogResult.OK;
        Close();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
