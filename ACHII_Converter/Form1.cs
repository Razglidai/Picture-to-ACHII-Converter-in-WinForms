using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ACHII_Converter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void SelectImage_Click(object sender, EventArgs e)

        {

            GetPicture.getPicture();
        }

        private void CreateACHII_Art_Click(object sender, EventArgs e)
        {
            bool error = false;
            var bitmap = new Bitmap(GetPicture.openFileDialog.FileName);
            if (Convert.ToInt32(textBox1.Text) > 1024)
            {
                var dialogresult = MessageBox.Show("Ширина больше чем 1250 символов некоректно будет выведена в блокнот.\n Продолжить?", "Предупреждение", MessageBoxButtons.YesNo,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
                if (dialogresult == DialogResult.No) { error = true;  }
            }
          
            if (error != true)
            {
                
                BitmapConvert Pc = new BitmapConvert(bitmap, Convert.ToString(Grad.Text), Convert.ToInt32(textBox1.Text));
                Pc.path = Convert.ToString(textBox2.Text);
                var rows = Pc.bitmapConvert();
                string[] result = new string[Pc.wPicture];
         
           
                    File.WriteAllLines(Pc.path, rows.Select(r => new string(r)));
                
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void ThisNegative_CheckedChanged(object sender, EventArgs e)
        {
            if (ThisNegative.Checked)
            {
                BitmapConvert.IsNegative = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void Grad_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

    ////////////////////////////////////////////////////////////////
    public static class GetPicture
    {

        static public OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG" };
        public static void getPicture()
    {GetPicture.openFileDialog.ShowDialog();}
        //добавить исключение!!!!!!!!!!!

    }
    /////////////////////////////////////////////////////////////
}