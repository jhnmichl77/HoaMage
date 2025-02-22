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

    public void ShowUserControl(UserControl userControl, Panel panel)
    {
        panel.Controls.Clear();
        userControl.Dock = DockStyle.Fill;
        panel.Controls.Add(userControl);
    }
    protected void ShowMessage(string message, string title = "Information")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


}
