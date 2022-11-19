using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz1
{
    public partial class exam1 : Component
    {
        public exam1()
        {
            InitializeComponent();
        }

        public exam1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
