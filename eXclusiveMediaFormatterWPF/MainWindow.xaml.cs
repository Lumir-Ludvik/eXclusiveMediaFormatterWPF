using eXclusiveMediaFormatter.Conversions.MP3.Filterbank;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace eXclusiveMediaFormatterWPF
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            createMusicFileOpenPicker();
        }

        private void convertButon_Click(object sender, RoutedEventArgs e)
        {
            var mp3Filterbank = new MP3Filterbank();
            var result = mp3Filterbank.ReadFile(browseTextBox.Text);
        }

        private async void createMusicFileOpenPicker()
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".mp3";
            //fileDialog.Filter = ".mp3";
            //fileDialog.Filter = ".flac";
            //fileDialog.Filter = ".ogg";
            //fileDialog.Filter = ".wave";
            //fileDialog.Filter = "*";

            var result = fileDialog.ShowDialog();

            if ((bool)result)
            {
                browseTextBox.Text = fileDialog.FileName;
            }
        }

        private async void createFolderFileOpenPicker()
        {
            //var folderPicker = new Windows.Storage.Pickers.FolderPicker();
            //folderPicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.Desktop;
            //folderPicker.FileTypeFilter.Add("*");

            //Windows.Storage.StorageFolder folder = await folderPicker.PickSingleFolderAsync();
            //if (folder != null)
            //{
            //    Windows.Storage.AccessCache.StorageApplicationPermissions.
            //    FutureAccessList.AddOrReplace("PickedFolderToken", folder);
            //    DestinationTextBox.Text = folder.Path;
            //}
            //else
            //{
            //    DestinationTextBox.Text = "Operation cancelled.";
            //}
        }

        private void BrowseButtonDownSender(object sender, KeyEventArgs e)
        {

        }
    }
}
