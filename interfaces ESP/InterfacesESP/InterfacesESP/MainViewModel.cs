using CommunityToolkit.Mvvm.Input;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InterfacesESP
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public SeriesCollection SeriesCollection { get; set; }
        public ICommand SelectDayCommand { get; set; }

        public int SelectedDay { get; set; }
        public double[][] GraphValues = new double[][]
        {
            new double[] { 100, 150, 200 },
            new double[] { 120, 180, 220 },
            new double[] { 90, 130, 180 },
            new double[] { 110, 160, 210 },
            new double[] { 130, 190, 240 },
            new double[] { 140, 200, 250 },
            new double[] { 80, 120, 170 }
        };

        public MainViewModel()
        {
            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Profits des sept derniers jours",
                    Values = new ChartValues<double> {
                        GraphValues[0][0] + GraphValues[0][1] + GraphValues[0][2] ,
                        GraphValues[1][0] + GraphValues[1][1] + GraphValues[1][2],
                        GraphValues[2][0] + GraphValues[2][1] + GraphValues[2][2],
                        GraphValues[3][0] + GraphValues[3][1] + GraphValues[3][2],
                        GraphValues[4][0] + GraphValues[4][1] + GraphValues[4][2],
                        GraphValues[5][0] + GraphValues[5][1] + GraphValues[5][2],
                        GraphValues[6][0] + GraphValues[6][1] + GraphValues[6][2] }
                }
            };

            SelectDayCommand = new RelayCommand<int>(OnBarClicked);
        }

        private void OnBarClicked(int index)
        {
                //Sera remplacé par le
                int SelectedWeekDay = index;
                double SelectedDayLevel1 = GraphValues[index][0];
                double SelectedDayLevel2 = GraphValues[index][1];
                double SelectedDayLevel3 = GraphValues[index][2];



        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
