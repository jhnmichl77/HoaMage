using System;
using System.Windows.Forms;

public partial class BaseForm : Form // Add partial
{
    public BaseForm() // Ensure there is a parameterless constructor
    {
        
    }

    protected void ShowMessage(string message)
    {
        MessageBox.Show(message);
    }
}
