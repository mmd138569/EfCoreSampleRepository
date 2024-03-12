using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace EFCoreSample
{
    public class MainWindowBase : Window
    {
        public static readonly DependencyProperty SinaProperty = DependencyProperty.Register(
            nameof(Sina), typeof(string), typeof(MainWindowBase));


        public string Sina
        {
            get => (string)this.GetValue(SinaProperty);
            set => this.SetValue(SinaProperty, value);
        }

    }
}
