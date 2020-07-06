using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> carReports = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = carReports;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var RadioButtonChecked_InGroup = groupBox1.Controls.OfType<RadioButton>()
        .SingleOrDefault(rb => rb.Checked == true);

            CarReport obj = new CarReport()
            {
                CreatedData = dtpDay.Value,
                Author = cbName.ToString(),
                Maker = (CarMaker)Enum.ToObject(typeof(CarMaker), RadioButtonChecked_InGroup.Text)



        };
        }

        private void btOpenPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void btDeletePicture_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
