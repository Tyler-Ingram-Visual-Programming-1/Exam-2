using System;
using System.Windows.Forms;
using System.IO;
namespace Exam2
{
    //Made by Tyler Ingram in 2021 - C# Visual Prog 1 Exam 2
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private StreamReader inputFile;
        private const string DOCTOR0 = "D.ABRAMS,MD", DOCTOR1 = "D.JARVIC,MD", DOCTOR2 = "T.PANOS,MD";
        private string patientName, doctorName;
        private int systolicPressureOne, systolicPressureTwo, systolicPressureThree, systolicPressureFour, systolicPressureFive;
        private int dialosticPressureOne, dialosticPressureTwo, dialosticPressureThree, dialosticPressureFour, dialosticPressureFive, doctorID;
        private double averageSystolicPressure, averageDialosticPressure;
        private void displayPatientStatusButton_Click(object sender, EventArgs e)
        {
            ProcessFile();
        }
        private double SystolicPressure()
        {
            averageSystolicPressure = (systolicPressureOne + systolicPressureTwo + systolicPressureThree +
                                        systolicPressureFour +
                                        systolicPressureFive) / 5.0;
            return averageSystolicPressure;
        }
        private double DialosticPressure()
        {
            averageDialosticPressure = (dialosticPressureOne + dialosticPressureTwo + dialosticPressureThree + dialosticPressureFour +
                                        dialosticPressureFive) / 5.0;
            return averageDialosticPressure;
        }
        private string PatientStatus()
        {
            if ((averageSystolicPressure <= 90 || averageSystolicPressure >= 160) 
                || (averageDialosticPressure <= 60 || averageDialosticPressure >= 90))
                return "WARNING";
            return "NORMAL";
            
        }
        private string DoctorsName()
        {
            switch (doctorID)
            {
                case 0:
                    return doctorName = DOCTOR0;
                case 1:
                    return doctorName = DOCTOR1;
                default:
                    return doctorName = DOCTOR2;
            }
        }
        private void DisplayOutput(string patientName, string doctorName,double systolicPressureAverage, double dialosticPressureAverage, string status)
        {
            patientListBox.Items.Add($"{patientName} \t {systolicPressureAverage} \t\t {dialosticPressureAverage} \t          {status} \t     {doctorName}");
            
            //Figure this out 
        }
        private void ProcessFile()
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
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
                DisplayOutput(patientName,DoctorsName(),SystolicPressure(),DialosticPressure(),PatientStatus());
            }
            inputFile.Close();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
            ClearVariables();
        }
        private void ClearFields()
        {
            patientListBox.Items.Clear();
        }

        private void ClearVariables()
        {
            patientName = "";
            doctorName = "";
            systolicPressureOne = 0;
            systolicPressureTwo = 0;
            systolicPressureThree = 0;
            systolicPressureFour = 0;
            systolicPressureFive = 0;
            dialosticPressureOne = 0;
            dialosticPressureTwo = 0;
            dialosticPressureThree = 0;
            dialosticPressureFour = 0;
            dialosticPressureFive = 0;
            doctorID = 0;
            averageSystolicPressure = 0;
            averageDialosticPressure = 0;
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