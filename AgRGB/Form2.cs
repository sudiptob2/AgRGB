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
    public partial class Form2 : Form
    {
        int flag=-1;
        public Form2()
        {
            InitializeComponent();

        }
        public Form2(int flag)
        {
            this.flag = flag;
            InitializeComponent();
 
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {


        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Bitmap|*.bmp;*.png;*.jpg;*.jpeg";
            openFileDialog1.Title = "Open Image";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.FileName = Guid.NewGuid().ToString("n");
            savefiledialog1.Filter = "Bitmap|*.bmp;*.png;*.jpg;*.jpeg";
            if(savefiledialog1.ShowDialog()== DialogResult.OK)
            {
                pictureBox2.Image.Save(savefiledialog1.FileName);
            }

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

        private void button3_Click(object sender, EventArgs e)
        {



            if(flag==1|| flag == 2) //For rice
            {
                int red, green, blue, avg, i, j;
                Bitmap bmp = (Bitmap)pictureBox1.Image;



                for (i = 0; i < bmp.Width; i++)
                {
                    for (j = 0; j < bmp.Height; j++)
                    {
                        Color pixel = bmp.GetPixel(i, j);
                        red = pixel.R;
                        green = pixel.G;
                        blue = pixel.B;
                        avg = (red + green + blue) / 3;
                        string str = red.ToString() + "  " + green.ToString() + "  " + blue.ToString();
                        if (red > 53 && red < 255 && green >= 125 && blue >= 0 && blue < 130)
                        {
                            bmp.SetPixel(i, j, Color.FromArgb(0, 0, 255));
                        }
                        if (red >= 0 && red <= 100 && green > 30 && green < 255 && blue >= 0 && blue <= 80)
                        {
                            bmp.SetPixel(i, j, Color.FromArgb(0, 0, 255));
                        }
                    }


                    pictureBox2.Image = bmp;

                }
            }
            else
            {
                //for mungbean
             
                int red, green, blue, avg, i, j;
                Bitmap bmp = (Bitmap)pictureBox1.Image;
                pictureBox2.Image = bmp;



                for (i = 0; i < bmp.Width; i++)
                {
                    for (j = 0; j < bmp.Height; j++)
                    {
                        Color pixel = bmp.GetPixel(i, j);
                        red = pixel.R;
                        green = pixel.G;
                        blue = pixel.B;
                        avg = (red + green + blue) / 3;
                        string str = red.ToString() + "  " + green.ToString() + "  " + blue.ToString();
                        //
                        if (green < 160 || red < 140 || blue > 210)
                        {
                            bmp.SetPixel(i, j, Color.FromArgb(0, 0, 255));

                        }
                    }


                    pictureBox2.Image = bmp;

                }
            }

  
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Bitmap|*.bmp;*.png;*.jpg;*.jpeg";
            openFileDialog1.Title = "Open Image";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
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

        private void riceLeafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Wellcome to Rice Analysis";
            flag = 1;
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

        }

        private void mungbeanLeafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Wellcome to Mungbean Analysis";
            flag = 3;
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

        }

        private void riceToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
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

        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
        }

        private void leafAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void leafAnalysisToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if (flag == 1) //Rice leaf analysis
            {
                int i, j, red, blue, green;
                string str = "";
                Bitmap Img = (Bitmap)pictureBox2.Image;
                int width = Img.Width;
                int height = Img.Height;
                int avg = 0, c=0, w = 0, yl = 0, black = 0, grey = 0, rg, gb, br;
                for (i = 0; i < Img.Width; i++)
                {
                    for (j = 0; j < Img.Height; j++)
                    {
                        Color pixel = Img.GetPixel(i, j);
                        red = pixel.R;
                        green = pixel.G;
                        blue = pixel.B;

                        avg = (red + blue + green) / 3;

                        if (blue > 250 && red == 0 && green == 0)
                        {
                            continue;
                        }
                        else
                        {
                            c++;
                        }
                    }
                }
                string result = "";

                double affected = Math.Floor(((double)c / ((double)Img.Height * (double)Img.Width)) * (double)100);
           
                result = "affected area dtected!!" + Environment.NewLine + "Affected percentage: " + affected + "%";
                chart1.Series["Chart"].Points.AddXY("affected", affected);
                chart1.Series["Chart"].Points.AddXY("Healty", 100-affected);


                textBox1.Text = result;
            }
            else if(flag ==2) //Rice disease detection
            {
                int i, j, red, blue, green;
                string str = "";
                Bitmap Img = (Bitmap)pictureBox2.Image;
                int width = Img.Width;
                int height = Img.Height;
                int avg = 0, c = 0, w = 0, yl = 0, black = 0, grey = 0, rg, gb, br;
                for (i = 0; i < Img.Width; i++)
                {
                    for (j = 0; j < Img.Height; j++)
                    {
                        Color pixel = Img.GetPixel(i, j);
                        red = pixel.R;
                        green = pixel.G;
                        blue = pixel.B;

                        avg = (red + blue + green) / 3;

                        if (blue > 250 && red == 0 && green == 0)
                        {
                            //continue;
                            Img.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        }
                        else
                        {
                            c++;
                            rg = Math.Abs(red - green);
                            gb = Math.Abs(green - blue);
                            br = Math.Abs(blue - red);
                            if (rg <= 5 && blue < 100)
                            {
                                black++;
                                Img.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                            }
                            else if (red > 140 && green > 140 && blue > 140)
                            {
                                w++;
                                Img.SetPixel(i, j, Color.FromArgb(255, 0, 0));
                            }
                            else if (rg > 0 && rg < 10 && red > 98 && green > 98 && blue < 190)
                            {
                                yl++;
                                Img.SetPixel(i, j, Color.FromArgb(238, 255, 0));
                            }
                            else if (rg > 0 && rg < 150 && blue < 150)
                            {
                                grey++;
                                Img.SetPixel(i, j, Color.FromArgb(255, 0, 220));
                                
                            }
                        }


                    }
                }
                pictureBox2.Image = Img;


                double pw = Math.Floor(((double)w / (double)c) * 100);
                double pyl = Math.Floor(((double)yl / (double)c) * 100);
                double pBlack = Math.Floor(((double)black / (double)c) * 100);
                double pGrey = Math.Floor(((double)grey / (double)c) * 100);
                double noise = 100 - (pw + pyl + pBlack + pGrey);
                str += pBlack.ToString() + " " + pw.ToString() + "  " + pyl.ToString() + "   " + pGrey.ToString() + "\n";

                string diseaseName = "Disease undetected Please Use a good quality Image";
                if (pw >= 50 && pw <= 95 && pyl < 10 && pGrey >= 10 && pGrey <= 45)
                {
                    diseaseName = "Bacterial Blight";
                }
                else if (pw <= 10 && pyl < 15 && pGrey >= 85 && pBlack <= 10)
                {
                    diseaseName = "Brown Spot";
                }
                else if (pw > 10 && pw <= 55 && pyl < 10 && pGrey >= 30 && pGrey <= 85 && pBlack <= 6)
                {
                    diseaseName = "Rice Blast";
                }
                string result = "Disease: " + diseaseName;
                chart1.Series["Chart"].Points.AddXY("A", pw);
                chart1.Series["Chart"].Points.AddXY("B", pyl);
                chart1.Series["Chart"].Points.AddXY("C", pBlack);
                chart1.Series["Chart"].Points.AddXY("D", pGrey);
                chart1.Series["Chart"].Points.AddXY("Noise", noise);

                textBox1.Text = result;
            }
            else if(flag == 3) //Mungbean leaf analysis
            {
                int i, j, red, blue, green;
                string str = "";
                Bitmap Img = (Bitmap)pictureBox2.Image;
                int width = Img.Width;
                int height = Img.Height;
                int avg = 0, c = 0, w = 0, yl = 0, black = 0, grey = 0, rg, gb, br;
                for (i = 0; i < Img.Width; i++)
                {
                    for (j = 0; j < Img.Height; j++)
                    {
                        Color pixel = Img.GetPixel(i, j);
                        red = pixel.R;
                        green = pixel.G;
                        blue = pixel.B;

                        avg = (red + blue + green) / 3;

                        if (blue > 250 && red == 0 && green == 0)
                        {
                            continue;
                        }
                        else
                        {
                            c++;
                        }
                    }
                }
                string result = "";

                double affected = Math.Floor(((double)c / ((double)Img.Height * (double)Img.Width)) * (double)100);

                result = "affected area dtected!!" + Environment.NewLine + "Affected percentage: " + affected + "%";
                chart1.Series["Chart"].Points.AddXY("affected", affected);
                chart1.Series["Chart"].Points.AddXY("Healty", 100 - affected);


                textBox1.Text = result;
            }
            else if (flag == 4) //Mungbean disease detection
            {
                int i, j, red, blue, green;
                string str = "";
                Bitmap Img = (Bitmap)pictureBox2.Image;
                int width = Img.Width;
                int height = Img.Height;
                int avg = 0, c = 0, w = 0, yl = 0, black = 0, grey = 0, rg, gb, br;
                for (i = 0; i < Img.Width; i++)
                {
                    for (j = 0; j < Img.Height; j++)
                    {
                        Color pixel = Img.GetPixel(i, j);
                        red = pixel.R;
                        green = pixel.G;
                        blue = pixel.B;

                        avg = (red + blue + green) / 3;

                        if (blue > 250 && red == 0 && green == 0)
                        {
                            //continue;
                            Img.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        }
                        else
                        {
                            c++;
                            rg = Math.Abs(red - green);
                            gb = Math.Abs(green - blue);
                            br = Math.Abs(blue - red);
                            if (rg <= 5 && blue < 100)
                            {
                                black++;
                                Img.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                            }
                            else if (red > 140 && green > 140 && blue > 140)
                            {
                                w++;
                                Img.SetPixel(i, j, Color.FromArgb(255, 0, 0));
                            }
                            else if (rg > 0 && rg < 10 && red > 98 && green > 98 && blue < 190)
                            {
                                yl++;
                                Img.SetPixel(i, j, Color.FromArgb(238, 255, 0));
                            }
                            else if (rg > 0 && rg < 150 && blue < 150)
                            {
                                grey++;
                                Img.SetPixel(i, j, Color.FromArgb(255, 0, 220));
                            }
                        }


                    }
                }

                pictureBox2.Image = Img;
                double pw = Math.Floor(((double)w / (double)c) * 100);
                double pyl = Math.Floor(((double)yl / (double)c) * 100);
                double pBlack = Math.Floor(((double)black / (double)c) * 100);
                double pGrey = Math.Floor(((double)grey / (double)c) * 100);
                double noise = 100 - (pw + pyl + pBlack + pGrey);
                str += pw.ToString() + " " + pyl.ToString() + "  " + pBlack.ToString() + "   " + pGrey.ToString() ;

                string diseaseName = "Please Use a good quality Image";
                if (pw > 60 && pyl <= 25)
                {
                    diseaseName = "Powdery Mildew";
                }
                else if (pw <= 25 && pGrey >= 60)
                {
                    diseaseName = "Yellow Mosaic";
                }
                else if (pw>35&&pw<55&&pGrey>20&&pGrey<75)
                {
                    diseaseName = "Frogeye Leaf spot";
                }
               
                
                string result = "Disease: " + diseaseName + " "+ str;
                chart1.Series["Chart"].Points.AddXY("A", pw);
                chart1.Series["Chart"].Points.AddXY("B", pyl);
                chart1.Series["Chart"].Points.AddXY("C", pBlack);
                chart1.Series["Chart"].Points.AddXY("D", pGrey);
                chart1.Series["Chart"].Points.AddXY("Noise", noise);

                textBox1.Text = result;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
