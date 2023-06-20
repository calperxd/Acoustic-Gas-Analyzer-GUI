using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Threading;
using System.IO;
using MathNet.Numerics;
using System.Numerics;
using MathNet.Numerics.IntegralTransforms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;
using Microsoft.Extensions.Primitives;
using System.Text.RegularExpressions;
using System.Threading;
using System.Drawing;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private string dataIn;
        List<string> list = new List<string>();
        private int FileIndexCounter = 0;
        private MemoryStream ms = new MemoryStream();
        // Create a new instance of Windows Media Player
        private WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
        private BinaryWriter bw;
        private string tempFile = Path.GetTempFileName();
        private float angularCoef = 0;
        private float linearCoef = 0;
        private double vel = 0;


        public Form1()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += timer_Tick;
            timer.Start();
            // Initialize the BinaryWriter with the MemoryStream
            bw = new BinaryWriter(ms, System.Text.Encoding.UTF8, true);
            scrllVolume.Value = 50;
            vScrollBarVolumeSenoidal.Value = 50;
            player.settings.volume =scrllVolume.Value;
            wmp.settings.volume = vScrollBarVolumeSenoidal.Value;

            Image image = Properties.Resources.Cota;
            int novaLargura = 500;
            int novaAltura = (int)(image.Height * ((float)novaLargura / (float)image.Width));
            Image novaImagem = image.GetThumbnailImage(novaLargura, novaAltura, null, IntPtr.Zero);
            pictureBox1.Image = novaImagem;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            player.settings.volume = (int)((scrllVolume.Maximum - scrllVolume.Value)*1.2);
            wmp.settings.volume = (int)((int)(vScrollBarVolumeSenoidal.Maximum - vScrollBarVolumeSenoidal.Value)*1.5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbPort.Items.AddRange(ports);
            btnClose.Enabled = false;
            btnDownload.Enabled = true;
            btnAmostragem.Enabled = false;
            txtTime.Enabled = false;
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            stopAmostragem.Enabled = false; 
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try 
            {
                serialPort1.PortName = cbPort.Text;
                serialPort1.BaudRate = 921600;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Open();
                serialPort1.DiscardInBuffer();  // Limpa o buffer de recepção
                serialPort1.DiscardOutBuffer(); // Limpa o buffer de transmissão
                if (serialPort1.IsOpen)
                {
                    btnClose.Enabled = true;
                    btnDownload.Enabled = true;
                    btnOpen.Enabled = false;
                    btnAmostragem.Enabled = true;
                    txtTime.Enabled = true;
                    btnPlus.Enabled = true;
                    btnMinus.Enabled = true;
                    cbPort.Enabled = false;
                    stopAmostragem.Enabled = true;
                }
                
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                btnClose.Enabled = false;
                btnDownload.Enabled = false;
                btnOpen.Enabled = true;
                btnAmostragem.Enabled = false;
                txtTime.Enabled = false;
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                cbPort.Enabled = true;
                stopAmostragem.Enabled = false;
                serialPort1.Close();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.URL = "C:\\Users\\Galc_\\OneDrive\\UTFPR\\TCC\\GUI\\WindowsFormsApp1\\white-noise.mp3";
            player.controls.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void btnAmostragem_Click(object sender, EventArgs e)
        {
            dataIn = "";
            list.Clear();
            serialPort1.DiscardInBuffer();  // Limpa o buffer de recepção
            serialPort1.DiscardOutBuffer(); // Limpa o buffer de transmissão
            StringBuilder sb = new StringBuilder();
            sb.Append("#START#");
            sb.Append("#" + int.Parse(txtTime.Text).ToString("00") + "#");
            sb.Append("#NA#");
            serialPort1.Write(sb.ToString());
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("#PLUS##NA##NA#");
            serialPort1.Write(sb.ToString());
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("#MINUS##NA##NA#");
            serialPort1.Write(sb.ToString());
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn += serialPort1.ReadExisting();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // Verifica se dataIn está vazio
            if (string.IsNullOrEmpty(dataIn))
            {
                // Se estiver vazio, exibe uma mensagem para o usuário e retorna
                MessageBox.Show("Não há dados disponíveis para serem salvos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
            saveFileDialog.Title = "Save data file";
            saveFileDialog.FileName = $"Amostra{FileIndexCounter}.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string strWorkPath = saveFileDialog.FileName;
                string[] arrayOfSamples = dataIn.Split('\n');
                string[] updatedArray = Array.ConvertAll(arrayOfSamples, s => s.Replace("\r", ""));
                list.AddRange(updatedArray);
                File.WriteAllLines(strWorkPath, list);
                list.Clear();
                dataIn = "";
            }
        }


        private void btnPlaySenoidal_Click_1(object sender, EventArgs e)
        {
            int frequencia = int.Parse(txtFreqInputSenoidal.Text); // frequência em Hz
            int duracao = int.Parse(txtDuracaoInputSenoidal.Text) * 1000; // duração em milissegundos
            int volume = (((vScrollBarVolumeSenoidal.Maximum - vScrollBarVolumeSenoidal.Value))); // volume em uma escala de 0 a 100
            int amostras = duracao * 44100 / 1000; // número de amostras a serem geradas
            double[] dados = new double[amostras]; // array para armazenar os dados do som


            for (int i = 0; i < amostras; i++)
            {
                double tempo = (double)i / 44100.0; // tempo em segundos desde o início da onda
                double valor = Math.Sin(2 * Math.PI * frequencia * tempo); // valor da onda em cada amostra
                dados[i] = valor;
            }

            byte[] bytes = new byte[amostras * 2]; // array para armazenar os dados em formato PCM
            for (int i = 0; i < amostras; i++)
            {
                short valorPCM = (short)(dados[i] * 32767.0 * volume / 100.0); // converter o valor da onda para o formato PCM de 16 bits
                BitConverter.GetBytes(valorPCM).CopyTo(bytes, i * 2); // copiar os bytes do valor para o array de bytes
            }

            if (!ms.CanWrite)
            {
                // The MemoryStream has been closed or disposed, so create a new one
                ms = new MemoryStream();
            }

            if (!bw.BaseStream.CanWrite)
            {
                bw = new BinaryWriter(ms);
            }

            bw.Write(new char[] { 'R', 'I', 'F', 'F' });
            bw.Write(36 + bytes.Length);
            bw.Write(new char[] { 'W', 'A', 'V', 'E', 'f', 'm', 't', ' ' });
            bw.Write(16);
            bw.Write((short)1);
            bw.Write((short)1);
            bw.Write(44100);
            bw.Write(44100 * 2);
            bw.Write((short)2);
            bw.Write((short)16);
            // Escreva o cabeçalho dos dados e os dados PCM
            bw.Write(new char[] { 'd', 'a', 't', 'a' });
            bw.Write(bytes.Length);
            bw.Write(bytes);

            // Escreva o cabeçalho WAVE
            ms.Seek(0, SeekOrigin.Begin);

            // Create a temporary file with the wave data

            File.WriteAllBytes(tempFile, ms.ToArray());

            // Load the temporary file into Windows Media Player
            wmp.URL = tempFile;

            // Play the audio
            wmp.controls.play();

            // Cleanup the temporary file
            wmp.PlayStateChange += (newState) =>
            {
                if ((WMPLib.WMPPlayState)newState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    File.Delete(tempFile);
                }
            };
            ms.Dispose();
            bw.Flush();
        }


        private void stopAmostragem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("#STOP##NA##NA#");
            serialPort1.Write(sb.ToString());
        }

        private void btnStopSenoidal_Click(object sender, EventArgs e)
        {
            // Cleanup the temporary file
            wmp.PlayStateChange += (newState) =>
            {
                if ((WMPLib.WMPPlayState)newState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    File.Delete(tempFile);
                }
            };
            wmp.controls.stop();
            ms.Dispose();
            bw.Dispose();
        }


        private void btnObterDados_Click(object sender, EventArgs e)
        {
            dataGridViewDadosADC.DataSource = null;
            string[] arrayOfSamples = dataIn.Split('\n');
            string[] updatedArray = Array.ConvertAll(arrayOfSamples, s => s.Replace("\r", ""));
            int count = updatedArray.Length - 1;
            int sampleCount = count;
            double sampleRate = sampleCount / double.Parse(txtTime.Text);
            Complex[] fft = new Complex[sampleCount];

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Amostra(N)", typeof(int));
            dataTable.Columns.Add("Valor ADC", typeof(double));
            dataTable.Columns.Add("G(f)", typeof(string));
            dataTable.Columns.Add("Magnitude", typeof(double));
            dataTable.Columns.Add("Freq(Hz)", typeof(double));

            for (int i = 0; i < count; i++)
            {
                double value = Convert.ToDouble(updatedArray[i]);
                fft[i] = new Complex(value, 0);
            }

            Fourier.Forward(fft, FourierOptions.Default);

            for (int i = 0; i < count; i++)
            {
                double teste = i * (1.0 / (15 * count));
                string complexString = $"{fft[i].Real}+{fft[i].Imaginary}i";
                dataTable.Rows.Add(i, fft[i].Real, complexString, fft[i].Magnitude, i * (sampleRate / count));
            }
            dataGridViewDadosADC.DataSource = dataTable;
        }


        private void btnReg_Click(object sender, EventArgs e)
        {
            // Criar o modelo de gráfico e adicionar uma série
            var plotModel = new PlotModel { Title = "Amplitude" };
            var lineSeries = new LineSeries { Title = "Dados" };
            plotModel.Series.Add(lineSeries);

            // Adicionar pontos ao gráfico a partir do DataGridView
            foreach (DataGridViewRow row in dataGridViewDadosADC.Rows)
            {
                if (!row.IsNewRow)
                {
                    object magnitudeCell = row.Cells["Magnitude"].Value;
                    object freqCell = row.Cells["Freq(Hz)"].Value;

                    if (magnitudeCell != null && freqCell != null)
                    {
                        lineSeries.Points.Add(new DataPoint(Convert.ToDouble(freqCell), Convert.ToDouble(magnitudeCell)));
                    }
                }
            }
            // Atualizar o modelo de gráfico do controle PlotView
            plotView1.Model = plotModel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen)
            {
                MessageBox.Show("Conecte-se ao microcontrolador primeiro");
                return;
            }
            

            foreach (DataGridViewRow row in dataGridViewReg.Rows)
            {
                if (!row.IsNewRow)
                {
                    object indexCell = row.Cells[0].Value;
                    object freqCell = row.Cells[1].Value;
                    

                    if (indexCell != null && freqCell != null)
                    {

                        string N = Convert.ToString(indexCell);
                        N = N.PadLeft(5, '0');
                        string Freq =  Convert.ToString(freqCell);
                        Freq = Freq.PadLeft(5, '0');
                        serialPort1.Write($"#STRRG##{N}##{Freq}#");
                    }
                }
            }
            //serialPort1.Write("#CLRRG##NA##NA#");
        }

        private void btnPlotarReta_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Conecte-se ao microcontrolador primeiro");
                return;
            }
            dataIn = null;
            serialPort1.Write("#STRG##NA##NA#"); // começa a regressão no microcontrolador
            Thread.Sleep(500);
            string pattern = @"#(.*?)#";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(dataIn);
            if (!match.Success)
            {
                MessageBox.Show("Solicite solicite os dados da regressão primeiro ao microcontrolador");
                return;
            }
            string[] extractedValue = match.Groups[1].Value.Split(',');
            angularCoef = float.Parse(extractedValue[0]);
            linearCoef = float.Parse(extractedValue[1]);

            // Cria uma nova instância do modelo de plotagem
            var model = new PlotModel();

            // Define os limites do eixo X e Y
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Maximum = 40 , MajorGridlineStyle = LineStyle.Solid, MajorGridlineColor = OxyColors.Red, MajorStep = 1 });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = 0, Maximum = 5000, MajorGridlineStyle = LineStyle.Solid, MajorGridlineColor = OxyColors.Red, MajorStep = 500 });

            // Cria uma nova série de linha
            var lineSeries = new LineSeries();

            // Adiciona pontos à série de linha para representar a função afim f(x) = 2x + 1
            for (double x = 0; x <= 10; x += 0.1)
            {
                double y = angularCoef * x + linearCoef;
                lineSeries.Points.Add(new DataPoint(x, y));
            }

            // Adiciona a série de linha ao modelo de plotagem
            model.Series.Add(lineSeries);

            plotReta.Model= model;
            TxtEqReta.Text = $"f(x) = {extractedValue[0]}x+{extractedValue[1]}";
            txtBoxEqReta.Text = $"f(x) = {extractedValue[0]}x+{extractedValue[1]}";
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcVel_Click(object sender, EventArgs e)
        {
            double tubeLenInCm = double.Parse(inputTamanhoTubo.Text);
            vel = angularCoef * (tubeLenInCm/100) * 2;
            txtBoxVel.Text = vel.ToString();
        }
    }
}
