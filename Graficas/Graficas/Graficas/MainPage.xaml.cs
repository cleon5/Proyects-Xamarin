using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Graficas
{
    public partial class MainPage : ContentPage
    {

            private readonly List<Microcharts.ChartEntry> _entries = new List<Microcharts.ChartEntry>()
    {
        new Microcharts.ChartEntry(100)
        {
        Label = "Enero",
        ValueLabel = "100",
        Color = SKColor.Parse("#FF0033"),
        },
        new Microcharts.ChartEntry(500)
        {
         Label = "Febrero",
        ValueLabel = "500",
        Color = SKColor.Parse("#FF8000"),
        },
        new Microcharts.ChartEntry(600)
        {
        Label = "Marzo",
        ValueLabel = "600",
         Color = SKColor.Parse("#FFE600"),
        },
        new Microcharts.ChartEntry(250)
        {
        Label = "april",
        ValueLabel = "250",
        Color = SKColor.Parse("#1AB34D"),
        },
        new Microcharts.ChartEntry(150)
        {
        Label = "Mayo",
        ValueLabel = "150",
        Color = SKColor.Parse("#1A66FF"),
        },
        new Microcharts.ChartEntry(550)
        {
        Label = "Junio",
        ValueLabel = "550",
        Color = SKColor.Parse("#801AB3"),
        },
        };

            public MainPage()
        {
            InitializeComponent();
            MyDonutChart.Chart = new DonutChart { Entries = _entries };
            MyBarChart.Chart = new BarChart { Entries = _entries };
            MyPointChart.Chart = new PointChart { Entries = _entries };
            MyRadialGaugeChart.Chart = new RadialGaugeChart { Entries = _entries };
            MyLineChart.Chart = new LineChart { Entries = _entries };
        }

    }
}
