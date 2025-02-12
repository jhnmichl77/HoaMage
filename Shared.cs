using System;
using System.Windows.Forms;

public class Shared : Form  // Ensure Shared is public
{
    public Shared()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        // Common settings for all forms
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
    }

    // Example shared method for all forms
    protected void ShowMessage(string message, string title = "Information")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
