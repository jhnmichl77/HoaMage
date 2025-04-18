﻿using HoaMage;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public static void Set(MaterialForm form)
    {
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(form);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
    }
    public static class Identification
    {
        public static string Username { get; set; }
        public static int AccountID { get; set; }
        public static string Role { get; set; }
        public static int PropertyID { get; set; }
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
    public static string uploadImage()
    {
        using (OpenFileDialog openFile = new OpenFileDialog
        {
            Title = "Select an Image",
            Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        })
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                return openFile.FileName; 
            }
        }
        return null;
    }
    public static Image LoadImage(string imagePath)
    {
        if (!string.IsNullOrEmpty(imagePath))
        {
            return Image.FromFile(imagePath); 
        }
        return null; 
    }
}
