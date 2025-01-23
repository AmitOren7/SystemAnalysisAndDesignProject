using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SystemAnalysisAndDesignProject
{
    public partial class CreateVehicle : Form
    {
        private OperationalManagerMainForm OperationalManagerMainForm;
        public CreateVehicle(OperationalManagerMainForm operationalManagerMainForm)
        {
            InitializeComponent();
            populatecombobox1();
            populatecombobox2();
            OperationalManagerMainForm = operationalManagerMainForm;
            save.Visible = true;
            pictureBox2.Visible = true;

        }

        private void populatecombobox1 ()
        {
            vehicletypebox.DataSource = Enum.GetValues(typeof(VehicleType));
        }

        private void populatecombobox2 ()
        {
            cargotypebox.DataSource = Enum.GetValues(typeof(CargoType));
        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(IDtext.Text) || string.IsNullOrEmpty(maxcapacitytext.Text) || vehicletypebox.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(testdatetext.Text) || cargotypebox.SelectedIndex == -1)
                {
                    MessageBox.Show("All fields must be filled out before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Vehicle vehicle = new Vehicle(IDtext.Text, (VehicleType)vehicletypebox.SelectedItem, float.Parse(maxcapacitytext.Text), DateTime.Parse(testdatetext.Text), VehicleConditionStatus.proper, (CargoType)cargotypebox.SelectedItem, true);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.OperationalManagerMainForm.Show();
        }

        private void FormHeadline_Click(object sender, EventArgs e)
        {

        }

        private void CreateVehicle_Load(object sender, EventArgs e)
        {

        }

        private void testdatetext_TextChanged(object sender, EventArgs e)
        {
            string input = testdatetext.Text;

            if (DateTime.TryParseExact(input, "yyyy-MM-dd HH:mm:ss",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime result))
            {
                testdatetext.BackColor = Color.White; // שינוי צבע הרקע ל"תקין"
            }
            else
            {
                testdatetext.BackColor = Color.LightPink; 
            }
        }
    }
}
