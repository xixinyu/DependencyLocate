using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DependencyLocate.Example2;

namespace DependencyLocate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IFactory factory = FactoryContainer.factory;
            IButton button = factory.MakeButton();
            Console.WriteLine("创建 " + button.ShowInfo());

            Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var button = ReflectionFactory.MakeButton();
            Console.WriteLine("创建 " + button.ShowInfo());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestClient t = new TestClient();
            t.Test();
        }
    }
}
