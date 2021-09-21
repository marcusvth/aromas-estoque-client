using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace AromasEstoque
{
    public partial class FromToDatetime : UserControl
    {
        public DateTime From => fromDatePicker.Value;
        public DateTime To => toDatePicker.Value;
        public MetroDateTime FromDatePicker => fromDatePicker;
        public MetroDateTime ToDatePicker => toDatePicker;
        public FromToDatetime()
        {
            InitializeComponent();
        }
    }
}
