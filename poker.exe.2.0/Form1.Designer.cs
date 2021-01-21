using System.Drawing;


namespace poker.exe._2._0
{
    partial class Form1
    {
        const int numbEn=4;
        const int numbAll =5;
        const int numbMy = 2;        
        protected const string patch = "data\\";
        protected const string endpat = ".png";
        const int sizeButX = 200;
        const int sizeButY = 60;
        const int sizePicX = 100;
        const int sizePicY = 145;

        const int locButsX = 720;
        const int locButsY = 440;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.Cursor = new System.Windows.Forms.Cursor("data//cursor.cur");
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(patch + "KJ.ico");
            this.ClientSize = new System.Drawing.Size(1680, 1080);

            for (int i = 0; i < numbEn; i++)
            {
                this.bank[i] = new System.Windows.Forms.Label();
                this.groupBox[i] = new System.Windows.Forms.GroupBox();
                this.groupBox[i].SuspendLayout();
                this.massege[i] = new System.Windows.Forms.Label();
            }            
            for (int i = 0; i < numbAll; i++)
            {
                this.all[i] = new System.Windows.Forms.PictureBox();
            }
            for (int i = 0; i < numbEn * 2; i++)
            {
                this.en[i] = new System.Windows.Forms.PictureBox();
            }
            ((System.ComponentModel.ISupportInitialize)(this.my2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();

            for (int i = 0; i < numbAll; i++)
            {
                ((System.ComponentModel.ISupportInitialize)(this.all[i])).BeginInit();
            }
            for (int i = 0; i < numbEn * 2; i++)
            {
                ((System.ComponentModel.ISupportInitialize)(this.en[i])).BeginInit();
            }

            this.SuspendLayout();
            // my2
            {
                my2.Image = Image.FromFile(patch + "rub" + endpat);
                this.my2.Location = new System.Drawing.Point(ClientSize.Width/2-sizePicX-2, 550);
                this.my2.Size = new System.Drawing.Size(sizePicX, sizePicY);
                this.my2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
            // my1
            {
                my1.Image = Image.FromFile(patch + "rub" + endpat);
                this.my1.Location = new System.Drawing.Point(ClientSize.Width / 2 + 2, 550);
                this.my1.Size = new System.Drawing.Size(sizePicX, sizePicY);
                this.my1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }           
            // But_start
            {
                this.But_start.BackColor = System.Drawing.Color.Gray;                             
                this.But_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;                
                this.But_start.Location = new System.Drawing.Point(ClientSize.Width/2-150, ClientSize.Height/3);
                this.But_start.Size = new System.Drawing.Size(300, 80);
                this.But_start.Text = "Начать";
                this.But_start.Click += new System.EventHandler(this.start_Click);
                this.But_start.Font = new Font("Franklin Gothic", 20);
            }
            // settings
            {
                this.settings.BackColor = System.Drawing.Color.Gray;
                this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.settings.Location = new System.Drawing.Point(But_start.Location.X, But_start.Location.Y + But_start.Size.Height+5);
                this.settings.Size = new System.Drawing.Size(300, 80);
                this.settings.Text = "Настройки";
                this.settings.Click += new System.EventHandler(this.sett_Click);
                this.Controls.Add(settings);
                this.settings.Font = new Font("Franklin Gothic", 20);
            }
            // call
            {
                this.call.BackColor = System.Drawing.Color.Gray;
                this.call.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.call.Location = new System.Drawing.Point(my1.Location.X, my1.Location.Y+200);                
                this.call.Size = new System.Drawing.Size(sizeButX, sizeButY); 
                this.call.Text = "Колл";
                this.call.Click += new System.EventHandler(this.call_Click);
                this.call.Font = new Font("Franklin Gothic", 20);
            }
             // Pas
            {
                this.Pas.BackColor = System.Drawing.Color.Gray;
                this.Pas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.Pas.Location = new System.Drawing.Point(call.Location.X, call.Location.Y+ sizeButY+2);
                this.Pas.Size = new System.Drawing.Size(sizeButX,sizeButY);
                this.Pas.Text = "Пас";
                this.Pas.Click += new System.EventHandler(this.pass_Click);
                this.Pas.Font = new Font("Franklin Gothic", 20);
            }
            // but_lose
            {
                this.but_lose.BackColor = System.Drawing.Color.Gray;
                this.but_lose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.but_lose.Location = new System.Drawing.Point(Pas.Location.X, Pas.Location.Y + sizeButY + 2);                
                this.but_lose.Size = new System.Drawing.Size(sizeButX, sizeButY);
                this.but_lose.Text = "Сдать";
                this.but_lose.Click += new System.EventHandler(this.lose_Click);
                this.but_lose.Font = new Font("Franklin Gothic", 20);
            }
            // But_rate
            {
                this.But_rate.BackColor = System.Drawing.Color.Gray;
                this.But_rate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.But_rate.Location = new System.Drawing.Point(call.Location.X - sizeButX - 10, call.Location.Y);
                this.But_rate.Size = new System.Drawing.Size(sizeButX, sizeButY);
                this.But_rate.Text = "Ставка";
                this.But_rate.Click += new System.EventHandler(this.rate_Click);
                this.But_rate.Font = new Font("Franklin Gothic", 20);
            }
            //flop
            {
                this.flop.BackColor = System.Drawing.Color.Gray;
                this.flop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.flop.Location = new System.Drawing.Point(But_rate.Location.X, But_rate.Location.Y + sizeButY + 2);
                this.flop.Size = new System.Drawing.Size(sizeButX/2, sizeButY);
                this.flop.Text = "Min";
                this.flop.Click += new System.EventHandler(this.flop_Click);
                this.flop.Font = new Font("Franklin Gothic", 20);
            }
            //doubflop
            {
                this.doubflop.BackColor = System.Drawing.Color.Gray;
                this.doubflop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.doubflop.Location = new System.Drawing.Point(flop.Location.X +flop.Size.Width, flop.Location.Y);
                this.doubflop.Size = new System.Drawing.Size(sizeButX / 3, sizeButY);
                this.doubflop.Text = "BIG Блайнд";
                this.doubflop.Click += new System.EventHandler(this.doubflop_Click);
            }
            //max
            {
                this.maxim.BackColor = System.Drawing.Color.Gray;
                this.maxim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.maxim.Location = new System.Drawing.Point(flop.Location.X + flop.Size.Width, flop.Location.Y);
                this.maxim.Size = new System.Drawing.Size(sizeButX / 2, sizeButY);
                this.maxim.Text = "Max";
                this.maxim.Click += new System.EventHandler(this.max_Click);
                this.maxim.Font = new Font("Franklin Gothic", 20);
            }
            // trackBar1
            {
                this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                this.trackBar1.BackColor = System.Drawing.Color.FromArgb(22,22,22) ;
                this.trackBar1.Location = new System.Drawing.Point(flop.Location.X-5, flop.Location.Y+sizeButY+2);
                this.trackBar1.Size = new System.Drawing.Size(sizeButX+10, 1);
                //this.trackBar1.
                this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
                this.trackBar1.Maximum = 100;
            }
            // myRateBox
            {
                this.myRateBox.BackColor = System.Drawing.Color.Gray        ;
                this.myRateBox.Location = new System.Drawing.Point(flop.Location.X,flop.Location.Y+100);
                this.myRateBox.Size = new System.Drawing.Size(sizeButX, 40);
                this.myRateBox.TextChanged += new System.EventHandler(this.myRateBox_TextChanged);
            }
            //actualRate
            {
                this.actualRate.BackColor = System.Drawing.Color.FromArgb(64,64,64) ;
                this.actualRate.Location = new System.Drawing.Point(150, 400);
                this.actualRate.Size = new System.Drawing.Size(300, 30);
                this.actualRate.Font = new System.Drawing.Font("Franklin Gothic", 16);               
                this.actualRate.Text = "Текущая ставка: 0";
            }
            // total
            {
                this.total.BackColor = System.Drawing.Color.FromArgb(64,64,64) ;
                this.total.Location = new System.Drawing.Point(actualRate.Location.X, actualRate.Location.Y+30);
                this.total.Size = new System.Drawing.Size(300, 30);
                this.total.Font = new System.Drawing.Font("Franklin Gothic", 16);
                this.total.Text = "Всего на кону: 0";
            }
            // help
            {
                this.help.BackColor = System.Drawing.Color.FromArgb(64,64,64) ;
                this.help.Size = new System.Drawing.Size(300, 23);                
                this.help.Visible = false;
            }
            // bank & groupbox & massage
            for (int i = 0; i < numbEn; i++)
            {
                this.bank[i].BackColor = System.Drawing.Color.FromArgb(64,64,64) ;
                this.bank[i].Location = new System.Drawing.Point(5, 170);
                this.bank[i].Size = new System.Drawing.Size(150, 30);
                this.bank[i].Font = new System.Drawing.Font("Franklin Gothic", 14);
                this.bank[i].Text = "Банк: ";
                //gr                
                this.groupBox[i].Controls.Add(this.bank[i]);
                this.groupBox[i].Location = new System.Drawing.Point(385+(235) * i, 110);
                this.groupBox[i].Size = new System.Drawing.Size(210, 210);
                this.groupBox[i].TabStop = false;
                this.groupBox[i].Font = new System.Drawing.Font("Franklin Gothic", 10);
                //mas
                this.massege[i].BackColor = System.Drawing.Color.FromArgb(22,22,22) ;
                this.massege[i].Location = new System.Drawing.Point(0, 800 + i * 32);
                this.massege[i].Size = new System.Drawing.Size(450, 32);
                this.massege[i].Font = new System.Drawing.Font("Franklin Gothic", 18);
                this.massege[i].ForeColor = Color.Gray;
            }
            //all
            for (int i = 0; i < numbAll; i++)
            {
                this.all[i].Location = new System.Drawing.Point(ClientSize.Width/2-260 + (5 + sizePicX) * i, 350) ;
                this.all[i].Size = new System.Drawing.Size(sizePicX, sizePicY);
                this.all[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
            // TextWin
            {
                this.TextWin.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.TextWin.Font = new System.Drawing.Font("Franklin Gothic", 25);
                this.TextWin.AutoSize = true;
            }
            //en
            for (int i = 0; i < numbEn * 2; i++)
            {
                this.groupBox[i / 2].Controls.Add(this.en[i]);
                this.groupBox[i / 2].Controls.Add(this.en[i]);
                int XLoc;
                if (i % 2 == 0)
                    XLoc = 5;
                else
                    XLoc = 105;
                this.en[i].Location = new System.Drawing.Point(XLoc, 22);
                this.en[i].Size = new System.Drawing.Size(sizePicX, sizePicY);
                this.en[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
            //error
            {
                this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            }
            //mybank
            {
                this.mybank.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.mybank.Location = new System.Drawing.Point(my2.Location.X+sizePicX*2+10, my2.Location.Y +110);
                this.mybank.Size = new System.Drawing.Size(300, 40);
                this.mybank.Font = new System.Drawing.Font("Franklin Gothic", 25);
                this.mybank.Text = "Мой банк: ";
                this.mybank.Click += new System.EventHandler(this.mybank_Click);
                this.mybank.ForeColor = Color.Black;
            }
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Interval = 100;
            //clock
            this.clock.BackColor = Color.FromArgb(22, 22, 22);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(64,64,64) ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch ;
            this.Text = "Poker";
            this.Controls.Add(this.But_start); 
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.my2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my1)).EndInit();
            for (int i = 0; i < numbAll; i++)
            {
                ((System.ComponentModel.ISupportInitialize)(this.all[i])).EndInit();
            }
            for (int i = 0; i < numbEn * 2; i++)
            {
                ((System.ComponentModel.ISupportInitialize)(this.en[i])).EndInit();
            }
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();          
        }

        #endregion
        private System.Windows.Forms.PictureBox my2 = new System.Windows.Forms.PictureBox();
        private System.Windows.Forms.PictureBox my1 = new System.Windows.Forms.PictureBox();
        private System.Windows.Forms.Button But_start = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button Pas = new System.Windows.Forms.Button();
        private System.Windows.Forms.Label TextWin = new System.Windows.Forms.Label();
        private System.Windows.Forms.Button But_rate = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button but_lose = new System.Windows.Forms.Button();
        private System.Windows.Forms.TrackBar trackBar1 = new System.Windows.Forms.TrackBar();
        private System.Windows.Forms.TextBox myRateBox = new System.Windows.Forms.TextBox();

        private System.Windows.Forms.Label[] bank= new System.Windows.Forms.Label[numbEn];
        private System.Windows.Forms.PictureBox[] all= new System.Windows.Forms.PictureBox[numbAll];
        private System.Windows.Forms.PictureBox[] en = new System.Windows.Forms.PictureBox[2*numbEn];
        private System.Windows.Forms.PictureBox[] my = new System.Windows.Forms.PictureBox[numbMy];
        private System.Windows.Forms.GroupBox[] groupBox = new System.Windows.Forms.GroupBox[numbEn];
        private System.Windows.Forms.Label mybank = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label total = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label actualRate = new System.Windows.Forms.Label();
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button call = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button flop = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button doubflop = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button maxim = new System.Windows.Forms.Button();
        private System.Windows.Forms.Label[] massege = new System.Windows.Forms.Label[numbEn];
        private System.Windows.Forms.Label help = new System.Windows.Forms.Label();
        private System.Windows.Forms.PictureBox clock = new System.Windows.Forms.PictureBox();
        private System.Windows.Forms.Timer timer1= new System.Windows.Forms.Timer();

        private System.Windows.Forms.Button settings = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button autors = new System.Windows.Forms.Button();
        private System.Windows.Forms.ComboBox colorTable = new  System.Windows.Forms.ComboBox();
        private System.Windows.Forms.Label textsetTable= new System.Windows.Forms.Label();
        private System.Windows.Forms.Label textsetMin = new System.Windows.Forms.Label();
        private System.Windows.Forms.TextBox MinRate = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.ComboBox Lang = new System.Windows.Forms.ComboBox();
        private System.Windows.Forms.Label textsetLang = new System.Windows.Forms.Label();
    }
}