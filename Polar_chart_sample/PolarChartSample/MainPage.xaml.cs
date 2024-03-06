using Syncfusion.Maui.Charts;

namespace PolarChartSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //this.BindingContext = new ViewModel();
            //SfPolarChart polarChart = new SfPolarChart();
            //polarChart.Title = new Label() { Text = "Plant Analysis", HorizontalTextAlignment = TextAlignment.Center };
            //polarChart.Legend = new ChartLegend();
            //polarChart.PrimaryAxis = new CategoryAxis();
            //polarChart.SecondaryAxis = new NumericalAxis();

            //PolarAreaSeries series1 = new PolarAreaSeries()
            //{
            //    ItemsSource = (new ViewModel()).PlantDetails,
            //    XBindingPath = "Direction",
            //    YBindingPath = "Tree",
            //    Label = "Tree",
            //    EnableTooltip = true,
            //    ShowDataLabels = true,
            //};

            //PolarAreaSeries series2 = new PolarAreaSeries()
            //{
            //    ItemsSource = (new ViewModel()).PlantDetails,
            //    XBindingPath = "Direction",
            //    YBindingPath = "Weed",
            //    Label = "Weed",
            //    EnableTooltip = true,
            //    ShowDataLabels = true,
            //};

            //PolarAreaSeries series3 = new PolarAreaSeries()
            //{
            //    ItemsSource = (new ViewModel()).PlantDetails,
            //    XBindingPath = "Direction",
            //    YBindingPath = "Flower",
            //    Label = "Flower",
            //    EnableTooltip = true,
            //    ShowDataLabels = true,
            //};

            //polarChart.Series.Add(series1);
            //polarChart.Series.Add(series2);
            //polarChart.Series.Add(series3);
            //this.Content = polarChart;
        }
    }
}
