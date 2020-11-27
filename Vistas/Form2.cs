using PdD.FFMPEG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdD.Vistas
{
    public partial class Form2 : Form
    {
        private OpenFileDialog ventana;
        private string ruta;

        private void Comando(string input, string outputFile)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "ffmpeg.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = $"-i {input} {outputFile}";
            using (Process exeProcess = Process.Start(startInfo)) ;
            {

            }
        }
        public void Comando2(string input, string outputFile)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "ffmpeg.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = $"-i {input} -an -vcodec copy {outputFile}";
            using (Process exeProcess = Process.Start(startInfo)) ;
            {

            }
        }

        public Form2()
        {
            InitializeComponent();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            this.Hide();
        }
      
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            ventana = new OpenFileDialog();
            ventana.InitialDirectory = "C:\\Users\\Usuario\\source\\repos\\PdD\\Videos";
            ruta = ventana.FileName;


            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                //Codigo para abrir y leer el archivo
                txtUbicacion.Text = openFileDialog1.FileName;
            }

        }
        private void txtUbicacion_TextChanged(object sender, EventArgs e)
        {

        }

        // EXTRAER EL AUDIO //
        private void btnCargar2_Click(object sender, EventArgs e)
        {

            string output = @"SinAudioEj1.mp4";
            Comando2("ejemplo1.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string output = @"SinAudioEj2.mp4";
            Comando2("ejemplo2.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string output = @"SinAudioEj3.mp4";
            Comando2("ejemplo3.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }

        // CONVERTIR EN GIF //
        private void btnCargar3_Click(object sender, EventArgs e)
        {
            string output = @"Gifej1.mp4";
            Comando("ejemplo1.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string output = @"Gifej2.mp4";
            Comando("ejemplo2.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string output = @"Gifej3.mp4";
            Comando("ejemplo3.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }

        // CAMBIAR DE FORMATO //
        private void btnCargar1_Click(object sender, EventArgs e)
        {
            string output = @"FormatoNuevoej1.avi";
            Comando("ejemplo1.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string output = @"FormatoNuevoej1.mpeg";
            Comando("ejemplo1.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string output = @"FormatoNuevoej1.flv";
            Comando("ejemplo1.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            string output = @"FormatoNuevoej2.avi";
            Comando("ejemplo2.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string output = @"FormatoNuevoej2.mpeg";
            Comando("ejemplo2.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string output = @"FormatoNuevoej2.flv";
            Comando("ejemplo2.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            string output = @"FormatoNuevoej3.avi";
            Comando("ejemplo3.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            string output = @"FormatoNuevoej3.mpeg";
            Comando("ejemplo3.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            string output = @"FormatoNuevoej3.flv";
            Comando("ejemplo3.mp4", output);
            Process.Start("powershell.exe", "/select, \"" + output + "\"");
        }
    }
    }
    

