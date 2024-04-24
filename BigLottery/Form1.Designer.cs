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
            laSet2 = new Label();
            cbSetNumber1 = new ComboBox();
            btnMultBet = new Button();
            cbSetNumber4 = new ComboBox();
            cbSetNumber2 = new ComboBox();
            cbSetNumber3 = new ComboBox();
            cbSetNumber5 = new ComboBox();
            timer = new System.Windows.Forms.Timer(components);
            plBet = new Panel();
            plWinner = new Panel();
            btnPrize = new Button();
            lbPrize2 = new Label();
            txbPrize = new TextBox();
            lbPrize = new Label();
            lbWinnerNum = new Label();
            lbWinnerDraw = new Label();
            tabSwitch = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dgvPrizeView = new DataGridView();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            plBet.SuspendLayout();
            plWinner.SuspendLayout();
            tabSwitch.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrizeView).BeginInit();
            SuspendLayout();
            // 
            // btnBet
            // 
            btnBet.Location = new Point(548, 36);
            btnBet.Name = "btnBet";
            btnBet.Size = new Size(76, 38);
            btnBet.TabIndex = 0;
            btnBet.Text = "下注";
            btnBet.UseVisualStyleBackColor = true;
            btnBet.Click += btnBet_Click;
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbInput.Location = new Point(36, 39);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(76, 35);
            lbInput.TabIndex = 1;
            lbInput.Text = "號碼:";
            // 
            // txbNumbers
            // 
            txbNumbers.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbNumbers.Location = new Point(123, 39);
            txbNumbers.Name = "txbNumbers";
            txbNumbers.PlaceholderText = "01,02,03,04,05,06";
            txbNumbers.Size = new Size(393, 38);
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
            txbUsename.PlaceholderText = "guest";
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
            lbSingle.Location = new Point(2, 12);
            lbSingle.Name = "lbSingle";
            lbSingle.Size = new Size(76, 17);
            lbSingle.TabIndex = 7;
            lbSingle.Text = "單筆下注->";
            // 
            // lbMultiple
            // 
            lbMultiple.AutoSize = true;
            lbMultiple.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 136);
            lbMultiple.Location = new Point(2, 98);
            lbMultiple.Name = "lbMultiple";
            lbMultiple.Size = new Size(76, 17);
            lbMultiple.TabIndex = 8;
            lbMultiple.Text = "多筆下注->";
            // 
            // laSet
            // 
            laSet.AutoSize = true;
            laSet.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            laSet.Location = new Point(36, 124);
            laSet.Name = "laSet";
            laSet.Size = new Size(69, 35);
            laSet.TabIndex = 9;
            laSet.Text = "組數";
            // 
            // cbSet
            // 
            cbSet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSet.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbSet.FormattingEnabled = true;
            cbSet.Location = new Point(123, 121);
            cbSet.Name = "cbSet";
            cbSet.Size = new Size(59, 38);
            cbSet.TabIndex = 10;
            cbSet.SelectionChangeCommitted += cbSet_SelectionChangeCommitted;
            // 
            // laSet2
            // 
            laSet2.AutoSize = true;
            laSet2.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            laSet2.Location = new Point(212, 124);
            laSet2.Name = "laSet2";
            laSet2.Size = new Size(42, 35);
            laSet2.TabIndex = 11;
            laSet2.Text = "含";
            // 
            // cbSetNumber1
            // 
            cbSetNumber1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSetNumber1.Enabled = false;
            cbSetNumber1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbSetNumber1.FormattingEnabled = true;
            cbSetNumber1.Location = new Point(272, 121);
            cbSetNumber1.Name = "cbSetNumber1";
            cbSetNumber1.Size = new Size(59, 38);
            cbSetNumber1.TabIndex = 12;
            cbSetNumber1.SelectedIndexChanged += cbSetNumbers_SelectionChangeCommitted;
            // 
            // btnMultBet
            // 
            btnMultBet.Location = new Point(534, 353);
            btnMultBet.Name = "btnMultBet";
            btnMultBet.Size = new Size(90, 38);
            btnMultBet.TabIndex = 13;
            btnMultBet.Text = "多組隨機下注";
            btnMultBet.UseVisualStyleBackColor = true;
            btnMultBet.Click += btnMultBet_Click;
            // 
            // cbSetNumber4
            // 
            cbSetNumber4.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSetNumber4.Enabled = false;
            cbSetNumber4.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbSetNumber4.FormattingEnabled = true;
            cbSetNumber4.Location = new Point(272, 298);
            cbSetNumber4.Name = "cbSetNumber4";
            cbSetNumber4.Size = new Size(59, 38);
            cbSetNumber4.TabIndex = 15;
            cbSetNumber4.SelectedIndexChanged += cbSetNumbers_SelectionChangeCommitted;
            // 
            // cbSetNumber2
            // 
            cbSetNumber2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSetNumber2.Enabled = false;
            cbSetNumber2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbSetNumber2.FormattingEnabled = true;
            cbSetNumber2.Location = new Point(272, 178);
            cbSetNumber2.Name = "cbSetNumber2";
            cbSetNumber2.Size = new Size(59, 38);
            cbSetNumber2.TabIndex = 17;
            cbSetNumber2.SelectedIndexChanged += cbSetNumbers_SelectionChangeCommitted;
            // 
            // cbSetNumber3
            // 
            cbSetNumber3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSetNumber3.Enabled = false;
            cbSetNumber3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbSetNumber3.FormattingEnabled = true;
            cbSetNumber3.Location = new Point(272, 241);
            cbSetNumber3.Name = "cbSetNumber3";
            cbSetNumber3.Size = new Size(59, 38);
            cbSetNumber3.TabIndex = 19;
            cbSetNumber3.SelectedIndexChanged += cbSetNumbers_SelectionChangeCommitted;
            // 
            // cbSetNumber5
            // 
            cbSetNumber5.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSetNumber5.Enabled = false;
            cbSetNumber5.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbSetNumber5.FormattingEnabled = true;
            cbSetNumber5.Location = new Point(272, 353);
            cbSetNumber5.Name = "cbSetNumber5";
            cbSetNumber5.Size = new Size(59, 38);
            cbSetNumber5.TabIndex = 21;
            cbSetNumber5.SelectedIndexChanged += cbSetNumbers_SelectionChangeCommitted;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1;
            timer.Tick += timer_Tick;
            // 
            // plBet
            // 
            plBet.BorderStyle = BorderStyle.FixedSingle;
            plBet.Controls.Add(txbNumbers);
            plBet.Controls.Add(btnBet);
            plBet.Controls.Add(lbInput);
            plBet.Controls.Add(cbSetNumber5);
            plBet.Controls.Add(lbSingle);
            plBet.Controls.Add(cbSetNumber3);
            plBet.Controls.Add(lbMultiple);
            plBet.Controls.Add(cbSetNumber2);
            plBet.Controls.Add(laSet);
            plBet.Controls.Add(cbSetNumber4);
            plBet.Controls.Add(cbSet);
            plBet.Controls.Add(btnMultBet);
            plBet.Controls.Add(laSet2);
            plBet.Controls.Add(cbSetNumber1);
            plBet.Location = new Point(12, 89);
            plBet.Name = "plBet";
            plBet.Size = new Size(637, 576);
            plBet.TabIndex = 25;
            // 
            // plWinner
            // 
            plWinner.BorderStyle = BorderStyle.FixedSingle;
            plWinner.Controls.Add(btnPrize);
            plWinner.Controls.Add(lbPrize2);
            plWinner.Controls.Add(txbPrize);
            plWinner.Controls.Add(lbPrize);
            plWinner.Controls.Add(lbWinnerNum);
            plWinner.Controls.Add(lbWinnerDraw);
            plWinner.Location = new Point(6, 6);
            plWinner.Name = "plWinner";
            plWinner.Size = new Size(547, 466);
            plWinner.TabIndex = 26;
            // 
            // btnPrize
            // 
            btnPrize.Location = new Point(453, 237);
            btnPrize.Name = "btnPrize";
            btnPrize.Size = new Size(76, 38);
            btnPrize.TabIndex = 27;
            btnPrize.Text = "兌獎";
            btnPrize.UseVisualStyleBackColor = true;
            btnPrize.Click += btnPrize_Click;
            // 
            // lbPrize2
            // 
            lbPrize2.AutoSize = true;
            lbPrize2.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbPrize2.Location = new Point(13, 290);
            lbPrize2.Name = "lbPrize2";
            lbPrize2.Size = new Size(83, 35);
            lbPrize2.TabIndex = 28;
            lbPrize2.Text = "中獎 :";
            // 
            // txbPrize
            // 
            txbPrize.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbPrize.Location = new Point(102, 237);
            txbPrize.Name = "txbPrize";
            txbPrize.PlaceholderText = "01,02,03,04,05,06";
            txbPrize.Size = new Size(336, 38);
            txbPrize.TabIndex = 27;
            // 
            // lbPrize
            // 
            lbPrize.AutoSize = true;
            lbPrize.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbPrize.Location = new Point(13, 240);
            lbPrize.Name = "lbPrize";
            lbPrize.Size = new Size(83, 35);
            lbPrize.TabIndex = 26;
            lbPrize.Text = "對獎 :";
            // 
            // lbWinnerNum
            // 
            lbWinnerNum.AutoSize = true;
            lbWinnerNum.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbWinnerNum.Location = new Point(13, 91);
            lbWinnerNum.Name = "lbWinnerNum";
            lbWinnerNum.Size = new Size(130, 35);
            lbWinnerNum.TabIndex = 24;
            lbWinnerNum.Text = "開獎號碼:\r\n";
            // 
            // lbWinnerDraw
            // 
            lbWinnerDraw.AutoSize = true;
            lbWinnerDraw.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbWinnerDraw.Location = new Point(13, 32);
            lbWinnerDraw.Name = "lbWinnerDraw";
            lbWinnerDraw.Size = new Size(130, 35);
            lbWinnerDraw.TabIndex = 6;
            lbWinnerDraw.Text = "開獎期號:";
            // 
            // tabSwitch
            // 
            tabSwitch.Controls.Add(tabPage1);
            tabSwitch.Controls.Add(tabPage2);
            tabSwitch.Location = new Point(655, 64);
            tabSwitch.Name = "tabSwitch";
            tabSwitch.SelectedIndex = 0;
            tabSwitch.Size = new Size(597, 605);
            tabSwitch.TabIndex = 27;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(plWinner);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(589, 577);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "今日獎號";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPrizeView);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(589, 577);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "中獎查詢";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPrizeView
            // 
            dgvPrizeView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrizeView.Location = new Point(15, 131);
            dgvPrizeView.Name = "dgvPrizeView";
            dgvPrizeView.Size = new Size(568, 440);
            dgvPrizeView.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            textBox2.Location = new Point(401, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 38);
            textBox2.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(319, 82);
            label3.Name = "label3";
            label3.Size = new Size(76, 35);
            label3.TabIndex = 14;
            label3.Text = "名稱:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            textBox1.Location = new Point(93, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 38);
            textBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(11, 82);
            label2.Name = "label2";
            label2.Size = new Size(76, 35);
            label2.TabIndex = 12;
            label2.Text = "單號:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(396, 38);
            comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(11, 38);
            label1.Name = "label1";
            label1.Size = new Size(76, 35);
            label1.TabIndex = 2;
            label1.Text = "期號:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabSwitch);
            Controls.Add(plBet);
            Controls.Add(lbdraw);
            Controls.Add(lbData);
            Controls.Add(txbUsename);
            Controls.Add(lbUserName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            plBet.ResumeLayout(false);
            plBet.PerformLayout();
            plWinner.ResumeLayout(false);
            plWinner.PerformLayout();
            tabSwitch.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrizeView).EndInit();
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
        private Label laSet2;
        private ComboBox cbSetNumber1;
        private Button btnMultBet;
        private ComboBox cbSetNumber4;
        private ComboBox cbSetNumber2;
        private ComboBox cbSetNumber3;
        private ComboBox cbSetNumber5;
        private System.Windows.Forms.Timer timer;
        private Panel plBet;
        private Panel plWinner;
        private Label lbWinnerDraw;
        private Label lbWinnerNum;
        private TextBox txbPrize;
        private Label lbPrize;
        private Label lbPrize2;
        private Button btnPrize;
        private TabControl tabSwitch;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dgvPrizeView;
    }
}
