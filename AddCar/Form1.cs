using System.Windows.Forms;
using System.Xml.Linq;

namespace AddCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car a = new Car();
            try { a.setName(txtName.Text); }
            catch (Exception ex)
            {
                MessageBox.Show("enter the name of the car correctly", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try { a.setId(Convert.ToInt32(txtId.Text)); }
            catch (Exception ex)
            {
                MessageBox.Show("enter the id of the car correctly", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try { a.setYears(Convert.ToInt32(txtYears.Text)); }
            catch (Exception ex)
            {
                MessageBox.Show("enter the years of the car correctly", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try { a.setModel(txtModel.Text); }
            catch (Exception ex)
            {
                MessageBox.Show("enter the model of the car correctly", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try { a.setColor(txtColor.Text); }
            catch (Exception ex)
            {
                MessageBox.Show("enter the color of the car correctly", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            listBox.Items.Add("car id : " + a.getId());
            listBox.Items.Add("car name :" + a.getName());
            listBox.Items.Add("car years :" + a.getYears());
            listBox.Items.Add("car model : " + a.getModel());
            listBox.Items.Add("car color : " + a.getColor());
            listBox.Items.Add("-------------------------------");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
