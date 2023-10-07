using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls; 
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media; // Brushes, Colors
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void handleClearCanva(object sender, RoutedEventArgs e)
        {
            canvas_container.Children.Clear();
        }

        private void handleCreatePolyline(object sender, RoutedEventArgs e)
        {
            // Create a Polygon
            Polyline myPolyline = new Polyline();
            myPolyline.Stroke = Brushes.Black;
            
            myPolyline.StrokeThickness = 2;

            // Create a collection of points for the Polygon
            PointCollection myPointCollection = new PointCollection();

            double x1 = Convert.ToDouble(point_x1.Text);
            double y1 = Convert.ToDouble(point_y1.Text);
            double x2 = Convert.ToDouble(point_x2.Text);
            double y2 = Convert.ToDouble(point_y2.Text);
            double x3 = Convert.ToDouble(point_x3.Text);
            double y3 = Convert.ToDouble(point_y3.Text);
            double x4 = Convert.ToDouble(point_x4.Text);
            double y4 = Convert.ToDouble(point_y4.Text);
            double x5 = Convert.ToDouble(point_x5.Text);
            double y5 = Convert.ToDouble(point_y5.Text);

            myPointCollection.Add(new Point(x1, y1));
            myPointCollection.Add(new Point(x2, y2));
            myPointCollection.Add(new Point(x3, y3));
            myPointCollection.Add(new Point(x4, y4));
            myPointCollection.Add(new Point(x5, y5));

            // Set Polygon.Points to the PointCollection
            myPolyline.Points = myPointCollection;
            canvas_container.Children.Add(myPolyline);
        }
    }
}