using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AngleSharp.Dom;
using Newtonsoft.Json;

namespace BigLottery
{
    internal class BetSlip
    {
        public string UserName { get; }
        public List<int> Numbers { get; }
        public string Date { get; }
        public int OrderNumber { get; }
        public int Draw { get; }
        public string Prize { get; set; }

        public BetSlip(string username, List<int> numbers, int todayOrder)
        {
            Numbers = numbers;
            UserName = username;
            Prize = "未開獎";
            OrderNumber = int.Parse(DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear + todayOrder.ToString("0000"));
            Draw = int.Parse(DateTime.Now.ToString("yyyy") + DateTime.Now.DayOfYear);
            Date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
        }

        [JsonConstructor]
        public BetSlip(string username, List<int> numbers, string date, int ordernumber, int draw,string prize)
        {
            Numbers = numbers;
            UserName = username;
            OrderNumber = ordernumber;
            Draw = draw;
            Date = date;
            Prize= prize;
        }
    }
}
