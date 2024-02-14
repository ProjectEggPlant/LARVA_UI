using EPLE.App;
using EPLE.IO;
using DevExpress.Mvvm.CodeGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LARVA_UI.ViewModels;
namespace LARVA_UI.Views
{
    /// <summary>
    /// Interaction logic for ManualView.xaml
    /// </summary>
    public partial class ManualView : UserControl
    {
        private bool result;
        public ManualView()
        {
            InitializeComponent();

            InitButtonColor();
        }

        private void InitButtonColor()
        {

        }

        private void CylinderBackward_Click(object sender, RoutedEventArgs e)
        {
            // 실린더 후진 로직
        }

        private void LedOn_Click(object sender, RoutedEventArgs e)
        {
            // LED On 로직
        }

        private void LedOff_Click(object sender, RoutedEventArgs e)
        {
            // LED Off 로직
        }

        private void FlipReverse_Click(object sender, RoutedEventArgs e)
        {
            // Flip 반전 로직
        }

        private void FlipNormal_Click(object sender, RoutedEventArgs e)
        {
            // Flip 정위치 로직
        }

        private void FlipConvShutter_Click(object sender, RoutedEventArgs e)
        {
            result = DataManager.Instance.SET_INT_DATA(IoNameHelper.iFlip_nOutShutter_UpDown, 1);
        }
    }
}
