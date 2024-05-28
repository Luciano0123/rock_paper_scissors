using Java.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Models
{
    internal class Player
    {
        public int Name { get; set; }
        public string Score { get; set; }
        public Choice2 Choice2 { get; set; }

        public void MakeChoice()
        {
            Choice2 = (Choice2) new Random().Next(3);
        }

    }
}
