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
        public static BetSlip? CheckSet(string userName, string inputNumbers)
        {
            inputNumbers = inputNumbers.Trim();
            List<int> numbers = new List<int>();
            Regex regex = new Regex(@"^\d{2},\d{2},\d{2},\d{2},\d{2},\d{2},\d{2}$");

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
                Console.WriteLine("下注數字輸入格式錯誤\n範例:\n 01,06,32,41,42,21,02");
                return null;
            }
            numbers = Regex.Matches(inputNumbers, @"\d{2}").Select(m => int.Parse(m.Value)).ToList();

            //檢測輸入是否有重複
            if (numbers.Count != numbers.Distinct().Count())
            {
                MessageBox.Show("請勿輸入重複號碼");
                return null;
            }

            BetSlip betSlip = new(userName, numbers);
            return betSlip;
        }
    }
}
