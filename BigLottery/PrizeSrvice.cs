using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigLottery
{
    internal static class PrizeSrvice
    {
        public readonly static Dictionary<(int, bool), string> PrizeDictionary;
        static PrizeSrvice()
        {
            PrizeDictionary = new Dictionary<(int, bool), string>
            {
                { (3,true),"恭喜中七獎\n400元"},
                { (3,false),"恭喜中普獎\n400元"},
                { (4,true),"恭喜中六獎\n1000元"},
                { (4,false),"恭喜中五獎\n2000元"},
                { (5,true),"恭喜中四獎\n請至官網查本期金額"},
                { (5,false),"恭喜中三獎\n請至官網查本期金額"},
                { (6,true),"恭喜中二獎\n請至官網查本期金額"},
                { (6,false),"恭喜中頭獎\n請至官網查本期金額"}
            };
        }
    }
}
