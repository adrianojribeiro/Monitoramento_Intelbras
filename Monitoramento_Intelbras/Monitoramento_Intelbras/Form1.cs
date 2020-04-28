using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoramento_Intelbras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            Carrega_Camera();
        }

        public void Carrega_Camera()
        {
            try
            {
                int camera = Convert.ToInt32(txtcamera.Text);
                // string _rtspEndpoint = "rtsp://192.168.1.88:554/user=admin&password=g5a7b9t3&channel=1&stream=0.sdp?";

                string _rtspEndpoint = "rtsp://admin:g5a7b9t3@192.168.1.102:554/cam/realmonitor?channel=" + camera + "&subtype=0";
                axVLCPlugin21.playlist.add(_rtspEndpoint);
                axVLCPlugin21.playlist.play();             
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.stop_async();
            axVLCPlugin21.playlist.stop();      

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
