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
    public partial class AddNewQuestionForm : Form
    {
        private OfficeManager officeManager;

        public AddNewQuestionForm(OfficeManager officeManager)
        {
            this.officeManager = officeManager;
            InitializeComponent();
        }

        private void AddNewQuestionForm_Load(object sender, EventArgs e)
        {
            NewQuestionCard card = new NewQuestionCard();
            flowLayoutPanel1.Controls.Add(card);
        }
    }
}
