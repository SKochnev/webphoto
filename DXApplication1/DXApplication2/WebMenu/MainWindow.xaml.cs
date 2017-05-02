using DevExpress.Xpf.Core;
using Microsoft.Win32;
using DevExpress.Mvvm.DataAnnotations;
using System.Windows;
using System;
using WinForms = System.Windows.Forms;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WebMenu.ViewModel;

namespace WebMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
       // public ObservableCollection<Web> Web123 { get; set; }

        public BitmapImage loadImage = new BitmapImage();
        WinForms.FolderBrowserDialog folderBrowser = new WinForms.FolderBrowserDialog();
        private string[] files;
        private string[] directories;
        ObservableCollection<Web> items = new ObservableCollection<Web>();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        [Command]
        private void Way(object sender, RoutedEventArgs e)
        {
            
            DialogResult result = folderBrowser.ShowDialog();

            if (!string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                files = Directory.GetFiles(folderBrowser.SelectedPath);
                directories = Directory.GetDirectories(folderBrowser.SelectedPath);
            }

            //OpenFileDialog myDialog = new OpenFileDialog();
            //myDialog.Filter = "Картинки(*.JPG;*.GIF)|*.JPG;*.GIF" + "|Все файлы(*.*)|*.*";
            //myDialog.CheckFileExists = true;
            //myDialog.Multiselect = true;
            //if (myDialog.ShowDialog() == true)
            //{
            //    txb_FileName = myDialog.FileName;
            //}
        }
        [Command]
        private void Drop(object sender, RoutedEventArgs e)
        {
            loadImage.BeginInit();
            for (int i = 0; i <  (files.Length < 100 ? files.Length: 100); i++)
            {

                
                loadImage.UriSource = new Uri(files[i].ToString());//fileInfo.FullName);
                
                
                items.Add(new Web { Foto = loadImage.ToString(), FotoName = files[i] });//.AddingNewItem();
                dataGrid1.ItemsSource = items;
            }
            loadImage.EndInit();


        }
        
        [Command]
        private void NewPage(object sender, RoutedEventArgs e)
        {

          
                //string[] strAr = new string[dataGrid1.Rows[1].Count];
                //for (int i = 0; i < dataGrid1.Rows[1].Count; i++)
                //{
                //strAr[i] = (int)dataGrid1.Rows[i].Cells["Column0_IndexTable1"].Value;
                //}
                
            
           Web.AddNewPage(files, 1);

        }


    }

}
