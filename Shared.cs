using HoaMage;
using System;
using System.Windows.Forms;

public class Shared : Form
{
    public Shared()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
    }

    public static void ShowUserControl(UserControl userControl, Control parent)
    {
        if (parent is Panel panel2)
        {
            panel2.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(userControl);
        }
    }

    protected void ShowMessage(string message, string title = "Information")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


}
