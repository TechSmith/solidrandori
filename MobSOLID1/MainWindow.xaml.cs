using System.Windows;
using System.Windows.Controls;

namespace MobSOLID1
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      enum VideoOutputType
      {
         None,
         Mp4,
         Avi,
         Mp3
      }
      private VideoOutputType _selectedType = VideoOutputType.None;
      private bool isAudioOnly = false;

      public MainWindow()
      {
         InitializeComponent();
      }

      private void Produce_Click( object sender, RoutedEventArgs e )
      {
         Produce();
      }

      private void Produce()
      {
         switch ( _selectedType )
         {
            case VideoOutputType.Mp4:
               isAudioOnly = false;
               break;
            case VideoOutputType.Avi:
               isAudioOnly = false;
               break;
            case VideoOutputType.Mp3:
               isAudioOnly = true;
               break;
            case VideoOutputType.None:
               MessageBox.Show( "No video output type selected.", "Production Failed", MessageBoxButton.OK, MessageBoxImage.Warning );
               break;
         }
      }

      private void VideoOutputSelection_SelectionChanged( object sender, SelectionChangedEventArgs e )
      {
         switch ( VideoOutputSelection.SelectedIndex )
         {
            case 0:
               _selectedType = VideoOutputType.Mp4;
               break;
            case 1:
               _selectedType = VideoOutputType.Avi;
               break;
            case 2:
               _selectedType = VideoOutputType.Mp3;
               break;
            default:
               _selectedType = VideoOutputType.None;
               return;
         }
      }
   }
}
