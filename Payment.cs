using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using QRCoder;

namespace HoaMage
{
    public partial class Payment : MaterialForm
    {
        public Payment(string reference, string billedto, string amount, string description)
        {
            InitializeComponent();
            Shared.Set(this);
            GenerateQRCode(paymentLink);
        }
        string paymentLink = "https://s.binance.com/5ZziOxeo";
        private void GenerateQRCode(string data)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            pbxQR.Image = qrCodeImage;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            
        }

    }
}
