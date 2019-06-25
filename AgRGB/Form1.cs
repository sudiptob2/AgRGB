using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void detectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void imageAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        public void openImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void leafAnalysisToolStripMenuItem1_Click(object sender, EventArgs e)
        {  
      
        }

        private void riceLeafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(1);
            f2.label2.Text = "Wellcome to Rice Leaf Analysis";
            this.Hide();
            f2.ShowDialog();
        }

        private void mungbeanLeafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(3);
            f2.label2.Text = "Wellcome to Mungbean Analysis";
            this.Hide();
            f2.ShowDialog();
        }

        private void riceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(1);
            f2.label2.Text = "Wellcome to Rice Analysis";
            this.Hide();
            f2.ShowDialog();
        }

        private void mungbeanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(3);
            f2.label2.Text = "Wellcome to Mungbean Analysis";
            this.Hide();
            f2.ShowDialog();
        }

        private void riceDiseaseDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(2);
            f2.label2.Text = "Wellcome to Rice Disease Detection";
            this.Hide();
            f2.ShowDialog();
        }

        private void mungbeanDiseaseDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(4);
            f2.label2.Text = "Wellcome to Mungbean Disease Detection";
            this.Hide();
            f2.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
        }

        private void riceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void riceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void bacterialBlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Disease_Info fdi = new Form_Disease_Info();
            fdi.label1.Text = "Bacterial Blight";
            fdi.textBox1.Text = "Bacterial blight is a bacterial disease which is caused by bacterium called Xanthomonas oryzae pathovar oryzae.The basic symptom of bacterial blight is the wilting of seedlings and yellowing and drying of leaves.";
            fdi.pictureBox1.Image = AgRGB.Properties.Resources.BB1;
            fdi.pictureBox2.Image = AgRGB.Properties.Resources.BB2;
            fdi.pictureBox3.Image = AgRGB.Properties.Resources.BB3;
            this.Hide();
            fdi.ShowDialog();
        }

        private void brownSpotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Disease_Info fdi = new Form_Disease_Info();
            fdi.label1.Text = "Brown Spot";
            fdi.textBox1.Text = "Brown Spot is a fungal disease caused by Bipolaris oryzae. The basic symptom is the formation of minute spot on the leaf blade,leaft sheath,etc which later becomes cylindrical or oval dark brown or black spots.";
            fdi.pictureBox1.Image = AgRGB.Properties.Resources.BS1;
            fdi.pictureBox2.Image = AgRGB.Properties.Resources.BS2;
            fdi.pictureBox3.Image = AgRGB.Properties.Resources.BS4;
            this.Hide();
            fdi.ShowDialog();
        }

        private void riceBlastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Disease_Info fdi = new Form_Disease_Info();
            fdi.label1.Text = "Rice Blast";
            fdi.textBox1.Text = "Blast is a fungal disease which is caused by the fungus called Magnaporthe oryzae. All the parts above the ground can be affected by rice blast. The basic symptom is Diamond - shaped or elliptical or spindle-shaped spots with gray or white centers and brown margins";
            fdi.pictureBox1.Image = AgRGB.Properties.Resources.RB4;
            fdi.pictureBox2.Image = AgRGB.Properties.Resources.RB5;
            fdi.pictureBox3.Image = AgRGB.Properties.Resources.RB7;
            this.Hide();
            fdi.ShowDialog();

        }

        private void diseaseDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bacterialBlightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Disease_Info fdi = new Form_Disease_Info();
            fdi.label1.Text = "Bacterial Blight";
            fdi.textBox1.Text = "Bacterial blight is a bacterial disease which is caused by bacterium called Xanthomonas oryzae pathovar oryzae.The basic symptom of bacterial blight is the wilting of seedlings and yellowing and drying of leaves.";
            fdi.pictureBox1.Image = AgRGB.Properties.Resources.BB1;
            fdi.pictureBox2.Image = AgRGB.Properties.Resources.BB2;
            fdi.pictureBox3.Image = AgRGB.Properties.Resources.BB3;
            this.Hide();
            fdi.ShowDialog();
        }

        private void brownSpotToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Disease_Info fdi = new Form_Disease_Info();
            fdi.label1.Text = "Brown Spot";
            fdi.textBox1.Text = "Brown Spot is a fungal disease caused by Bipolaris oryzae. The basic symptom is the formation of minute spot on the leaf blade,leaft sheath,etc which later becomes cylindrical or oval dark brown or black spots.";
            fdi.pictureBox1.Image = AgRGB.Properties.Resources.BS1;
            fdi.pictureBox2.Image = AgRGB.Properties.Resources.BS2;
            fdi.pictureBox3.Image = AgRGB.Properties.Resources.BS4;
            this.Hide();
            fdi.ShowDialog();
        }

        private void riceBlastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Disease_Info fdi = new Form_Disease_Info();
            fdi.label1.Text = "Rice Blast";
            fdi.textBox1.Text = "Blast is a fungal disease which is caused by the fungus called Magnaporthe oryzae. All the parts above the ground can be affected by rice blast. The basic symptom is Diamond - shaped or elliptical or spindle-shaped spots with gray or white centers and brown margins";
            fdi.pictureBox1.Image = AgRGB.Properties.Resources.RB4;
            fdi.pictureBox2.Image = AgRGB.Properties.Resources.RB5;
            fdi.pictureBox3.Image = AgRGB.Properties.Resources.RB7;
            this.Hide();
            fdi.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void mungbeanToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void riceLeafToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(1);
            f2.label2.Text = "Wellcome to Rice Image Analysis";
            this.Hide();
            f2.ShowDialog();

        }

        private void mungbeanLeafToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(3);
            f2.label2.Text = "Wellcome to Mungbean Image Analysis";
            this.Hide();
            f2.ShowDialog();

        }
    }
}
