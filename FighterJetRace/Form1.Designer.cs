namespace FighterJetRace
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TrackLengthPanel = new System.Windows.Forms.Panel();
            this.JetRed = new System.Windows.Forms.PictureBox();
            this.JetYellow = new System.Windows.Forms.PictureBox();
            this.jetBlue = new System.Windows.Forms.PictureBox();
            this.jetBlack = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.PlaceBet = new System.Windows.Forms.Button();
            this.StartRace = new System.Windows.Forms.Button();
            this.RaceTimer = new System.Windows.Forms.Timer(this.components);
            this.TrackLengthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JetRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JetYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackLengthPanel
            // 
            this.TrackLengthPanel.Controls.Add(this.JetRed);
            this.TrackLengthPanel.Controls.Add(this.JetYellow);
            this.TrackLengthPanel.Controls.Add(this.jetBlue);
            this.TrackLengthPanel.Controls.Add(this.jetBlack);
            this.TrackLengthPanel.Location = new System.Drawing.Point(13, 13);
            this.TrackLengthPanel.Name = "TrackLengthPanel";
            this.TrackLengthPanel.Size = new System.Drawing.Size(954, 389);
            this.TrackLengthPanel.TabIndex = 0;
            // 
            // JetRed
            // 
            this.JetRed.Image = global::FighterJetRace.Properties.Resources.JetRed;
            this.JetRed.Location = new System.Drawing.Point(4, 311);
            this.JetRed.Name = "JetRed";
            this.JetRed.Size = new System.Drawing.Size(75, 75);
            this.JetRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JetRed.TabIndex = 3;
            this.JetRed.TabStop = false;
            // 
            // JetYellow
            // 
            this.JetYellow.Image = global::FighterJetRace.Properties.Resources.JetYellow;
            this.JetYellow.Location = new System.Drawing.Point(4, 211);
            this.JetYellow.Name = "JetYellow";
            this.JetYellow.Size = new System.Drawing.Size(75, 75);
            this.JetYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JetYellow.TabIndex = 2;
            this.JetYellow.TabStop = false;
            // 
            // jetBlue
            // 
            this.jetBlue.Image = global::FighterJetRace.Properties.Resources.JetBlue;
            this.jetBlue.Location = new System.Drawing.Point(4, 109);
            this.jetBlue.Name = "jetBlue";
            this.jetBlue.Size = new System.Drawing.Size(75, 75);
            this.jetBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jetBlue.TabIndex = 1;
            this.jetBlue.TabStop = false;
            // 
            // jetBlack
            // 
            this.jetBlack.Image = global::FighterJetRace.Properties.Resources.JetBlack;
            this.jetBlack.Location = new System.Drawing.Point(4, 4);
            this.jetBlack.Name = "jetBlack";
            this.jetBlack.Size = new System.Drawing.Size(75, 75);
            this.jetBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jetBlack.TabIndex = 0;
            this.jetBlack.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 409);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 433);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 457);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bet Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Betting Plane";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(569, 418);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            995,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(569, 444);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PlaceBet
            // 
            this.PlaceBet.Location = new System.Drawing.Point(696, 418);
            this.PlaceBet.Name = "PlaceBet";
            this.PlaceBet.Size = new System.Drawing.Size(271, 46);
            this.PlaceBet.TabIndex = 11;
            this.PlaceBet.Text = "PLACE BET";
            this.PlaceBet.UseVisualStyleBackColor = true;
            this.PlaceBet.Click += new System.EventHandler(this.PlaceBet_Click);
            // 
            // StartRace
            // 
            this.StartRace.Location = new System.Drawing.Point(494, 470);
            this.StartRace.Name = "StartRace";
            this.StartRace.Size = new System.Drawing.Size(473, 69);
            this.StartRace.TabIndex = 12;
            this.StartRace.Text = "START RACE";
            this.StartRace.UseVisualStyleBackColor = true;
            this.StartRace.Click += new System.EventHandler(this.StartRace_Click);
            // 
            // RaceTimer
            // 
            this.RaceTimer.Tick += new System.EventHandler(this.RaceTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 551);
            this.Controls.Add(this.StartRace);
            this.Controls.Add(this.PlaceBet);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TrackLengthPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TrackLengthPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JetRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JetYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TrackLengthPanel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.PictureBox JetRed;
        private System.Windows.Forms.PictureBox JetYellow;
        private System.Windows.Forms.PictureBox jetBlue;
        private System.Windows.Forms.PictureBox jetBlack;
        private System.Windows.Forms.Button PlaceBet;
        private System.Windows.Forms.Button StartRace;
        private System.Windows.Forms.Timer RaceTimer;
    }
}

