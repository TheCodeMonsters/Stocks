using Microsoft.Maui.Controls;
using System;

namespace Stocks
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void DXCollectionView_Tap(object sender, CollectionView.CollectionViewGestureEventArgs e)
        {
            var symbolViewModel = (CollectionItemViewModel)e.Item;
            var historicalDataViewModel = new HistoricalDataViewModel(symbolViewModel);
            Navigation.PushAsync(new HistoricalDataPage(historicalDataViewModel));
        }
    }
}