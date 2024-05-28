using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.ViewModels
{
    public partial class GameViewModel: ObservableObject
    {
        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _score;

        [ObservableProperty]
        private string _result;

        [ObservableProperty]
        private string _playerChoice;

        



    }
}
