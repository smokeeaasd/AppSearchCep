﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AppSearchCep.Controls
{
    public class PageButton : Button
    {
        public Page TargetPage { get; set; }

        public PageButton()
        {
            Clicked += OnClicked;
            this.TextTransform = TextTransform.None;
        }

        private void OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync((Page)Activator.CreateInstance(TargetPage.GetType()));
        }
    }
}
