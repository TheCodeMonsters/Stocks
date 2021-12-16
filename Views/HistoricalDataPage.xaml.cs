using Microsoft.Maui.Controls;
using System;

namespace Stocks {
    public partial class HistoricalDataPage : ContentPage {
        public HistoricalDataPage(HistoricalDataViewModel viewModel) {
            InitializeComponent();
            BindingContext = viewModel;
            Title = viewModel.Item.Ticker;
        }
    }
}