using System;
using System.Collections.Generic;
using DeliverApp.Mobile.Models;
using DeliverApp.Mobile.Models.Enums;
using Xamarin.Forms;

namespace DeliverApp.Mobile.Controls
{
    public partial class DeliveringCard : Grid
    {
        #region Bindable Properties
        public DeliverModel Deliver { get; set; }

        public static readonly BindableProperty CardTypeProperty = BindableProperty.Create(nameof(Deliver), typeof(DeliverModel), typeof(DeliveringCard));

        #endregion

        public DeliveringCard()
        {
            InitializeComponent();
        }
    }
}

