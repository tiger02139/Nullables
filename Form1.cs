using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nullables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void Display(Nullable<int> x)
        {
            Console.WriteLine($"HasValue: {x.HasValue}");
            if (x.HasValue)
            {
                Console.WriteLine($"Value: {x.Value}");
                Console.WriteLine($"Explicit conversion: {(int)x}");
            }
            Console.WriteLine($"GetValueOrDefault(): {x.GetValueOrDefault()}");
            Console.WriteLine($"GetValueOrDefault(10): {x.GetValueOrDefault(10)}");
            Console.WriteLine($"ToString(): \"{x.ToString()}\"");
            Console.WriteLine($"GetHashCode(): {x.GetHashCode()}");
            Console.WriteLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nullable<int> x = 5;
            x = new Nullable<int>(5);
            Console.WriteLine("Instance with value:");
            Display(x);

            x = new Nullable<int>();
            Console.WriteLine("Instance without value:");
            Display(x);
        }

        
    }
}
