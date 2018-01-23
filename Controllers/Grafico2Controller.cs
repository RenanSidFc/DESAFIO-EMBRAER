using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;

using System.Drawing;

namespace DesafioEmbraer.Controllers
{
    public class Grafico2Controller : Controller
    {
        // GET: Grafico2
        public ActionResult Index()
        {

            Highcharts lineChart = new Highcharts("linechart");

            lineChart.InitChart(new Chart()
            {
                Type = DotNet.Highcharts.Enums.ChartTypes.Line,
                BackgroundColor = new BackColorOrGradient(System.Drawing.Color.AliceBlue),
                Style = "fontWeight: 'bold', fontSize: '17px'",
                BorderColor = System.Drawing.Color.LightBlue,
                BorderRadius = 0,
                BorderWidth = 2

            });
            lineChart.SetTitle(new Title()
            {
                Text = "Grafico de vendas"
            });
            lineChart.SetXAxis(new XAxis()
            {
                Type = AxisTypes.Category,
                Title = new XAxisTitle() { Text = "Meses", Style = "fontWeight: 'bold', fontSize: '17px'" },
                Categories = new[] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" }
            });
            lineChart.SetYAxis(new YAxis()
            {
                Title = new YAxisTitle()
                {
                    Text = "Quantidade",
                    Style = "fontWeight: 'bold', fontSize: '17px'"
                },
                ShowFirstLabel = true,
                ShowLastLabel = true,
                Min = 0
            });
            lineChart.SetLegend(new Legend
            {
                Enabled = true,
                BorderColor = System.Drawing.Color.Blue,
                BorderRadius = 6,
                BackgroundColor = new BackColorOrGradient(ColorTranslator.FromHtml("#FFBCD6D5"))
            });
            lineChart.SetSeries(new Series[]
            {
                new Series{

                    Name = "Produto 1",
                    Data = new Data(new object[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120 })
                },
                new Series()
                {
                    Name = "Produto 2",
                    Data = new Data(new object[] {120, 110, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10})
                },
                 new Series()
                {
                    Name = "Produto 3",
                    Data = new Data(new object[] {60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60})
                }
            }
            );

            return View(lineChart);
        }
    }
}