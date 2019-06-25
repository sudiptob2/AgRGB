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
    public partial class Form_Disease_Info : Form
    {
        public Form_Disease_Info()
        {
            InitializeComponent();
        }

        private void diseaseDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void riceToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void Form_Disease_Info_Load(object sender, EventArgs e)
        {

        }

        private void imageAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.label2.Text = "Wellcome to Image Analysis";
            this.Hide();
            f2.ShowDialog();
        }

        private void riceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.label2.Text = "Wellcome to Rice Analysis";
            this.Hide();
            f2.ShowDialog();
        }

        private void mungbeanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.label2.Text = "Wellcome to Mungbean Analysis";
            this.Hide();
            f2.ShowDialog();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
        }

        private void riceLeafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.label2.Text = "Wellcome to Rice Analysis";
            this.Hide();
            f2.ShowDialog();
        }

        private void mungbeanLeafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.label2.Text = "Wellcome to Mungbean Analysis";
            this.Hide();
            f2.ShowDialog();
        }

        private void riceDiseaseDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.label2.Text = "Wellcome to Rice Disease Detection";
            this.Hide();
            f2.ShowDialog();
        }

        private void mungbeanDiseaseDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.label2.Text = "Wellcome to Mungbean Disease Detection";
            this.Hide();
            f2.ShowDialog();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bacterialBlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            label1.Text = "Bacterial Blight";
            textBox1.Text = "Bacterial blight is a bacterial disease which is caused by bacterium called Xanthomonas oryzae pathovar oryzae.The basic symptom of bacterial blight is the wilting of seedlings and yellowing and drying of leaves.";
            pictureBox1.Image = AgRGB.Properties.Resources.BB1;
            pictureBox2.Image = AgRGB.Properties.Resources.BB2;
            pictureBox3.Image = AgRGB.Properties.Resources.BB3;
            this.Refresh();
        }

        private void brownSpotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            label1.Text = "Brown Spot";
            textBox1.Text = "Brown Spot is a fungal disease caused by Bipolaris oryzae. The basic symptom is the formation of minute spot on the leaf blade,leaft sheath,etc which later becomes cylindrical or oval dark brown or black spots.";
            pictureBox1.Image = AgRGB.Properties.Resources.BS1;
            pictureBox2.Image = AgRGB.Properties.Resources.BS2;
            pictureBox3.Image = AgRGB.Properties.Resources.BS4;
            this.Refresh();
        }

        private void riceBlastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Rice Blast";
            textBox1.Text = "Blast is a fungal disease which is caused by the fungus called Magnaporthe oryzae. All the parts above the ground can be affected by rice blast. The basic symptom is Diamond - shaped or elliptical or spindle-shaped spots with gray or white centers and brown margins.";
            pictureBox1.Image = AgRGB.Properties.Resources.RB4;
            pictureBox2.Image = AgRGB.Properties.Resources.RB5;
            pictureBox3.Image = AgRGB.Properties.Resources.RB7;
            this.Refresh();
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
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

        private void bacterialBlightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bacterial Blight";
            textBox1.Text = "Bacterial blight is a bacterial disease which is caused by bacterium called Xanthomonas oryzae pathovar oryzae.The basic symptom of bacterial blight is the wilting of seedlings and yellowing and drying of leaves.";
            pictureBox1.Image = AgRGB.Properties.Resources.BB1;
            pictureBox2.Image = AgRGB.Properties.Resources.BB2;
            pictureBox3.Image = AgRGB.Properties.Resources.BB3;
            this.Refresh();
        }

        private void brownSpotToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "Brown Spot";
            textBox1.Text = "Brown Spot is a fungal disease caused by Bipolaris oryzae. The basic symptom is the formation of minute spot on the leaf blade,leaft sheath,etc which later becomes cylindrical or oval dark brown or black spots.";
            pictureBox1.Image = AgRGB.Properties.Resources.BS1;
            pictureBox2.Image = AgRGB.Properties.Resources.BS2;
            pictureBox3.Image = AgRGB.Properties.Resources.BS4;
            this.Refresh();
        }

        private void riceBlastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "Rice Blast";
            textBox1.Text = "Blast is a fungal disease which is caused by the fungus called Magnaporthe oryzae. All the parts above the ground can be affected by rice blast. The basic symptom is Diamond - shaped or elliptical or spindle-shaped spots with gray or white centers and brown margins.";
            pictureBox1.Image = AgRGB.Properties.Resources.RB4;
            pictureBox2.Image = AgRGB.Properties.Resources.RB5;
            pictureBox3.Image = AgRGB.Properties.Resources.RB7;
            this.Refresh();
        }
    }
}
