using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
namespace ObjectDetection
{
    
    public partial class Form1 : Form
    {
        public static int p;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (p % 2 == 0)
            {
                pictureBox1.Visible = true;
                pictureBox1.Height = 0;
                pictureBox1.Top = 350;
                pictureBox4.Height = 300;
                pictureBox4.Top = 360;
                pictureBox1.BringToFront();
                pictureBox2.BringToFront();

                pictureBo1.Visible = true;
                pictureBo1.Height = 0;
                pictureBo1.Top = 350;
                pictureBo4.Height = 300;
                pictureBo4.Top = 360;
                pictureBo1.BringToFront();
                pictureBo2.BringToFront();

                pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\" + Program.imagename[p - 2]);
                pictureBo1.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\output\\" + Program.imagename[p - 2]);
                if (p == 2)
                {
                    pictureBox4.Visible = false;
                    pictureBo4.Visible = false;
                }
                p = p - 1;
                label1.Text = p + "";
                label3.Text = (p-1) + "";
                for (int i = 0; i < 300; i++)
                {
                    pictureBox2.Height = pictureBox2.Height - (int)(i * 0.01);
                    pictureBox2.Top = pictureBox2.Top - (int)(i * 0.001);

                    pictureBo2.Height = pictureBo2.Height - (int)(i * 0.01);
                    pictureBo2.Top = pictureBo2.Top - (int)(i * 0.001);
                    Application.DoEvents();
                }
                for (int i = 0; i < 300; i++)
                {
                    pictureBox1.Height = (int)(pictureBox1.Height + (int)(i * 0.01));
                    pictureBox1.Top = (int)(pictureBox1.Top - (int)(i * 0.01));

                    pictureBo1.Height = (int)(pictureBo1.Height + (int)(i * 0.01));
                    pictureBo1.Top = (int)(pictureBo1.Top - (int)(i * 0.01));
                    Application.DoEvents();
                }
            }
            else
            {
                Debug.Write("홀");
                pictureBox3.Visible = true;
                pictureBox3.Height = 0;
                pictureBox3.Top = 350;
                pictureBox2.Height = 300;
                pictureBox2.Top = 360;
                pictureBox3.BringToFront();
                pictureBox4.BringToFront();

                pictureBo3.Visible = true;
                pictureBo3.Height = 0;
                pictureBo3.Top = 350;
                pictureBo2.Height = 300;
                pictureBo2.Top = 360;
                pictureBo3.BringToFront();
                pictureBo4.BringToFront();

                pictureBo3.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\output\\" + Program.imagename[p - 2]);
                pictureBo2.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\output\\" + Program.imagename[p - 3]);

                pictureBox3.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\" + Program.imagename[p - 2]);
                pictureBox2.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\" + Program.imagename[p-3]);

                p = p - 1;
                label1.Text = p + "";
                label3.Text = (p - 1) + "";
                for (int i = 0; i < 300; i++)
                {
                    pictureBox4.Height = pictureBox4.Height - (int)(i * 0.01);
                    pictureBox4.Top = pictureBox4.Top - (int)(i * 0.001);

                    pictureBo4.Height = pictureBo4.Height - (int)(i * 0.01);
                    pictureBo4.Top = pictureBo4.Top - (int)(i * 0.001);
                    Application.DoEvents();
                }
                for (int i = 0; i < 300; i++)
                {
                    pictureBox3.Height = (int)(pictureBox3.Height + (int)(i * 0.01));
                    pictureBox3.Top = (int)(pictureBox3.Top - (int)(i * 0.01));

                    pictureBo3.Height = (int)(pictureBo3.Height + (int)(i * 0.01));
                    pictureBo3.Top = (int)(pictureBo3.Top - (int)(i * 0.01));
                    Application.DoEvents();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (p < Program.imagecount) {
                
                if (p % 2 == 0)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Height = 300;
                    pictureBox1.Top = 50;
                    pictureBox3.BringToFront();
                    pictureBox4.BringToFront();

                    pictureBo1.Visible = true;
                    pictureBo1.Height = 300;
                    pictureBo1.Top = 50;
                    pictureBo3.BringToFront();
                    pictureBo4.BringToFront();

                    pictureBo1.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\output\\" + Program.imagename[p]);
                    pictureBo4.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\output\\" + Program.imagename[p - 1]);

                    pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\" + Program.imagename[p]);
                    pictureBox4.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\" + Program.imagename[p - 1]);

                    p = p + 1;
                    label1.Text = p + "";
                    label3.Text = (p - 1) + "";
                    for (int i = 0; i < 300; i++)
                    {
                        pictureBox3.Height = pictureBox3.Height - (int)(i * 0.01);
                        pictureBox3.Top = pictureBox3.Top + (int)(i * 0.01);

                        pictureBo3.Height = pictureBo3.Height - (int)(i * 0.01);
                        pictureBo3.Top = pictureBo3.Top + (int)(i * 0.01);
                        Application.DoEvents();
                    }
                    
                    pictureBox4.Height = 0;
                    pictureBox4.Top = 360;

                    pictureBo4.Height = 0;
                    pictureBo4.Top = 360;

                    for (int i = 0; i < 300; i++)
                    {
                        pictureBox4.Height = pictureBox4.Height + (int)(i * 0.01);
                        pictureBox4.Top = pictureBox4.Top + (int)(i * 0.001);

                        pictureBo4.Height = pictureBo4.Height + (int)(i * 0.01);
                        pictureBo4.Top = pictureBo4.Top + (int)(i * 0.001);
                        Application.DoEvents();
                    }
                    pictureBox4.Visible = true;
                    pictureBo4.Visible = true;
                }
                else {
                    

                    pictureBo3.Visible = true;
                    pictureBo3.Height = 300;
                    pictureBo3.Top = 50;
                    pictureBo1.BringToFront();
                    pictureBo2.BringToFront();
                    pictureBox3.Visible = true;
                    pictureBox3.Height = 300;
                    pictureBox3.Top = 50;
                    pictureBox1.BringToFront();
                    pictureBox2.BringToFront();

                    pictureBox3.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\" + Program.imagename[p]);
                    pictureBox2.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\" + Program.imagename[p - 1]);
                    
                    pictureBo3.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\output\\" + Program.imagename[p]);
                    pictureBo2.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\output\\" + Program.imagename[p - 1]);

                    
                    p = p + 1;
                    label1.Text = p + "";
                    label3.Text = (p-1) + "";
                    for (int i = 0; i < 300; i++)
                    {
                        
                        Application.DoEvents();
                        pictureBox1.Height = pictureBox1.Height - (int)(i * 0.01);
                        pictureBox1.Top = pictureBox1.Top + (int)(i * 0.01);

                        pictureBo1.Height = pictureBo1.Height - (int)(i * 0.01);
                        pictureBo1.Top = pictureBo1.Top + (int)(i * 0.01);
                        Application.DoEvents();
                    }
                    pictureBo2.Height = 0;
                    pictureBo2.Top = 360;
                    pictureBox2.Height = 0;
                    pictureBox2.Top = 360;



                    for (int i = 0; i < 300; i++)
                    {
                        pictureBox2.Height = pictureBox2.Height + (int)(i * 0.01);
                        pictureBox2.Top = pictureBox2.Top + (int)(i * 0.001);

                        pictureBo2.Height = pictureBo2.Height + (int)(i * 0.01);
                        pictureBo2.Top = pictureBo2.Top + (int)(i * 0.001);
                        Application.DoEvents();
                    }
                }



                if (p % 2 == 0)
                {
                    pictureBo3.Visible = true;
                    pictureBo3.Height = 300;
                    pictureBo3.Top = 50;
                    pictureBo4.Height = 0;
                    pictureBo4.Top = 360;
                    pictureBox3.Visible = true;
                    pictureBox3.Height = 300;
                    pictureBox3.Top = 50;
                    pictureBox4.Height = 0;
                    pictureBox4.Top = 360;

                }
                else
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Height = 300;
                    pictureBox1.Top = 50;
                    pictureBox2.Height = 0;
                    pictureBox2.Top = 360;

                    pictureBo1.Visible = true;
                    pictureBo1.Height = 300;
                    pictureBo1.Top = 50;
                    pictureBo2.Height = 0;
                    pictureBo2.Top = 360;
                }

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\" + Program.imagename[p]);
            pictureBo1.Image = System.Drawing.Image.FromFile("C:\\Users\\ghksw\\Source\\Repos\\MLnetProject\\ObjectDetection\\assets\\images\\output\\" + Program.imagename[p]);

            p = 1;
            label1.Text = p + "";
            label3.Text = (p-1) + "";

            for (int i = 0; i < Program.imagecount; i++)
            {
                Debug.WriteLine("파일이름" + Program.imagename[i]);
            }

        }
    }
}
