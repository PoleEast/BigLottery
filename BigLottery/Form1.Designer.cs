namespace BigLottery
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btnBet = new Button();
            lbInput = new Label();
            txbNumbers = new TextBox();
            lbUserName = new Label();
            txbUsename = new TextBox();
            lbData = new Label();
            lbdraw = new Label();
            lbSingle = new Label();
            lbMultiple = new Label();
            laSet = new Label();
            cbSet = new ComboBox();
            label1 = new Label();
            cbSetNumber1 = new ComboBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnBet
            // 
            btnBet.Location = new Point(649, 97);
            btnBet.Name = "btnBet";
            btnBet.Size = new Size(76, 38);
            btnBet.TabIndex = 0;
            btnBet.Text = "下注";
            btnBet.UseVisualStyleBackColor = true;
            btnBet.Click += button1_Click;
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbInput.Location = new Point(46, 97);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(76, 35);
            lbInput.TabIndex = 1;
            lbInput.Text = "號碼:";
            // 
            // txbNumbers
            // 
            txbNumbers.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbNumbers.Location = new Point(133, 97);
            txbNumbers.Name = "txbNumbers";
            txbNumbers.Size = new Size(490, 38);
            txbNumbers.TabIndex = 2;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbUserName.Location = new Point(12, 9);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(76, 35);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "名稱:";
            // 
            // txbUsename
            // 
            txbUsename.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbUsename.Location = new Point(99, 9);
            txbUsename.Name = "txbUsename";
            txbUsename.Size = new Size(220, 38);
            txbUsename.TabIndex = 4;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbData.Location = new Point(520, 12);
            lbData.Name = "lbData";
            lbData.Size = new Size(69, 35);
            lbData.TabIndex = 5;
            lbData.Text = "時間";
            // 
            // lbdraw
            // 
            lbdraw.AutoSize = true;
            lbdraw.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbdraw.Location = new Point(845, 12);
            lbdraw.Name = "lbdraw";
            lbdraw.Size = new Size(69, 35);
            lbdraw.TabIndex = 6;
            lbdraw.Text = "期號";
            // 
            // lbSingle
            // 
            lbSingle.AutoSize = true;
            lbSingle.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 136);
            lbSingle.Location = new Point(12, 70);
            lbSingle.Name = "lbSingle";
            lbSingle.Size = new Size(76, 17);
            lbSingle.TabIndex = 7;
            lbSingle.Text = "單筆下注->";
            // 
            // lbMultiple
            // 
            lbMultiple.AutoSize = true;
            lbMultiple.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 136);
            lbMultiple.Location = new Point(12, 156);
            lbMultiple.Name = "lbMultiple";
            lbMultiple.Size = new Size(76, 17);
            lbMultiple.TabIndex = 8;
            lbMultiple.Text = "多筆下注->";
            // 
            // laSet
            // 
            laSet.AutoSize = true;
            laSet.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            laSet.Location = new Point(46, 182);
            laSet.Name = "laSet";
            laSet.Size = new Size(69, 35);
            laSet.TabIndex = 9;
            laSet.Text = "組數";
            // 
            // cbSet
            // 
            cbSet.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbSet.FormattingEnabled = true;
            cbSet.Location = new Point(133, 179);
            cbSet.Name = "cbSet";
            cbSet.Size = new Size(59, 38);
            cbSet.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(222, 182);
            label1.Name = "label1";
            label1.Size = new Size(42, 35);
            label1.TabIndex = 11;
            label1.Text = "含";
            // 
            // cbSetNumber1
            // 
            cbSetNumber1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbSetNumber1.FormattingEnabled = true;
            cbSetNumber1.Location = new Point(282, 179);
            cbSetNumber1.Name = "cbSetNumber1";
            cbSetNumber1.Size = new Size(59, 38);
            cbSetNumber1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(649, 438);
            button1.Name = "button1";
            button1.Size = new Size(76, 38);
            button1.TabIndex = 13;
            button1.Text = "下注";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(282, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(59, 38);
            comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(282, 282);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(59, 38);
            comboBox2.TabIndex = 17;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(282, 335);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(59, 38);
            comboBox3.TabIndex = 19;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(282, 387);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(59, 38);
            comboBox4.TabIndex = 21;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(282, 438);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(59, 38);
            comboBox5.TabIndex = 22;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(cbSetNumber1);
            Controls.Add(label1);
            Controls.Add(cbSet);
            Controls.Add(laSet);
            Controls.Add(lbMultiple);
            Controls.Add(lbSingle);
            Controls.Add(lbdraw);
            Controls.Add(lbData);
            Controls.Add(txbUsename);
            Controls.Add(lbUserName);
            Controls.Add(txbNumbers);
            Controls.Add(lbInput);
            Controls.Add(btnBet);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBet;
        private Label lbInput;
        private TextBox txbNumbers;
        private Label lbUserName;
        private TextBox txbUsename;
        private Label lbData;
        private Label lbdraw;
        private Label lbSingle;
        private Label lbMultiple;
        private Label laSet;
        private ComboBox cbSet;
        private Label label1;
        private ComboBox cbSetNumber1;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private System.Windows.Forms.Timer timer;
    }
}
