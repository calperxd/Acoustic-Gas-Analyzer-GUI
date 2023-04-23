namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnObterDados = new System.Windows.Forms.Button();
            this.dataGridViewDadosADC = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFFT = new System.Windows.Forms.Button();
            this.stopAmostragem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vScrollBarVolumeSenoidal = new System.Windows.Forms.VScrollBar();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.btnStopSenoidal = new System.Windows.Forms.Button();
            this.txtDuracaoInputSenoidal = new System.Windows.Forms.RichTextBox();
            this.lblFreq = new System.Windows.Forms.Label();
            this.txtFreqInputSenoidal = new System.Windows.Forms.RichTextBox();
            this.btnPlaySenoidal = new System.Windows.Forms.Button();
            this.btnAmostragem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPlayWhiteNoise = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblGain = new System.Windows.Forms.Label();
            this.scrllVolume = new System.Windows.Forms.VScrollBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPlotarReta = new System.Windows.Forms.Button();
            this.TxtEqReta = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewReg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plotReta = new OxyPlot.WindowsForms.PlotView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtBoxVel = new System.Windows.Forms.RichTextBox();
            this.txtBoxEqReta = new System.Windows.Forms.RichTextBox();
            this.btnCalcVel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inputTamanhoTubo = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDadosADC)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReg)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReg);
            this.tabPage2.Controls.Add(this.btnObterDados);
            this.tabPage2.Controls.Add(this.dataGridViewDadosADC);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(638, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Processamendo de dados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnReg.Location = new System.Drawing.Point(2, -1);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(634, 25);
            this.btnReg.TabIndex = 22;
            this.btnReg.Text = "Plotar FFT";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnObterDados
            // 
            this.btnObterDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObterDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnObterDados.Location = new System.Drawing.Point(2, 24);
            this.btnObterDados.Margin = new System.Windows.Forms.Padding(2);
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(634, 25);
            this.btnObterDados.TabIndex = 7;
            this.btnObterDados.Text = "Calcular FFT";
            this.btnObterDados.UseVisualStyleBackColor = true;
            this.btnObterDados.Click += new System.EventHandler(this.btnObterDados_Click);
            // 
            // dataGridViewDadosADC
            // 
            this.dataGridViewDadosADC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDadosADC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDadosADC.Location = new System.Drawing.Point(2, 49);
            this.dataGridViewDadosADC.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDadosADC.Name = "dataGridViewDadosADC";
            this.dataGridViewDadosADC.RowHeadersWidth = 51;
            this.dataGridViewDadosADC.RowTemplate.Height = 24;
            this.dataGridViewDadosADC.Size = new System.Drawing.Size(634, 325);
            this.dataGridViewDadosADC.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFFT);
            this.tabPage1.Controls.Add(this.stopAmostragem);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btnAmostragem);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnPlay);
            this.tabPage1.Controls.Add(this.btnDownload);
            this.tabPage1.Controls.Add(this.txtTime);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(638, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Amostragem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFFT
            // 
            this.btnFFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnFFT.Location = new System.Drawing.Point(428, 102);
            this.btnFFT.Margin = new System.Windows.Forms.Padding(2);
            this.btnFFT.Name = "btnFFT";
            this.btnFFT.Size = new System.Drawing.Size(73, 25);
            this.btnFFT.TabIndex = 21;
            this.btnFFT.Text = "FFT";
            this.btnFFT.UseVisualStyleBackColor = true;
            this.btnFFT.Click += new System.EventHandler(this.btnObterDados_Click);
            // 
            // stopAmostragem
            // 
            this.stopAmostragem.Location = new System.Drawing.Point(283, 102);
            this.stopAmostragem.Margin = new System.Windows.Forms.Padding(2);
            this.stopAmostragem.Name = "stopAmostragem";
            this.stopAmostragem.Size = new System.Drawing.Size(120, 25);
            this.stopAmostragem.TabIndex = 20;
            this.stopAmostragem.Text = "Parar Amostragem";
            this.stopAmostragem.UseVisualStyleBackColor = true;
            this.stopAmostragem.Click += new System.EventHandler(this.stopAmostragem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.vScrollBarVolumeSenoidal);
            this.groupBox3.Controls.Add(this.lblDuracao);
            this.groupBox3.Controls.Add(this.btnStopSenoidal);
            this.groupBox3.Controls.Add(this.txtDuracaoInputSenoidal);
            this.groupBox3.Controls.Add(this.lblFreq);
            this.groupBox3.Controls.Add(this.txtFreqInputSenoidal);
            this.groupBox3.Controls.Add(this.btnPlaySenoidal);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(6, 187);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(302, 154);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Onda Senoidal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Volume";
            // 
            // vScrollBarVolumeSenoidal
            // 
            this.vScrollBarVolumeSenoidal.Location = new System.Drawing.Point(259, 59);
            this.vScrollBarVolumeSenoidal.Name = "vScrollBarVolumeSenoidal";
            this.vScrollBarVolumeSenoidal.Size = new System.Drawing.Size(21, 81);
            this.vScrollBarVolumeSenoidal.TabIndex = 12;
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(93, 73);
            this.lblDuracao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(88, 20);
            this.lblDuracao.TabIndex = 11;
            this.lblDuracao.Text = "Duração(s)";
            // 
            // btnStopSenoidal
            // 
            this.btnStopSenoidal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnStopSenoidal.Location = new System.Drawing.Point(82, 115);
            this.btnStopSenoidal.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopSenoidal.Name = "btnStopSenoidal";
            this.btnStopSenoidal.Size = new System.Drawing.Size(73, 25);
            this.btnStopSenoidal.TabIndex = 10;
            this.btnStopSenoidal.Text = "Stop";
            this.btnStopSenoidal.UseVisualStyleBackColor = true;
            this.btnStopSenoidal.Click += new System.EventHandler(this.btnStopSenoidal_Click);
            // 
            // txtDuracaoInputSenoidal
            // 
            this.txtDuracaoInputSenoidal.Location = new System.Drawing.Point(14, 64);
            this.txtDuracaoInputSenoidal.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuracaoInputSenoidal.Name = "txtDuracaoInputSenoidal";
            this.txtDuracaoInputSenoidal.Size = new System.Drawing.Size(74, 36);
            this.txtDuracaoInputSenoidal.TabIndex = 9;
            this.txtDuracaoInputSenoidal.Text = "30";
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(93, 31);
            this.lblFreq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(119, 20);
            this.lblFreq.TabIndex = 8;
            this.lblFreq.Text = "Frequência(Hz)";
            // 
            // txtFreqInputSenoidal
            // 
            this.txtFreqInputSenoidal.Location = new System.Drawing.Point(14, 24);
            this.txtFreqInputSenoidal.Margin = new System.Windows.Forms.Padding(2);
            this.txtFreqInputSenoidal.Name = "txtFreqInputSenoidal";
            this.txtFreqInputSenoidal.Size = new System.Drawing.Size(74, 36);
            this.txtFreqInputSenoidal.TabIndex = 7;
            this.txtFreqInputSenoidal.Text = "300";
            // 
            // btnPlaySenoidal
            // 
            this.btnPlaySenoidal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnPlaySenoidal.Location = new System.Drawing.Point(4, 115);
            this.btnPlaySenoidal.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaySenoidal.Name = "btnPlaySenoidal";
            this.btnPlaySenoidal.Size = new System.Drawing.Size(73, 25);
            this.btnPlaySenoidal.TabIndex = 6;
            this.btnPlaySenoidal.Text = "Play";
            this.btnPlaySenoidal.UseVisualStyleBackColor = true;
            this.btnPlaySenoidal.Click += new System.EventHandler(this.btnPlaySenoidal_Click_1);
            // 
            // btnAmostragem
            // 
            this.btnAmostragem.Location = new System.Drawing.Point(283, 72);
            this.btnAmostragem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAmostragem.Name = "btnAmostragem";
            this.btnAmostragem.Size = new System.Drawing.Size(120, 25);
            this.btnAmostragem.TabIndex = 19;
            this.btnAmostragem.Text = "Iniciar Amostragem";
            this.btnAmostragem.UseVisualStyleBackColor = true;
            this.btnAmostragem.Click += new System.EventHandler(this.btnAmostragem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnPlayWhiteNoise);
            this.groupBox2.Controls.Add(this.btnMinus);
            this.groupBox2.Controls.Add(this.btnPlus);
            this.groupBox2.Controls.Add(this.lblGain);
            this.groupBox2.Controls.Add(this.scrllVolume);
            this.groupBox2.Controls.Add(this.lblVolume);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(331, 141);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(278, 200);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ruído Branco";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button2.Location = new System.Drawing.Point(157, 36);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlayWhiteNoise
            // 
            this.btnPlayWhiteNoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnPlayWhiteNoise.Location = new System.Drawing.Point(36, 36);
            this.btnPlayWhiteNoise.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlayWhiteNoise.Name = "btnPlayWhiteNoise";
            this.btnPlayWhiteNoise.Size = new System.Drawing.Size(73, 25);
            this.btnPlayWhiteNoise.TabIndex = 13;
            this.btnPlayWhiteNoise.Text = "Play";
            this.btnPlayWhiteNoise.UseVisualStyleBackColor = true;
            this.btnPlayWhiteNoise.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(224, 119);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(28, 27);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(191, 119);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(28, 27);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGain.Location = new System.Drawing.Point(194, 85);
            this.lblGain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(58, 20);
            this.lblGain.TabIndex = 9;
            this.lblGain.Text = "Ganho";
            // 
            // scrllVolume
            // 
            this.scrllVolume.Location = new System.Drawing.Point(93, 106);
            this.scrllVolume.Name = "scrllVolume";
            this.scrllVolume.Size = new System.Drawing.Size(21, 81);
            this.scrllVolume.TabIndex = 7;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(72, 85);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(63, 20);
            this.lblVolume.TabIndex = 8;
            this.lblVolume.Text = "Volume";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(398, 187);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(73, 25);
            this.btnPlay.TabIndex = 16;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(428, 71);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(73, 25);
            this.btnDownload.TabIndex = 15;
            this.btnDownload.Text = "Baixar CSV";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(458, 28);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(44, 21);
            this.txtTime.TabIndex = 13;
            this.txtTime.Text = "15";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPort);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 176);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(141, 89);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Desconectar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(21, 89);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(73, 25);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Conectar";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PORTA";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(141, 32);
            this.cbPort.Margin = new System.Windows.Forms.Padding(2);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(101, 21);
            this.cbPort.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(279, 28);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(173, 20);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Tempo de amostragem";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(11, 11);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.plotView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(638, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FFT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // plotView1
            // 
            this.plotView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotView1.Location = new System.Drawing.Point(2, 2);
            this.plotView1.Margin = new System.Windows.Forms.Padding(2);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(634, 372);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.TxtEqReta);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.dataGridViewReg);
            this.tabPage4.Controls.Add(this.plotReta);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(638, 376);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Regressão Linear";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnPlotarReta);
            this.groupBox5.Location = new System.Drawing.Point(456, 318);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(177, 53);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // btnPlotarReta
            // 
            this.btnPlotarReta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlotarReta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnPlotarReta.Location = new System.Drawing.Point(3, 25);
            this.btnPlotarReta.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlotarReta.Name = "btnPlotarReta";
            this.btnPlotarReta.Size = new System.Drawing.Size(171, 25);
            this.btnPlotarReta.TabIndex = 23;
            this.btnPlotarReta.Text = "Plotar Reta";
            this.btnPlotarReta.UseVisualStyleBackColor = true;
            this.btnPlotarReta.Click += new System.EventHandler(this.btnPlotarReta_Click);
            // 
            // TxtEqReta
            // 
            this.TxtEqReta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEqReta.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtEqReta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtEqReta.Location = new System.Drawing.Point(249, 318);
            this.TxtEqReta.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEqReta.Name = "TxtEqReta";
            this.TxtEqReta.ReadOnly = true;
            this.TxtEqReta.Size = new System.Drawing.Size(201, 36);
            this.TxtEqReta.TabIndex = 8;
            this.TxtEqReta.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(6, 349);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(239, 28);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button1.Location = new System.Drawing.Point(2, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "Regressão Linear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewReg
            // 
            this.dataGridViewReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewReg.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReg.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewReg.Name = "dataGridViewReg";
            this.dataGridViewReg.RowHeadersWidth = 51;
            this.dataGridViewReg.RowTemplate.Height = 24;
            this.dataGridViewReg.Size = new System.Drawing.Size(245, 314);
            this.dataGridViewReg.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "N";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 96;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Frequência(Hz)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 96;
            // 
            // plotReta
            // 
            this.plotReta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotReta.Location = new System.Drawing.Point(249, 2);
            this.plotReta.Margin = new System.Windows.Forms.Padding(2);
            this.plotReta.Name = "plotReta";
            this.plotReta.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotReta.Size = new System.Drawing.Size(388, 312);
            this.plotReta.TabIndex = 0;
            this.plotReta.Text = "plotView2";
            this.plotReta.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotReta.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotReta.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Location = new System.Drawing.Point(4, 38);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(638, 376);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tubo";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.lblVelocidade);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.inputTamanhoTubo);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(632, 370);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(462, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Equação da reta";
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVelocidade.Location = new System.Drawing.Point(255, 303);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(123, 20);
            this.lblVelocidade.TabIndex = 18;
            this.lblVelocidade.Text = "Velocidade(m/s)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtBoxVel);
            this.groupBox7.Controls.Add(this.txtBoxEqReta);
            this.groupBox7.Controls.Add(this.btnCalcVel);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox7.Location = new System.Drawing.Point(3, 308);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(626, 59);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // txtBoxVel
            // 
            this.txtBoxVel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxVel.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxVel.Location = new System.Drawing.Point(215, 17);
            this.txtBoxVel.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxVel.Name = "txtBoxVel";
            this.txtBoxVel.ReadOnly = true;
            this.txtBoxVel.Size = new System.Drawing.Size(201, 36);
            this.txtBoxVel.TabIndex = 18;
            this.txtBoxVel.Text = "";
            // 
            // txtBoxEqReta
            // 
            this.txtBoxEqReta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEqReta.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxEqReta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxEqReta.Location = new System.Drawing.Point(420, 17);
            this.txtBoxEqReta.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxEqReta.Name = "txtBoxEqReta";
            this.txtBoxEqReta.ReadOnly = true;
            this.txtBoxEqReta.Size = new System.Drawing.Size(201, 36);
            this.txtBoxEqReta.TabIndex = 17;
            this.txtBoxEqReta.Text = "";
            // 
            // btnCalcVel
            // 
            this.btnCalcVel.Location = new System.Drawing.Point(6, 19);
            this.btnCalcVel.Name = "btnCalcVel";
            this.btnCalcVel.Size = new System.Drawing.Size(135, 34);
            this.btnCalcVel.TabIndex = 16;
            this.btnCalcVel.Text = "Calcular velocidade";
            this.btnCalcVel.UseVisualStyleBackColor = true;
            this.btnCalcVel.Click += new System.EventHandler(this.btnCalcVel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Largura(cm)";
            // 
            // inputTamanhoTubo
            // 
            this.inputTamanhoTubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputTamanhoTubo.Location = new System.Drawing.Point(244, 50);
            this.inputTamanhoTubo.Margin = new System.Windows.Forms.Padding(2);
            this.inputTamanhoTubo.Name = "inputTamanhoTubo";
            this.inputTamanhoTubo.Size = new System.Drawing.Size(90, 26);
            this.inputTamanhoTubo.TabIndex = 14;
            this.inputTamanhoTubo.Text = "99.8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources.Cota;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 351);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 418);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDadosADC)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReg)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button stopAmostragem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar vScrollBarVolumeSenoidal;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Button btnStopSenoidal;
        private System.Windows.Forms.RichTextBox txtDuracaoInputSenoidal;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.RichTextBox txtFreqInputSenoidal;
        private System.Windows.Forms.Button btnPlaySenoidal;
        private System.Windows.Forms.Button btnAmostragem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblGain;
        private System.Windows.Forms.VScrollBar scrllVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.RichTextBox txtTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPlayWhiteNoise;
        private System.Windows.Forms.DataGridView dataGridViewDadosADC;
        private System.Windows.Forms.Button btnObterDados;
        private System.Windows.Forms.Button btnFFT;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnReg;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.TabPage tabPage4;
        private OxyPlot.WindowsForms.PlotView plotReta;
        private System.Windows.Forms.DataGridView dataGridViewReg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPlotarReta;
        private System.Windows.Forms.RichTextBox TxtEqReta;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox txtBoxEqReta;
        private System.Windows.Forms.Button btnCalcVel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox inputTamanhoTubo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.RichTextBox txtBoxVel;
    }
}

