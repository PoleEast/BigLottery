using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigLottery
{
    internal class WinningSlip
    {
        private int _surpriseNum;
        private List<int> _numbers;
        private int _draw = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

        public List<int> Numbers { get { return _numbers; } }
        public int Draw { get { return _draw; } }
        public int SurpriseNum { get { return _surpriseNum; } }

        public WinningSlip(List<int> numbers, int draw, int surprise)
        {
            _numbers = numbers;
            _draw = draw;
            _surpriseNum = surprise;
        }
    }
}
