using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Project_Spravochnik_na_Puteshestvenika
{
    
    public partial class Form1 : Form
    {

        //string filein = @"D:\Martin Ivanov 11b klas\Project\CityNames.in";
        string filein = "CityNames/in";
        //public Dictionary<int, >

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cities = new Dictionary<string, int>(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string textContent = File.ReadAllText(path);
            StreamReader fin = new StreamReader(filein);
            for (int i = 0; i < 3; ++i)
            {
                string s = fin.ReadLine();
                AllVertices.Items.Add(s);
            }
            fin.Close();
        }

        private void AddVertex_Click(object sender, EventArgs e)
        {

        }

        private void ShortestPath_Click(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void AllEdges_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddNewVertices_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
