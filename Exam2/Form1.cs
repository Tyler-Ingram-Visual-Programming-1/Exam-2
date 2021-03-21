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

namespace Exam2
{
    //Made by Tyler Ingram in 2021 - C# Visual Prog 1
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamReader inputFile;
        private const string doctor0 = "D.ABRAMS,MD", doctor1 = "D.JARVIC,MD", doctor2 = "T.PANOS,MD";
        string patientName, doctorName;
        int systolicPressureOne, systolicPressureTwo, systolicPressureThree, systolicPressureFour, systolicPressureFive;
        int dialosticPressureOne, dialosticPressureTwo, dialosticPressureThree, dialosticPressureFour, dialosticPressureFive, doctorID; 
        private void displayPatientStatusButton_Click(object sender, EventArgs e)
        {
            ProcessFile();
        }
        private int SystolicPressure()
        {
            return 1; 
        }
        private int DialosticPressure()
        {
            return 1;
        }
        private string PatientStatus()
        {
            
            return "";
        }
        private string DoctorsName()
        {
            if (doctorID == 0)
            {
                return doctorName = doctor0;
            }
            else if (doctorID == 1)
            {
                return doctorName = doctor1;
            }
            else
            {
                return doctorName = doctor2;
            }
        }
        private void DisplayOutput(string doctorName)
        {
            patientListBox.Text = doctorName;
            //Figure this out 
        }
        private void ProcessFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialog1.FileName);
                while (!inputFile.EndOfStream)
                {
                    patientName = inputFile.ReadLine();
                    systolicPressureOne = int.Parse(inputFile.ReadLine() ?? string.Empty);
                    dialosticPressureOne = int.Parse(inputFile.ReadLine() ?? string.Empty);
                    systolicPressureTwo = int.Parse(inputFile.ReadLine() ?? string.Empty);
                    dialosticPressureTwo = int.Parse(inputFile.ReadLine() ?? string.Empty);
                    systolicPressureThree = int.Parse(inputFile.ReadLine() ?? string.Empty);
                    dialosticPressureThree = int.Parse(inputFile.ReadLine() ?? string.Empty);
                    systolicPressureFour = int.Parse(inputFile.ReadLine() ?? string.Empty);
                    dialosticPressureFour = int.Parse(inputFile.ReadLine() ?? string.Empty);
                    systolicPressureFive = int.Parse(inputFile.ReadLine() ?? string.Empty);
                    dialosticPressureFive = int.Parse(inputFile.ReadLine() ?? string.Empty);
                    doctorID = int.Parse(inputFile.ReadLine() ?? string.Empty);
                }
                inputFile.Close();
                SystolicPressure();
                DialosticPressure();
                PatientStatus();
                    DoctorsName();
                DisplayOutput(doctorName);
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
            ClearVariables();
        }
        private void ClearFields()
        {

        }
        private void ClearVariables()
        {

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
        private void ExitApplication()
        {
            Application.Exit();
        }
    }
}