using over.Views.ModuloControles.ModuloControleVendas;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace over {
    public partial class PixCode : Form {

        private string pixcode;
        private int segundos = 0;
        public static bool status;
        public PixCode(decimal total)
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);
            labelTotal.Text = $"Valor Total\nR$ {total}";
            labelInstrucoes.Text = "1. Abra seu aplicativo de banco.\n2. Selecione a opção PIX por QR Code\n3. Escaneie o código acima para finalizar.";
        }

        private void GeneratePixQrCode(string pixCode)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(pixCode, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);

                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                Bitmap resizedQRCode = new Bitmap(qrCodeImage, new Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height));

                pictureBoxQRCode.Image = resizedQRCode;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string pixCode = "00020126580014BR.Mania.MORANGO.PIX0136key@pix.com520400005303986540510.005802BR5909Cliente6008SaoPaulo62070503***6304B1C7";
            this.pixcode = pixCode;
            GeneratePixQrCode(pixCode);
        }

        private void buttonGerarCodigoPix_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pixcode);
            MessageBox.Show("Código PIX copiado com sucesso!", "Solicitação feita com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PixCode_Load(object sender, EventArgs e)
        {

        }

        private void labelPagamentoRealizado_Click(object sender, EventArgs e)
        {
            labelPagamentoRealizado.Text = "Confirmando seu pagamento, por favor aguarde";
            pictureLoading.Visible = true;
            timerLoading.Tick += TimerLoading_Tick;
            timerLoading.Start();
        }

        private void TimerLoading_Tick(object sender, EventArgs e)
        {
            segundos++;

            if (segundos >= 5)
            {
                timerLoading.Stop();
                status = true;
                this.Close();
            }
        }
    }
}
