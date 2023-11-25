using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace prog.lab._3
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<BuildingViewModel> buildingViewModels;

        public MainWindow()
        {
            InitializeComponent();

            InitializeBuildings();
        }

        private void InitializeBuildings()
        {
            Building[] buildings = new Building[]
            {
                new Office { Name = "Офісний будинок 1", NumberOfFloors = 10 },
                new Factory { Name = "Завод 1", NumberOfWorkshops = 5 },
                new Office { Name = "Офісний будинок 2", NumberOfFloors = 15 },
                new Factory { Name = "Завод 2", NumberOfWorkshops = 8 },
                new Office { Name = "Офісний будинок 3", NumberOfFloors = 12 }
            };

            buildingViewModels = new ObservableCollection<BuildingViewModel>();
            buildingListBox.ItemsSource = buildingViewModels;

            foreach (var building in buildings)
            {
                buildingViewModels.Add(new BuildingViewModel { Name = building.Name, FoundationHeight = building.FoundationHeight() });
            }
        }

        private void DisplayBuildingInfo()
        {
            double maxFoundationHeight = FindMaxFoundationHeight(buildingViewModels);
            MessageBox.Show($"Максимальна висота фундаменту: {maxFoundationHeight}");
        }

        private double FindMaxFoundationHeight(ObservableCollection<BuildingViewModel> buildings)
        {
            double maxHeight = 0;
            foreach (var building in buildings)
            {
                double height = building.FoundationHeight;
                if (height > maxHeight)
                {
                    maxHeight = height;
                }
            }
            return maxHeight;
        }

        private void ShowResultsButton_Click(object sender, RoutedEventArgs e)
        {
            buildingViewModels.Clear();

            InitializeBuildings();
            DisplayBuildingInfo();
        }
    }
}
