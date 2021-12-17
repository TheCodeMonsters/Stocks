using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using DevExpress.Maui.CollectionView;
using DevExpress.Maui.Charts;

namespace Stocks
{
    public class MauiProgram
	{
		public static MauiApp CreateMauiApp() {

			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts => {
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				})
				.ConfigureMauiHandlers(handlers => handlers.AddHandler<ChartView, ChartViewHandler>())
				.ConfigureMauiHandlers(handlers => handlers.AddHandler<IDXCollectionView, DXCollectionViewHandler>());

			return builder.Build();
		}
	}
}