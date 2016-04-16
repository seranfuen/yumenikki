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
using System.Windows.Shapes;
using YumeNikki.Data;

namespace YumeNikki.Windows
{
    /// <summary>
    /// Interaction logic for DreamLayout.xaml
    /// </summary>
    public partial class DreamLayout : Window
    {
        public DreamLayout()
        {
            InitializeComponent();
            this.Test();
        }

        public void Test()
        {
            var dream = new Dream()
            {
                DreamDate = new DateTime(2015, 1, 2)
            };
            DreamLayoutControl.DataContext = dream;
        }
    }
}
