using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System.Windows;

namespace UpdaterThrottlerCrasher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Configure LiveCharts2
            LiveCharts.Configure(config =>
                config
                    // registers SkiaSharp as the library back end
                    // REQUIRED unless you build your own
                    .AddSkiaSharp()

                    // adds the default supported types
                    // OPTIONAL but highly recommend
                    .AddDefaultMappers()

                    // select a theme, default is Light
                    // OPTIONAL
                    //.AddDarkTheme()
                    .AddLightTheme()
            );
        }
    }
}
