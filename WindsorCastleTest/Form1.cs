using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Castle.Windsor;

namespace WindsorCastleTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CREATE A WINDSOR CONTAINER OBJECT AND REGISTER THE INTERFACES, AND THEIR CONCRETE IMPLEMENTATIONS.
            var container = new WindsorContainer();
            container.AddComponent("Main", typeof(Main));
            container.AddComponent("Dependency1", typeof(IDependency1), typeof(Dependency1));
            container.AddComponent("Dependency2", typeof(IDependency2), typeof(Dependency2));

            // CREATE THE MAIN OBJECT AND INVOKE ITS METHOD(S) AS DESIRED.
            Main MainThing = container.Resolve<Main>();
            MainThing.DoSomething();
        }
    }
}
