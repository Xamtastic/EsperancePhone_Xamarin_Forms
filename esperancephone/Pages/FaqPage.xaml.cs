﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using esperancephone.Extensions;
using esperancephone.Ioc;
using esperancephone.ViewModels;
using Xamarin.Forms;

namespace esperancephone.Pages
{
    public partial class FaqPage : ContentPage
    {
        public FaqPage()
        {
            InitializeComponent();

            using (var scope = AppContainer.Container.BeginLifetimeScope())
            {
                this.BindingContext = AppContainer.Container.Resolve<FaqViewModel>();
            }

            this.WriteLineInstanceAndInstanceId();

            ((StandardViewModel)this.BindingContext).Navigator = (INavigation)this.Navigation;

        }
    }
}
