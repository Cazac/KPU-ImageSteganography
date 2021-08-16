using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Forensics___Stenography_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////

        //FINAL
        private void FilePathB_Click(object sender, EventArgs e)
        {
            //Open Dialog Search Box and Filter for Images
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png) | *.png;";

            //If File Path Is A Valid Choice
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //Set Text to Selected Path
                FilePathTB.Text = openDialog.FileName.ToString();

                //Set Image From TextBox Loaction
                ImagePicture.ImageLocation = FilePathTB.Text;
            }
        }

        //////////////////////////////////////////////////////////////

        //FINAL
        private void WriteFileB_Click(object sender, EventArgs e)
        {
            if (WriteTB.TextLength > 255)
            {
                //Error Message
                MessageBox.Show("Message is too large, please keep it below 255 charecters!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (WriteTB.TextLength == 0)
            {
                //Error Message
                MessageBox.Show("Please Enter a Message!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Error Check For Empty String
            if (FilePathTB.Text != "")
            {

                //Get The Avlible Attributes Of The File To Compare
                FileAttributes attributes = File.GetAttributes(FilePathTB.Text);
                
                //Error Check For File Existance
                if (File.Exists(FilePathTB.Text))
                {

                    //Create Bitmap To store Image File 
                    Bitmap img = new Bitmap(FilePathTB.Text);

                    //For Each Pixel In The Image
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {
                            //Get the Selected Pixel
                            Color pixel = img.GetPixel(i, j);

                            if (i < 1 && j < WriteTB.TextLength)
                            {
                                //Get The Charecter
                                char letter = Convert.ToChar(WriteTB.Text.Substring(j, 1));

                                //Convert to Integer For Storage
                                int value = Convert.ToInt32(letter);

                                //Print All The Pixels
                                Console.WriteLine("R = [" + i + "][" + j + "] = " + pixel.R);
                                Console.WriteLine("G = [" + i + "][" + j + "] = " + pixel.G);
                                Console.WriteLine("B = [" + i + "][" + j + "] = " + pixel.B);
                                Console.WriteLine("letter : " + letter + " value : " + value);

                                //Change The Values In The Image
                                img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                            }

                            if (i == img.Width - 1 && j == img.Height - 1)
                            {
                                //Stores the size of the hidden message in the last pixel
                                img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, WriteTB.TextLength));
                            }

                        }
                    }


                    //Open Dialog Search Box and Filter for Images
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";
                  

                    //If File Path Is A Valid Choice
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        //Set Text to Selected Path
                        FilePathTB.Text = saveFile.FileName.ToString();

                        //Set Image From TextBox Loaction
                        ImagePicture.ImageLocation = FilePathTB.Text;

                        //Save Image to Path
                        img.Save(FilePathTB.Text);
                    }
                }
                else
                {
                    //Error Message
                    MessageBox.Show("Selected File Does Not Exist!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //Error Message
                MessageBox.Show("No File Selected!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Success Message
            MessageBox.Show("Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }

        //////////////////////////////////////////////////////////////

        //FINAL
        private void ReadFileB_Click(object sender, EventArgs e)
        {
            //Error Check For Empty String
            if (FilePathTB.Text != "")
            {

                //Get The Avlible Attributes Of The File To Compare
                FileAttributes attributes = File.GetAttributes(FilePathTB.Text);
                
                //Error Check For File Existance
                if (File.Exists(FilePathTB.Text))
                {

                    //Create Bitmap To store Image File 
                    Bitmap img = new Bitmap(FilePathTB.Text);

                    //Default Message Value
                    string message = "";

                    //Get the size of the message from the last pixel
                    Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
                    int msgLength = lastpixel.B;


                    //For Each Pixel In The Image
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {
                            //Get the Selected Pixel
                            Color pixel = img.GetPixel(i, j);

                            if (i < 1 && j < msgLength)
                            {
                                int value = pixel.B;
                                char c = Convert.ToChar(value);
                                string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                                //Add Each Letter To The Message
                                message = message + letter;
                            }
                        }
                    }

                    //Set Text From The File
                    ReadTB.Text = message;

                }
                else
                {
                    //Error Message
                    MessageBox.Show("Selected File Does Not Exist!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //Error Message
                MessageBox.Show("No File Selected!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ReadTB.Text == "")
            {
                //Success Message
                MessageBox.Show("No Hidden Message Found.", "No Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                //Success Message
                MessageBox.Show("Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

        }

    
        //////////////////////////////////////////////////////////////

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////

        
        //public void EncodeData(File inputFile, string HiddenText)
        //{

        //Input: Image
        //Input: Hidden Text

        //Output: Hidden File


        //Find three sets of 00 in hex
        // On forth 00, set hex 13 50 13 50


        //Calculate needed hex space

        //If hex slack space is too small create more
        //Then insert hex of the hidden Text


        //Save new file as a new “old file name” +hidden



        //}


        //////////////////////////////////////////////////////////////
    }
}
