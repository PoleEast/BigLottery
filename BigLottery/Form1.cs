using AngleSharp.Text;
using Newtonsoft.Json;
using System.DirectoryServices;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Numerics;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.ComponentModel;

namespace BigLottery
{
    public partial class Form1 : Form
    {
        private List<BetSlip> _betSlips = [];
        private List<WinningSlip> _winningSlips = [];
        private int nextOrderNum;
        public int NewWinnerDraw { get; }
        WinningSlip? Newest = null;
        private static List<ComboBox> comboBoxes = [];
        private static List<BetSlip> _prizeSlips = [];

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            NewWinnerDraw = int.Parse(DateTime.Now.ToString("yyyy") + DateTime.Now.DayOfYear) - 1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbdraw.Text = "第" + DateTime.Now.ToString("yyyy") + DateTime.Now.DayOfYear + "期";

            if (!File.Exists("BetSlips.json"))
                try
                { File.Create("BetSlips.json").Close(); }
                catch (Exception ex)
                { MessageBox.Show($"創建開獎號碼與投注單錯誤:\n{ex}"); }

            if (!File.Exists("WinningSlip.json"))
                try
                { File.Create("WinningSlip.json").Close(); }
                catch (Exception ex)
                { MessageBox.Show($"創建開獎號碼與投注單錯誤:\n{ex}"); }

            //讀取過往的開獎號碼與投注單
            var settings = new JsonSerializerSettings
            {
                DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind
            };
            try
            {
                _betSlips = JsonConvert.DeserializeObject<List<BetSlip>>(File.ReadAllText("BetSlips.json"), settings) ?? [];
                _winningSlips = JsonConvert.DeserializeObject<List<WinningSlip>>(File.ReadAllText("WinningSlip.json")) ?? [];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取開獎號碼與投注單錯誤:\n{ex}");
                //throw;
            }


            //獲取最新的訂單號碼
            if (_betSlips.Count != 0)
                nextOrderNum = _betSlips.Max(betSlip => betSlip.Draw) == int.Parse(DateTime.Now.ToString("yyyy") + DateTime.Now.DayOfYear) ?
                   (_betSlips.Max(betSlip => betSlip.OrderNumber) - (int.Parse(DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear + "0000"))) + 1 : 1;
            else nextOrderNum = 1;

            //獲取最新一期中獎單
            if (_winningSlips.Count != 0)
                Newest = _winningSlips.FirstOrDefault(m => m.Draw == NewWinnerDraw);


            //獲取最新一期中獎號碼
            if (Newest == null || _winningSlips.Count == 0)
            {
                var getWinnerNum = SetService.SetWinnerNumber();
                WinningSlip winningSlip = new(getWinnerNum.Item1, getWinnerNum.Item2, NewWinnerDraw);
                saveToJosn(winningSlip);
                Newest = winningSlip;
                lbWinnerNum.Text += string.Join(", ", winningSlip.Numbers.Select(x => x.ToString()));
                lbWinnerNum.Text += $"\n特別號: {winningSlip.SurpriseNum}";
                lbWinnerDraw.Text += " " + winningSlip.Draw;
            }
            else
            {
                lbWinnerNum.Text += string.Join(", ", Newest.Numbers.Select(x => x.ToString()));
                lbWinnerNum.Text += $"\n特別號: {Newest.SurpriseNum}";
                lbWinnerDraw.Text += " " + Newest.Draw;
            }

            //設定包牌cb
            comboBoxes.Add(cbSetNumber1);
            comboBoxes.Add(cbSetNumber2);
            comboBoxes.Add(cbSetNumber3);
            comboBoxes.Add(cbSetNumber4);
            comboBoxes.Add(cbSetNumber5);

            foreach (ComboBox cb in comboBoxes)
                cb.Items.Add("");
            cbSet.Items.Add("");

            for (int i = 1; i < 100; i++)
                cbSet.Items.Add(i);
            for (int i = 1; i < 50; i++)
            {
                foreach (ComboBox cb in comboBoxes)
                {
                    cb.Items.Add(i);
                }
            }

            //開出上一期的獎項
            multPrize();

            //更新中獎圖表
            selectPrizeSlip();
        }
        private void InitializeDataGridView()
        {
            dgvPrizeView.AutoGenerateColumns = false;

            //添加列
            DataGridViewTextBoxColumn userNameColumn = new DataGridViewTextBoxColumn();
            userNameColumn.HeaderText = "Name";
            userNameColumn.DataPropertyName = "UserName";
            dgvPrizeView.Columns.Add(userNameColumn);

            DataGridViewTextBoxColumn numbersColumn = new DataGridViewTextBoxColumn();
            numbersColumn.HeaderText = "Numbers";
            numbersColumn.DataPropertyName = "Numbers";
            numbersColumn.CellTemplate.ValueType = typeof(List<int>);
            dgvPrizeView.Columns.Add(numbersColumn);
            TypeDescriptor.AddAttributes(typeof(List<int>), new TypeConverterAttribute(typeof(IntListConverter)));

            DataGridViewTextBoxColumn orderNumberColumn = new DataGridViewTextBoxColumn();
            orderNumberColumn.HeaderText = "OrderNumber";
            orderNumberColumn.DataPropertyName = "OrderNumber";
            dgvPrizeView.Columns.Add(orderNumberColumn);

            DataGridViewTextBoxColumn drawColumn = new DataGridViewTextBoxColumn();
            drawColumn.HeaderText = "draw";
            drawColumn.DataPropertyName = "draw";
            dgvPrizeView.Columns.Add(drawColumn);

            DataGridViewTextBoxColumn prizeColumn = new DataGridViewTextBoxColumn();
            prizeColumn.HeaderText = "prize";
            prizeColumn.DataPropertyName = "prize";
            dgvPrizeView.Columns.Add(prizeColumn);

            dgvPrizeView.DataSource = _betSlips;
        }

        private void selectPrizeSlip()
        {
            _prizeSlips = _betSlips;

            dgvPrizeView.DataSource = null;
            dgvPrizeView.DataSource = _prizeSlips;
        }
        private void btnBet_Click(object sender, EventArgs e)
        {
            BetSlip? betSlip = SetService.CheckSet(txbUsename.Text, txbNumbers.Text, nextOrderNum);
            if (betSlip != null)
            {
                saveToJosn(betSlip);
                MessageBox.Show($"下單成功!!\n\n單號:{betSlip.OrderNumber}");
            }
        }
        private void btnPrize_Click(object sender, EventArgs e)
        {
            //Test 19,27,24,35,11,18
            var setSlip = SetService.CheckSet("", txbPrize.Text, 0);
            if (setSlip == null) return;
            List<int>? numbers = setSlip.Numbers;
            if (Newest != null)
                lbPrize2.Text = singlePrize(numbers, Newest);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //lbData.Text = DateTime.Now.ToString("yyyy年MM月dd日H:mm");
        }

        private void saveToJosn(BetSlip betSlip)
        {
            try
            {
                _betSlips.Add(betSlip);
                string json = JsonConvert.SerializeObject(_betSlips, Formatting.Indented);
                File.WriteAllText("BetSlips.json", json);
                nextOrderNum++;
            }
            catch
            {
                MessageBox.Show("資料庫連線失敗");
            }
        }

        private void saveToJosn(WinningSlip winningSlip)
        {
            try
            {
                _winningSlips.Add(winningSlip);
                string json = JsonConvert.SerializeObject(_winningSlips, Formatting.Indented);
                File.WriteAllText("WinningSlip.json", json);
                nextOrderNum++;
            }
            catch
            {
                MessageBox.Show("資料庫連線失敗");
            }
        }

        private string singlePrize(List<int> betNumbers, WinningSlip winnerNumber)
        {
            bool hasSpecialNumber = false;
            var prizeNum = betNumbers.Intersect(winnerNumber.Numbers).ToList();
            hasSpecialNumber = betNumbers.Contains(winnerNumber.SurpriseNum);
            if (!PrizeSrvice.PrizeDictionary.ContainsKey(((prizeNum.Count, hasSpecialNumber))))
                return "未中獎!下次努力~";
            else return PrizeSrvice.PrizeDictionary[(prizeNum.Count, hasSpecialNumber)];
        }

        private void multPrize()
        {
            List<BetSlip> PrizebetSlips = _betSlips.Where(m => m.Draw == NewWinnerDraw).ToList();
            if (Newest != null)
                foreach (BetSlip betSlip in PrizebetSlips)
                {
                    betSlip.Prize = singlePrize(betSlip.Numbers, Newest);
                }
        }

        private void cbSet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbSet.Text))
            {
                foreach (var cb in comboBoxes)
                {
                    cb.Enabled = false;
                    cb.SelectedIndex = 0;
                }
            }
            else
                comboBoxes[0].Enabled = true;
        }
        private void cbSetNumbers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (sender is not ComboBox cb || !comboBoxes.Contains(cb)) return;
            var index = comboBoxes.IndexOf(cb);
            if (string.IsNullOrEmpty(cb.Text))
                foreach (var item in comboBoxes)
                {
                    if (comboBoxes.IndexOf(item) > index)
                    {
                        item.SelectedIndex = 0;
                        item.Enabled = false;
                    }
                }
            else if (index != (comboBoxes.Count - 1))
                comboBoxes[index + 1].Enabled = true;
        }

        private void btnMultBet_Click(object sender, EventArgs e)
        {
            List<List<int>> bets = new List<List<int>>();
            List<int> betNumbers = new List<int>();
            int NumOfBets = cbSet.SelectedIndex < 1 ? 1 : cbSet.SelectedIndex;

            foreach (var cb in comboBoxes)
                if (cb.Enabled && cb.SelectedIndex > 0)
                    betNumbers.Add(cb.SelectedIndex);
            for (int i = 0; i < NumOfBets; i++)
                bets.Add(SetService.SetMultBetNumber(betNumbers));

            var userName = string.IsNullOrEmpty(txbUsename.Text) ? "guess" : txbUsename.Text;
            //將多組號碼存到json裡面
            try
            {
                foreach (var bet in bets)
                    saveToJosn(new BetSlip(userName, bet, nextOrderNum));
                int ordernum = int.Parse(DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear + nextOrderNum.ToString("0000"));
                MessageBox.Show($"下單成功!!\n開始單號: {ordernum - NumOfBets + 1} 至 {ordernum}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"資料庫連線失敗\n{ex}");
            }
        }
    }
}
