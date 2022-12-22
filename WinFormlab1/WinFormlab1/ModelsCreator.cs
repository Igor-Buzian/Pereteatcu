using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormlab1
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            textBox1.Text = "First place";
            textBox1.ForeColor = Color.Gray;

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "First place")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                textBox1.Text = "Last place";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private CargoT GetValues()
        {
            CargoT cargoT = new CargoT();

            //Place
            if (textBox1.Text != "First place")
            {
                cargoT.FirstPlace = textBox1.Text;
            }

            if (textBox2.Text != "Last place")
            {
                cargoT.LastPlace = textBox2.Text;
            }
            //AmountOfCar
            if (numericUpDown1.Value != 0)
            {
                cargoT.AmountOfCar = (int)numericUpDown1.Value;
            }
            //radioButton
            switch (cargoT.type)
            {
                case CargoType.Car:
                    radioButton1.Checked = true;
                    break;
                case CargoType.Bus:
                    radioButton2.Checked = true;
                    break;
                case CargoType.Truck:
                    radioButton3.Checked = true;
                    break;
            }
            /*switch (cargoT.mark)
            {
                case CargoMark.BMW:
                    radioButton1.Checked = true;
                    break;
                case CargoMark.AUDI:
                    radioButton2.Checked = true;
                    break;
                case CargoMark.SKODA:
                    radioButton3.Checked = true;
                    break;
            }*/

            //comboBox

            //
            return cargoT;
        }
            private void CreateTxtFile(CargoT cargoT)
        {
            string directoryPath = @"I:\C#\WinFormsApp1\WinFormsApp1\models\";

            DirectoryInfo models_directory = new DirectoryInfo(directoryPath);
            if (!models_directory.Exists)
                models_directory.Create();

            int newModelNumber = models_directory.GetFiles().Length + 1;
            if (buttonSave1.Text == "Save changes")
            {
                newModelNumber = int.Parse(buttonSave1.Text.Split(' ')[1]);
            }
            FileInfo new_cargoT_txtFile = new FileInfo(@"I:\C#\TechProgLab2\TechProgLab2\models\cargoT" + newModelNumber + ".txt");
            if (!new_cargoT_txtFile.Exists)
            {
                string[] modelInfo = new string[6];
                modelInfo[0] = cargoT.FirstPlace;
                modelInfo[1] = cargoT.LastPlace;
                if (cargoT.AmountOfCar != null)
                {
                    modelInfo[2] = cargoT.AmountOfCar.ToString() + " inches";
                }
                else
                {
                    modelInfo[2] = "Unknown";
                }

                if (cargoT.type != null) {
                    modelInfo[3] = cargoT.type.ToString();
                }
                else 
                {
                    modelInfo[3] = "Unknown";
                }

                modelInfo[4] = cargoT.Date.ToString();

                File.AppendAllText(directoryPath + "cargoT" + newModelNumber + ".txt",
                    "First place: " + modelInfo[0] + "\nLast place: " + modelInfo[1] + "\nCargo type: " + modelInfo[3] +
                    "\nAmount Of Car:" + modelInfo[2] + "\nDate: " + modelInfo[4]);

                if (buttonSave1.Text != "Save changes")
                {
                    MessageBox.Show("A New model has been created!");
                }
                else
                {
                    MessageBox.Show("Model has been updated!");
                }
                //
                    }
                }
            }
        }
  
