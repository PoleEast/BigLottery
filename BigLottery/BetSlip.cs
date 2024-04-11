using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BigLottery
{
    internal class BetSlip
    {
        private string _username;
        private List<int> _numbers;
        private DateTime _data = DateTime.Now;
        private int _orderNumber = int.Parse(DateTime.Now.ToString("yyyyMMddHH"));
        private int _draw = int.Parse(DateTime.Now.ToString("yyyy"));

        public string UserName { get { return _username; } }
        public List<int> Number { get { return _numbers; } }
        public DateTime Data { get { return _data; } }
        public int OrderNumber { get { return _orderNumber; } }
        public int Draw { get { return _draw; } }

        public BetSlip(string username, List<int> numbers)
        {
            _numbers = numbers;
            _username = username;
        }
    }

}
