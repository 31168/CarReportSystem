using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
            Until();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

 



        private void btOpenPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        } //画像オープン

        private void btDeletePicture_Click(object sender, EventArgs e) //画像削除
        {
            pictureBox1.Image = null;
        }　



        private void button1_Click(object sender, EventArgs e)  //レポート追加
        {



            CarReport obj = new CarReport()
            {
                CreatedData = dtpDay.Value,
                Author = cbName.Text.ToString(),
                Maker = CheckMaker(),
                Name = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pictureBox1.Image

            };

            cbName.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            pictureBox1.Image = null;




            carReports.Insert(0, obj);
            Until();

        }
        private void btDeleteReport_Click(object sender, EventArgs e) //レポート削除
        {
            if (dataGridView1.SelectedRows.Count <= 0)
                return;

            carReports.RemoveAt(dataGridView1.CurrentRow.Index);
            Until();
        }

        private void btRemakeReport_Click(object sender, EventArgs e) // レポート修正
        {
            if (dataGridView1.SelectedRows.Count <= 0)
                return;

       

            CarReport obj = new CarReport()
            {
                CreatedData = dtpDay.Value,
                Author = cbName.Text.ToString(),
                Maker = CheckMaker(),
                Name = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pictureBox1.Image
            };

            carReports[dataGridView1.CurrentRow.Index] = obj;

            Until();


        }

        private void DeleteText() 
        {
            cbName.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            pictureBox1.Image = null;
        }



        private void btOpenReport_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFileDialog2.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化して読み込む
                        carReports = (BindingList<CarReport>)formatter.Deserialize(fs);
                        //データグリッドビューに再設定
                        dataGridView1.DataSource = carReports;
                        //選択されている箇所を各コントロールへ表示
                        dataGridView1_Click(sender, e);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        } //データ開く

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs, carReports);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }//データ保存

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null  )
                return;

            //選択したレコードを取り出す
            //データグリッドビューで選択した行のインデックスを元に
            //BindingListのデータを取得する
            CarReport selectedCar = carReports[dataGridView1.CurrentRow.Index];


            dtpDay.Value = selectedCar.CreatedData;
            cbName.Text = selectedCar.Author;
            cbCarName.Text = selectedCar.Name;
            tbReport.Text = selectedCar.Report;
            pictureBox1.Image = selectedCar.Picture;


            //チェックボックス選択

            


            switch (selectedCar.Maker)
            {
                case CarMaker.トヨタ:
                    toyota.Checked = true;
                    break;

                case CarMaker.ホンダ:
                    honda.Checked = true;
                    break;

                case CarMaker.スバル:
                    subaru.Checked = true;
                    break;

                case CarMaker.日産:
                    nissan.Checked = true;
                    break;

                case CarMaker.外車:
                    gaisya.Checked = true;
                    break;

                default:
                    sonota.Checked = true;
                    break;
            }

        } //選択したデータテキストに表示

        private void Until()
        {
            if (carReports.Count > 0)
            {
                btRemakeReport.Enabled = true;
                btDeleteReport.Enabled = true;
            }
            else
            {
                btRemakeReport.Enabled = false;
                btDeleteReport.Enabled = false;
            }

            toyota.Checked = false;
            subaru.Checked = false;
            nissan.Checked = false;
            honda.Checked = false;
            gaisya.Checked = false;
            sonota.Checked = true;

            dataGridView1.ClearSelection();
        }//削除、変更ボタン非表示

        public CarMaker CheckMaker()
        {
            var RadioButtonChecked_InGroup = groupBox1.Controls.OfType<RadioButton>()
                    .SingleOrDefault(rb => rb.Checked == true);

            toyota.Checked = false;
            subaru.Checked = false;
            nissan.Checked = false;
            honda.Checked = false;
            gaisya.Checked = false;
            sonota.Checked = false;

            switch (RadioButtonChecked_InGroup.Text)
            {
                case "トヨタ":
                    return CarMaker.トヨタ;


                case "日産":
                    return CarMaker.日産;


                case "ホンダ":
                    return CarMaker.ホンダ;


                case "スバル":
                    return CarMaker.スバル;


                case "外車":
                    return CarMaker.外車;



                default:
                    return CarMaker.その他;


            }
        } //チェックめかー

    }
}
