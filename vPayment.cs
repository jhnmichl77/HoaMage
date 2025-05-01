using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class vPayment : MaterialForm
    {
        private int violatorID;
        public vPayment(int vId)
        {
            InitializeComponent();
            Shared.Set(this);
            GenerateQRCode(paymentLink);
            violatorID = vId;
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
            if (pbxProof.Image == null)
            {
                MessageBox.Show("Please attach a proof of payment image before proceeding.", "Missing Proof", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbxProof.Image.Save(ms, pbxProof.Image.RawFormat);
                    byte[] imageBytes = ms.ToArray();

                    using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.myConn))
                    {
                        conn.Open();

                        string updateQuery = @"UPDATE Violators 
                                       SET Status = 'Paid', ProofImage = ? 
                                       WHERE ID = ?";

                        using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                        {
                            cmd.Parameters.Add("?", OleDbType.LongVarBinary).Value = imageBytes;
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = violatorID;

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Payment and proof uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payment and image:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Select an Image",
                Filter = "Image Files|*.jpg;*.JPEG;*.png;*.bmp;*.jfif"
            })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    pbxProof.ImageLocation = openFile.FileName;
                }
            }
        }
    }
}
