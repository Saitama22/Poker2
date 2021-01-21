namespace poker.exe._2._0
{
    partial class saper
    {
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
            SuspendLayout();
            Icon = System.Drawing.Icon.ExtractAssociatedIcon("data//" + "saper.ico");
            // 
            // button1
            // 
            startBut.Location = new System.Drawing.Point(130, 10);
            startBut.Size = new System.Drawing.Size(50, 50);
            startBut.TabIndex = 0;
            startBut.Click += new System.EventHandler(button1_Click);
            startBut.Image = System.Drawing.Image.FromFile("data//restart.png");
            //
            //
            flag.Location = new System.Drawing.Point(200, 10);
            flag.Size = new System.Drawing.Size(50, 50);
            flag.Click += new System.EventHandler(flag_Click);
            flag.Image = System.Drawing.Image.FromFile("data//mine.png");
            // 
            // label1
            // 
            numbbombs.AutoSize = true;
            numbbombs.Location = new System.Drawing.Point(0, 0);
            numbbombs.Size = new System.Drawing.Size(38, 15);
            numbbombs.TabIndex = 1;
            // 
            // label2
            // 
            infogame.AutoSize = true;
            infogame.Location = new System.Drawing.Point(0, 20);
            infogame.Size = new System.Drawing.Size(38, 15);
            infogame.TabIndex = 2;
            // 
            // button2
            // 
            int j = 0;
            for (int i = 0; i < mine.Length; i++)
            {
                if (i % 8 == 0)
                    j++;
                mine[i] = new System.Windows.Forms.Button();
                mine[i].Size = new System.Drawing.Size(40, 40);
                mine[i].Location = new System.Drawing.Point(mine[i].Size.Width * (((i) % 8)), 30 + mine[i].Size.Height * j);
                //mine[i].Text = i.ToString();
                mine[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                mine[i].Click += new System.EventHandler(button2_Click);
                mine[i].TabIndex = i + 1;
                mine[i].BackColor = System.Drawing.Color.Blue;
            }
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(320, 390);
            for (int i = 0; i < mine.Length; i++)
            {
                Controls.Add(mine[i]);
            }
            Controls.Add(infogame);
            Controls.Add(numbbombs);
            Controls.Add(startBut);
            Controls.Add(flag);
            Name = "Form1";
            Text = "Caпeр";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBut = new System.Windows.Forms.Button();
        private System.Windows.Forms.Label infogame = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label numbbombs = new System.Windows.Forms.Label();
        private System.Windows.Forms.Button[] mine = new System.Windows.Forms.Button[64];
        System.Windows.Forms.Button flag = new System.Windows.Forms.Button();
    }
}

