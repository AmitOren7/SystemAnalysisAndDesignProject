using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public partial class ClerkMainForm : Form
    {
        private Clerk clerk;
        public ClerkMainForm(Clerk clerk)
        {
            InitializeComponent();
            this.clerk = clerk;
        }
    }
}
