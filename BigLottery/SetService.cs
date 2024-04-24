using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BigLottery
{
    internal class SetService
    {
        public static BetSlip? CheckSet(string userName, string inputNumbers, int todayOrder)
        {
            inputNumbers = inputNumbers.Trim();
            List<int> numbers = new List<int>();
            Regex regex = new Regex(@"^\d{2},\d{2},\d{2},\d{2},\d{2},\d{2}$");

            //檢測輸入空值
            userName = string.IsNullOrEmpty(userName) ? "guess" : userName;
            if (string.IsNullOrEmpty(inputNumbers))
            {
                MessageBox.Show("請輸入下注號碼");
                return null;
            }

            //檢測輸入格式
            if (!regex.IsMatch(inputNumbers))
            {
                MessageBox.Show("下注數字輸入格式錯誤\n範例:\n 01,06,32,41,42,21");
                return null;
            }
            numbers = Regex.Matches(inputNumbers, @"\d{2}").Select(m => int.Parse(m.Value)).ToList();

            //檢測輸入是否有重複
            if (numbers.Count != numbers.Distinct().Count())
            {
                MessageBox.Show("請勿輸入重複號碼");
                return null;
            }

            //檢測是否為1~49
            if (numbers.Any(m =>  m <= 1 && m >= 49))
            {
                MessageBox.Show("請輸入1~49的數字");
                return null;
            }


            BetSlip betSlip = new(userName, numbers, todayOrder);
            return betSlip;
        }

        //先骰出7個數字再取出特別號
        public static (List<int>, int) SetWinnerNumber()
        {
            Random random = new();
            List<int> winnerNums = [];
            while (winnerNums.Count < 7)
            {
                int randomNum = random.Next(1, 50);
                if (!winnerNums.Contains(randomNum))
                    winnerNums.Add(randomNum);
            }
            int surpriseNum = winnerNums[winnerNums.Count - 1];
            return (winnerNums, surpriseNum);
        }

        //多組包牌使用
        public static List<int> SetMultBetNumber(List<int> betNumbers)
        {
            Random random = new();
            List<int> newNumbers = [.. betNumbers];
            while (newNumbers.Count < 6)
            {
                int randomNum = random.Next(1, 50);
                if (!newNumbers.Contains(randomNum))
                    newNumbers.Add(randomNum);
            }
            return newNumbers;
        }
    }
}
