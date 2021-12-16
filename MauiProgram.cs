using DevExpress.Maui.CollectionView;
using DevExpress.Maui.Charts;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;

[assembly: XamlCompilationAttribute(XamlCompilationOptions.Compile)]

namespace Stocks
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureMauiHandlers((handlers) =>
                    handlers.AddHandler(typeof(IDXCollectionView), typeof(DXCollectionViewHandler)))
                .ConfigureMauiHandlers((handlers) =>
                    handlers.AddHandler(typeof(ChartView), typeof(ChartViewHandler)))
                .ConfigureFonts(fonts => fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"));
            return builder.Build();
        }
    }
}