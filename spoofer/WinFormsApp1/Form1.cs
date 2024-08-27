using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Criar um processo para o cmd
            Process processo = new Process();

            // Configurar as propriedades do processo
            processo.StartInfo.FileName = "cmd.exe";
            processo.StartInfo.UseShellExecute = false;
            processo.StartInfo.RedirectStandardInput = true;
            processo.StartInfo.RedirectStandardOutput = true;
            processo.StartInfo.CreateNoWindow = true; // Não exibir a janela do cmd

            // Iniciar o processo
            processo.Start();

            // Enviar o comando ipconfig para o cmd
            processo.StandardInput.WriteLine("ipconfig");

            // Fechar a entrada padrão do cmd para indicar que não há mais entrada
            processo.StandardInput.Flush();
            processo.StandardInput.Close();

            // Ler a saída do cmd
            string output = processo.StandardOutput.ReadToEnd();

            // Fechar o processo
            processo.WaitForExit();
            processo.Close();

            // Exibir a saída em um MessageBox (apenas para exemplo)
            MessageBox.Show(output, "Resultado do ipconfig");



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Criar um processo para o cmd
            Process processo = new Process();

            // Configurar as propriedades do processo
            processo.StartInfo.FileName = "cmd.exe";
            processo.StartInfo.UseShellExecute = false;
            processo.StartInfo.RedirectStandardInput = true;
            processo.StartInfo.CreateNoWindow = false;

            // Iniciar o processo
            processo.Start();


            processo.StandardInput.WriteLine("DEL %HOMEPATH%\\Config~1\\Temp\\*.* /F /S /Q");
            processo.StandardInput.WriteLine("DEL C:\\WINDOWS\\Temp\\*.* /F /S /Q");
            processo.StandardInput.WriteLine("DEL C:\\WINDOWS\\Prefetch\\*.* /F /S /Q");
            processo.StandardInput.WriteLine("DEL \"%WINDIR%\\Tempor~1\\*.*\" /F /S /Q ");
            processo.StandardInput.WriteLine("RD \"%HOMEPATH%\\Config~1\\Temp\" /S /Q");
            processo.StandardInput.WriteLine("MD \"%HOMEPATH%\\Config~1\\Temp\"");
            processo.StandardInput.WriteLine("RD C:\\WINDOWS\\Temp\\ /S /Q");
            processo.StandardInput.WriteLine("MD C:\\WINDOWS\\Temp");
            processo.StandardInput.WriteLine("RD C:\\WINDOWS\\Prefetch\\ /S /Q");
            processo.StandardInput.WriteLine("MD C:\\WINDOWS\\Prefetch");

            processo.StandardInput.Close();
            processo.WaitForExit();
            processo.Close();

            MessageBox.Show("Spoof Concluido!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Criar um processo para o cmd
            Process processo = new Process();

            // Configurar as propriedades do processo
            processo.StartInfo.FileName = "cmd.exe";
            processo.StartInfo.UseShellExecute = false;
            processo.StartInfo.RedirectStandardInput = true;
            processo.StartInfo.RedirectStandardOutput = true;
            processo.StartInfo.CreateNoWindow = true; // Não exibir a janela do cmd

            // Iniciar o processo
            processo.Start();

            // Enviar o comando ipconfig para o cmd
            processo.StandardInput.WriteLine("wmic path win32_computersystemproduct get uuid");

            // Fechar a entrada padrão do cmd para indicar que não há mais entrada
            processo.StandardInput.Flush();
            processo.StandardInput.Close();

            // Ler a saída do cmd
            string output = processo.StandardOutput.ReadToEnd();

            // Fechar o processo
            processo.WaitForExit();
            processo.Close();

            // Exibir a saída em um MessageBox (apenas para exemplo)
            MessageBox.Show(output, "UUID");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Criar um processo para o cmd
            Process processo = new Process();

            // Configurar as propriedades do processo
            processo.StartInfo.FileName = "cmd.exe";
            processo.StartInfo.UseShellExecute = false;
            processo.StartInfo.RedirectStandardInput = true;
            processo.StartInfo.RedirectStandardOutput = true;
            processo.StartInfo.CreateNoWindow = true; // Não exibir a janela do cmd

            // Iniciar o processo
            processo.Start();

            // Enviar o comando ipconfig para o cmd
            processo.StandardInput.WriteLine("wmic baseboard get product, serialnumber, version");

            // Fechar a entrada padrão do cmd para indicar que não há mais entrada
            processo.StandardInput.Flush();
            processo.StandardInput.Close();

            // Ler a saída do cmd
            string output = processo.StandardOutput.ReadToEnd();

            // Fechar o processo
            processo.WaitForExit();
            processo.Close();

            // Exibir a saída em um MessageBox (apenas para exemplo)
            MessageBox.Show(output, "Baseboard SERIAL/VERSION/PRODUCT");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Criar um processo para o cmd
            Process processo = new Process();

            // Configurar as propriedades do processo
            processo.StartInfo.FileName = "cmd.exe";
            processo.StartInfo.UseShellExecute = false;
            processo.StartInfo.RedirectStandardInput = true;
            processo.StartInfo.RedirectStandardOutput = true;
            processo.StartInfo.CreateNoWindow = true; // Não exibir a janela do cmd

            // Iniciar o processo
            processo.Start();

            // Enviar o comando ipconfig para o cmd
            processo.StandardInput.WriteLine("wmic diskdrive get model,serialNumber,size,mediaType");

            // Fechar a entrada padrão do cmd para indicar que não há mais entrada
            processo.StandardInput.Flush();
            processo.StandardInput.Close();

            // Ler a saída do cmd
            string output = processo.StandardOutput.ReadToEnd();

            // Fechar o processo
            processo.WaitForExit();
            processo.Close();

            // Exibir a saída em um MessageBox (apenas para exemplo)
            MessageBox.Show(output, "DISK MODEL/SERIAL/SIZE/MEDIATYPE");
        }
    }
}
