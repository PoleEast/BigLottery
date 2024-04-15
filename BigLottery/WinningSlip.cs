using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BigLottery
{
    internal class WinningSlip
    {
        public List<int> Numbers { get; }
        public int Draw { get;  }
        public int SurpriseNum { get; }

        [JsonConstructor]
        public WinningSlip(List<int> numbers, int surpriseNum, int draw)
        {
            Numbers = numbers;
            SurpriseNum = surpriseNum;
            Draw = draw;
        }
    }
}
