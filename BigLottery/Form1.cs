using AngleSharp.Text;
using Newtonsoft.Json;
using System.DirectoryServices;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Numerics;
using Newtonsoft.Json.Linq;

namespace BigLottery
{
    public partial class Form1 : Form
    {
        private List<BetSlip> _betSlips = new();
        private List<WinningSlip>? _winningSlips = new();
        private int nextOrderNum;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbdraw.Text = DateTime.Now.ToString("第yyyyMMdd期");

            //讀取過往的開獎號碼與投注單
            var settings = new JsonSerializerSettings
            {
                DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind // 保留原始的时区信息
            };
            try
            {
                _betSlips = JsonConvert.DeserializeObject<List<BetSlip>>(File.ReadAllText("BetSlips.json"), settings) ?? [];
                _winningSlips = JsonConvert.DeserializeObject<List<WinningSlip>>(File.ReadAllText("WinningSlip.json"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取開獎號碼與投注單錯誤:\n{ex}");
            }


            //獲取最新的訂單號碼
            if (_betSlips.Count != 0)
                nextOrderNum = _betSlips.Max(betSlip => betSlip.Draw) == int.Parse(DateTime.Now.ToString("yyyy") + DateTime.Now.DayOfYear) ?
                   (_betSlips.Max(betSlip => betSlip.OrderNumber) - (int.Parse(DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear + "0000"))) + 1 : 1;
            else nextOrderNum = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BetSlip? betSlip = SetService.CheckSet(txbUsename.Text, txbNumbers.Text, nextOrderNum);
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
                _betSlips.Add(betSlip);
                string json = JsonConvert.SerializeObject(_betSlips, Formatting.Indented);
                File.WriteAllText("BetSlips.json", json);
                nextOrderNum++;
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
            List<int> winnerNums = new List<int>();
            while (winnerNums.Count < 7)
            {
                int randomNum = random.Next(1, 50);
                if (!winnerNums.Contains(randomNum))
                    winnerNums.Add(randomNum);
            }
            int surpriseNum = winnerNums[winnerNums.Count - 1];
            winnerNums.Remove(surpriseNum);
            WinningSlip winningSlip = new(winnerNums, int.Parse(DateTime.Now.ToString("yyyyMMdd")) - 1, surpriseNum);
            lbWinnerNum.Text += string.Join(", ", winningSlip.Numbers.Select(x => x.ToString()));
            lbWinnerNum.Text += $"\n特別號: {surpriseNum}";
            lbWinnerDraw.Text += " " + winningSlip.Draw;
            var WinningSlips = JsonConvert.DeserializeObject<List<WinningSlip>>(File.ReadAllText("WinningSlip.json"));
        }
    }
}
