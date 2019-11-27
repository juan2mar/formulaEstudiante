using formulaEstudiante.core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace formulaEstudiante.core.ViewModels
{
    public class formulaViewModel : MvxViewModel
    {
        private readonly ICalculationService _calculationService;
        private double _X1;
        private double _X2;
        private double _a;
        private double _b;
        private double _c;
        private MvxCommand _calculateCommand;


        public formulaViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

       

        public double a
        {
            get => _a;
            set
            {
                _a = value;
            }
        }

        public double b
        {
            get => _b;
            set
            {
                _b = value;
            }
        }
        public double c
        {
            get => _c;
            set
            {
                _c = value;
            }
        }
        public double X1
        {
            get => _X1;
            set
            {
                _X1 = value;
                RaisePropertyChanged(() => X1);
            }
        }
        public double X2
        {
            get => _X2;
            set
            {
                _X2 = value;
                RaisePropertyChanged(() => X2);
            }
        }


        public override async Task Initialize()
        {
            await base.Initialize();

            X1 = 0;
            X2 = 0;
            Calculate();
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        private void Calculate()
        {
            X1 = _calculationService.formulaCalculationX1(a, b, c);
            X2 = _calculationService.formulaCalculationX2(a, b, c);
        }
    }
}
