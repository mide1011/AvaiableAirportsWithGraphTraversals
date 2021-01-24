using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskB_Week5
{
    public partial class Form1 : Form
    {
        Graph<string> airport_nodes = new Graph<string>();

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddID_Button_Click(object sender, EventArgs e)
        {
            airport_nodes.AddNode(IDTextBox.Text);
            IDTextBox.Clear();

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string from = FromTextBox.Text;
            string to = ToTextBox.Text;

            airport_nodes.RemoveEdge(from, to);



        }

        private void DisplayConnectionsButton_Click(object sender, EventArgs e)
        {
            List<string> visited = new List<string>() { };
            string possible_airports = "";
            airport_nodes.DepthFirstTraverse(IDTextBox.Text, ref visited);

            foreach (string node in visited) {

                possible_airports += node + " ";    
            }

            MessageBox.Show("Possible Flights : "+ possible_airports, "Possible Connections");
        }

        private void MotherButton_Click(object sender, EventArgs e)
        {
            airport_nodes.Mothervertex();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = FromTextBox.Text;
            string to = ToTextBox.Text;

            airport_nodes.AddEdge(from, to);
        }
    }
}
