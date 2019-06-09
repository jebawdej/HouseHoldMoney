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

namespace ObservableConvertor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string publicPropertyName { get; set; }
        string privatePropertyName { get; set; }

        string dataType { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertToObservableProperty_Click(object sender, RoutedEventArgs e)
        {
            publicPropertyName = this.PropertyNameText.Text;
            dataType = this.DataTypeText.Text;
            privatePropertyName = "_" + publicPropertyName[0].ToString().ToLower() + publicPropertyName.Substring(1);
            StringBuilder sb = new StringBuilder(String.Format("private {0} {1};\r\n", dataType, privatePropertyName));
            sb.AppendLine(String.Format("public {0} {1}", dataType, publicPropertyName));
            sb.AppendLine("{");
            sb.AppendLine("\tget");
            sb.AppendLine("\t{");
            sb.AppendLine(String.Format("\t\treturn {0};", privatePropertyName));
            sb.AppendLine("\t}");
            sb.AppendLine("\tset");
            sb.AppendLine("\t{");
            sb.AppendLine(String.Format("\t\tSet<{0}>(() => this.{1}, ref {2}, value);", dataType, publicPropertyName, privatePropertyName));
            sb.AppendLine("\t}");
            sb.AppendLine("}");

            string s = sb.ToString();
            System.Windows.Clipboard.SetText(s);
            //private string _country;
            //public string Country
            //{
            //    get
            //    {
            //        return _country;
            //    }
            //    set
            //    {
            //        Set<string>(() => this.Country, ref _country, value);
            //        RaisePersonChanged();
            //    }
            //}

        }
        private void ConvertToVmProperty_Click(object sender, RoutedEventArgs e)
        {
            publicPropertyName = this.PropertyNameText.Text;
            dataType = this.DataTypeText.Text;
            privatePropertyName = "_" + publicPropertyName[0].ToString().ToLower() + publicPropertyName.Substring(1);
            StringBuilder sb = new StringBuilder(String.Format("private {0} {1};\r\n", dataType, privatePropertyName));
            sb.AppendLine(String.Format("public {0} {1}", dataType, publicPropertyName));
            sb.AppendLine("{");
            sb.AppendLine("\tget");
            sb.AppendLine("\t{");
            sb.AppendLine(String.Format("\t\treturn {0};", privatePropertyName));
            sb.AppendLine("\t}");
            sb.AppendLine("\tset");
            sb.AppendLine("\t{");
            sb.AppendLine(String.Format("\t\tif(value != {0})", privatePropertyName));
            sb.AppendLine("\t\t{");
            sb.AppendLine(String.Format("\t\t\t{0} = value;", privatePropertyName));
            sb.AppendLine(String.Format("\t\t\tRaisePropertyChanged(\"{0}\");", publicPropertyName));
            sb.AppendLine("\t\t}");
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            string s = sb.ToString();
            System.Windows.Clipboard.SetText(s);

            //private string _title;
            //public string Title
            //{

            //    get
            //    {
            //        return _title;
            //    }
            //    set
            //    {
            //        if (value != _title)
            //        {
            //            _title = value;
            //            RaisePropertyChanged("Title");
            //        }
            //    }
            //}
        }
    }
}
