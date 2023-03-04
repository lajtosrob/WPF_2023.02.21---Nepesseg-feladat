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
using WpfAppNepesseg.Model;

namespace WPF_2023._02._21___Nepesseg_feladat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Telepules> telepulesek = new List<Telepules>();

            StreamReader sr = new StreamReader("C:\\Users\\LifebookE736\\source\\repos\\WPF_2023.02.21 - Nepesseg feladat\\WPF_2023.02.21 - Nepesseg feladat\\DATA\\kozerdeku_lakossag_2022.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] tagok = sr.ReadLine().Split(';');
                Telepules ujTelepules = new Telepules(tagok[2],
                    tagok[3],
                    tagok[4],
                    int.Parse(tagok[5].Replace(" ", "")),
                    int.Parse(tagok[6].Replace(" ", ""))
                    );
                telepulesek.Add(ujTelepules);
            }
            sr.Close();

            dgTelepulesek.ItemsSource = telepulesek;
        }
    }
}
