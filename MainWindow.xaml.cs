using System;
using System.Diagnostics;
using System.Windows;

namespace HubOffice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Récupérer le nom du fichier
            string[] ligneCommande;

            ligneCommande = Environment.GetCommandLineArgs();
            if (ligneCommande.Length >= 2)
            {
                string fileOpened = ligneCommande[1];
                int fileOpenedNameLength = fileOpened.ToString().Split('\\').Length;
                string fileOpenedName = fileOpened.ToString().Split('\\')[fileOpenedNameLength - 1];
                LabelTitle.Content = fileOpenedName;

                int fileOpenedNameExtLength = fileOpenedName.ToString().Split('.').Length;
                string fileOpenedExt = fileOpenedName.ToString().Split('.')[fileOpenedNameExtLength - 1];
                if(fileOpenedExt == "doc" | fileOpenedExt == "docx")
                {
                    imgMSdoc.Visibility = Visibility.Visible;
                    imgLOdoc.Visibility = Visibility.Visible;
                }
                else if(fileOpenedExt == "xls" | fileOpenedExt == "xlsx")
                {
                    imgMSxls.Visibility = Visibility.Visible;
                    imgLOxls.Visibility = Visibility.Visible;
                }
                else if (fileOpenedExt == "ppt" | fileOpenedExt == "pptx")
                {
                    imgMSppt.Visibility = Visibility.Visible;
                    imgLOppt.Visibility = Visibility.Visible;
                }
                else
                {
                    System.Diagnostics.Process.Start(fileOpened);
                    Close();
                }
            }
            else
            {
                // Aucun fichier n'a été spécifié
                LabelTitle.Content = "ø";
                quLabel.Content = "Aucun fichier n'est ouvert.";
                HubWin.Height = 155;
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MSdocClick(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16\WINWORD.EXE", '"' + Environment.GetCommandLineArgs()[1] + '"');
            Close();
        }

        private void LOdocClick(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files\LibreOffice\program\swriter.exe", '"' + Environment.GetCommandLineArgs()[1] + '"');
            Close();
        }

        private void MSxlsClick(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE", '"' + Environment.GetCommandLineArgs()[1] + '"');
            Close();
        }

        private void LOxlsClick(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files\LibreOffice\program\scalc.exe", '"' + Environment.GetCommandLineArgs()[1] + '"');
            Close();
        }

        private void MSpptClick(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16\POWERPNT.EXE", '"' + Environment.GetCommandLineArgs()[1] + '"');
            Close();
        }

        private void LOpptClick(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files\LibreOffice\program\simpress.exe", '"' + Environment.GetCommandLineArgs()[1] + '"');
            Close();
        }
    }
}
