﻿#region

using System.Diagnostics;
using System.Windows.Input;
using Sample.Core;
using Sample.Views;
using Tumbaga.Commands;
using Tumbaga.IoC;
using Tumbaga.MVVM;

#endregion

namespace Sample.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private int _result;
        private int _x;
        private int _y;

        public int Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }

        public int X
        {
            get { return _x; }
            set { SetProperty(ref _x, value); }
        }

        public int Y
        {
            get { return _y; }
            set { SetProperty(ref _y, value); }
        }

        public ICommand CalculateCommand
        {
            get { return new RelayCommand<object>(x => { Result = Calculator.Add(X, Y); }); }
        }

        [Inject]
        public NavigateCommand<HelpPage> OpenAboutCommand { get; set; }

        [Inject]
        public Calculator Calculator { get; set; }

        [Inject("hacked")]
        public Calculator HackedCalculator { get; set; }

        protected override void OnLoad()
        {
            Debug.WriteLine("Normal: 1 + 1 = {0}", Calculator.Add(1, 1));
            Debug.WriteLine("Hacked: 1 + 1 = {0}", HackedCalculator.Add(1, 1));
        }
    }
}
