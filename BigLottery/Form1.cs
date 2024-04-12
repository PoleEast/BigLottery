using AngleSharp.Text;
using Newtonsoft.Json;
using System.DirectoryServices;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

namespace BigLottery
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbdraw.Text = DateTime.Now.ToString("第yyyyMMdd期");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BetSlip? betSlip = SetService.CheckSet(txbUsename.Text, txbNumbers.Text);
            if (betSlip != null)
            {
                saveToSql(betSlip);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToString("yyyy年MM月dd日H:mm");
        }
        private void saveToSql(BetSlip betSlip)
        {
            try
            {
                string json = JsonConvert.SerializeObject(betSlip);
                File.WriteAllText("betSlips.json", json);
                MessageBox.Show($"下單成功!!\n\n單號:{betSlip.OrderNumber}");
            }
            catch
            {
                MessageBox.Show("資料庫連線失敗");
            }
        }

        private void btnWinnerNum_Click(object sender, EventArgs e)
        {
            Random random = new Random();
        }
    }
}
