using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemWork
{
    class Question
    {
        public int Number { get; set; }
        public string Quest { get; set; }
        public int Answer { get; set; }

        public Question(int n, string q, int a)
        {
            Number = n;
            Quest = q;
            Answer = a;
        }

        public override string ToString()
        {
            return String.Format("{0}|{1}|{2}", Number, Quest, Answer);
        }
    }
}
