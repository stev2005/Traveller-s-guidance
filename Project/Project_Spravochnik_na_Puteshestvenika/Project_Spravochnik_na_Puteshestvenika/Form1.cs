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
        string filein = @"D:\Martin Ivanov 11b klas\Project\CityNames.in";
        ///string filein = "CityNames/in";
        ///public Dictionary<int, >
        Graph gr;
        /*private Dictionary<string, Node> nodes;
        private List<Edge> edges;*/


        public Form1()
        {
            InitializeComponent();
            /*nodes = new Dictionary<string, Node>();
            edges = new List<Edge>();*/
            gr = new Graph();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///var cities = new Dictionary<string, int>();
            //LoadDataFromFile(filein);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name1= NodeX.Text;
            string name2 = NodeY.Text;
            int length = int.Parse(numLength.Text);
            int time = int.Parse(numTime.Text);
            int price = int.Parse(numPrice.Text);
            gr.AddRoad(name1, name2, length, time, price);
        }

        private void DeleteEdge_Click(object sender, EventArgs e)
        {
            string strnum = DeleteEdgeInfo.Text;
            int num = int.Parse(strnum);
            gr.DeleteEdge(num);
            /*if (AllEdgesBox.SelectedIndex != -1)
            {
                string selectedEdge = AllEdgesBox.SelectedItem.ToString();
                string[] nodes = selectedEdge.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string startNodeName = nodes[0].Trim();
                string endNodeName = nodes[1].Trim();

                edges.RemoveAll(edge => edge.city1.Name == startNodeName && edge.city2.Name == endNodeName);
                AllEdgesBox.Items.RemoveAt(AllEdgesBox.SelectedIndex);
            }*/
        }

        private void AddVertex_Click(object sender, EventArgs e)
        {
            string namevertex = AddNewVertex.Text;
            gr.AddCity(namevertex);
        }

        private void DeleteVertex_Click(object sender, EventArgs e)
        {
            string name = DeleteVertexInfo.Text;
            gr.DeleteNode(name);
        }

        public class EditNodeForm
        {
            private Node nodeToEdit;

            public EditNodeForm(Node selectedNode)
            {
                //nodeToEdit = selectedNode;
                NodeName.Text = selectedNode.Name;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string nameold = OldNameInfo.Text;
            string namenew = OldNameInfo.Text;
            gr.EditNameCity(nameold, newname);
        }

        private void ShortestPath_Click(object sender, EventArgs e)
        {
            string from = 
            gr.FindShortestDistance()
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    // Прочитане на данните за върховете
                    int nodeCount = int.Parse(lines[0]);
                    for (int i = 1; i <= nodeCount; i++)
                    {
                        string[] nodeData = lines[i].Split(';');
                        string nodeName = nodeData[0];
                        int x = int.Parse(nodeData[1]);
                        int y = int.Parse(nodeData[2]);

                        Node newNode = new Node(nodeName, x, y);
                        nodes.Add(nodeName, newNode);
                        listBoxNodes.Items.Add(nodeName);
                    }

                    // Прочитане на данните за ребрата
                    int edgeCount = int.Parse(lines[nodeCount + 1]);
                    for (int i = nodeCount + 2; i <= nodeCount + edgeCount + 1; i++)
                    {
                        string[] edgeData = lines[i].Split(';');
                        string startNodeName = edgeData[0];
                        string endNodeName = edgeData[1];
                        double length = double.Parse(edgeData[2]);
                        double time = double.Parse(edgeData[3]);
                        double price = double.Parse(edgeData[4]);

                        Node startNode = nodes[startNodeName];
                        Node endNode = nodes[endNodeName];
                        Edge newEdge = new Edge(startNode, endNode, length, time, price);
                        edges.Add(newEdge);
                        listBoxEdges.Items.Add($"{startNodeName} -> {endNodeName}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при зареждане на данните: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Файлът не съществува.");
            }
        }

        private void SaveDataToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Записване на данните за върховете
                    writer.WriteLine(nodes.Count);
                    foreach (var node in nodes.Values)
                    {
                        writer.WriteLine($"{node.Name};{node.X};{node.Y}");
                    }

                    // Записване на данните за ребрата
                    writer.WriteLine(edges.Count);
                    foreach (var edge in edges)
                    {
                        writer.WriteLine($"{edge.StartNode.Name};{edge.EndNode.Name};{edge.Length};{edge.Time};{edge.Price}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при записване на данните: {ex.Message}");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Записване на данните за върховете
                    writer.WriteLine(nodes.Count);
                    foreach (var node in nodes.Values)
                    {
                        writer.WriteLine($"{node.Name};{node.X};{node.Y}");
                    }

                    // Записване на данните за ребрата
                    writer.WriteLine(edges.Count);
                    foreach (var edge in edges)
                    {
                        writer.WriteLine($"{edge.StartNode.Name};{edge.EndNode.Name};{edge.Length};{edge.Time};{edge.Price}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при записване на данните: {ex.Message}");
            }
        }

        private void AllEdges_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddNewVertices_TextChanged(object sender, EventArgs e)
        {

        }

        private void NodeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Diable_Enable_Vertex_Click(object sender, EventArgs e)
        {
            string name = Disable_Enable_Vertex_Info.Text;
            gr.DisableEnableNode(name);
        }

        private void Disable_Enable_Edge_Click(object sender, EventArgs e)
        {
            string strnum = Disable_Enable_Edge_Info.Text;
            int num = int.Parse(strnum);
            gr.DisableEnableEdge(num);
        }
    }
}
