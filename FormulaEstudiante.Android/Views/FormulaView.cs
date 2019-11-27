using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using formulaEstudiante.core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace FormulaEstudiante.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class FormulaView : MvxActivity<formulaViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.FormulaPage);
        }
    }

}