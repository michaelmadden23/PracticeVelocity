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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PracticeVelocityProject.Classes;
using PracticeVelocityProject.Enums;

namespace PracticeVelocityProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            const int numberOfStrings = 100;

            InitializeComponent();

            List<String> eventsList = EventOptions.getEvents();
            UIEventPicker.SetBinding(ComboBox.ItemsSourceProperty, new Binding() { Source = eventsList });

            UIGenerate.Click += (o, a) =>
            {
                var comboBoxValue = UIEventPicker.SelectedItem;
                String[] stringsToPrint = new String[numberOfStrings];
                Diagnose diagnose = new Diagnose();
                Register register = new Register();

                if (comboBoxValue != null)
                {
                    switch (comboBoxValue.ToString())
                    {
                        case "Register":
                            stringsToPrint = register.StringsToPrint(100);
                            break;
                        case "Diagnose":
                            stringsToPrint = diagnose.StringsToPrint(100);
                            break;
                        default:
                            break;
                    }
                    AllStrings.ItemsSource = stringsToPrint;
                }

            };

            UIClear.Click += (o, a) =>
            {
                AllStrings.ItemsSource = null;
            };

        }
    }
}
