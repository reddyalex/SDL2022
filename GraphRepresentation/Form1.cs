using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphRepresentation
{
    

    public partial class Form1 : Form
    {
        int[,] adjMatrix;

        List<Edge> edgeList = new List<Edge>();
        List<char> vertex = new List<char>();

        Dictionary<char, HashSet<KeyValuePair<char, int>>> adjList = new Dictionary<char, HashSet<KeyValuePair<char, int>>>();

        public Form1()
        {
            InitializeComponent();
            adjMatrix = new Int32[7, 7] {
                { 0,0,0,8,0,0,5},
                { 5,0,8,0,0,0,0},
                { 0,0,0,0,0,0,5},
                { 9,0,0,0,5,0,0},
                { 0,0,0,0,0,5,0},
                { 5,0,0,0,0,0,0},
                { 0,0,0,0,5,9,0},
            };
            //adjMatrix[0, 0] = 0;
            //adjMatrix[0, 1] = 0;

            vertex.Add('A');
            vertex.Add('B');
            vertex.Add('C');
            vertex.Add('D');
            vertex.Add('W');
            vertex.Add('X');
            vertex.Add('Z');

            edgeList.Add(new Edge(vertex.IndexOf('A'), vertex.IndexOf('D'), 8));
            edgeList.Add(new Edge(vertex.IndexOf('A'), vertex.IndexOf('Z'), 5));
            edgeList.Add(new Edge(vertex.IndexOf('B'), vertex.IndexOf('A'), 5));
            edgeList.Add(new Edge(vertex.IndexOf('B'), vertex.IndexOf('C'), 8));
            edgeList.Add(new Edge(vertex.IndexOf('C'), vertex.IndexOf('Z'), 5));
            edgeList.Add(new Edge(vertex.IndexOf('D'), vertex.IndexOf('A'), 9));
            edgeList.Add(new Edge(vertex.IndexOf('D'), vertex.IndexOf('W'), 5));
            edgeList.Add(new Edge(vertex.IndexOf('W'), vertex.IndexOf('X'), 5));
            edgeList.Add(new Edge(vertex.IndexOf('X'), vertex.IndexOf('A'), 5));
            edgeList.Add(new Edge(vertex.IndexOf('Z'), vertex.IndexOf('W'), 5));
            edgeList.Add(new Edge(vertex.IndexOf('Z'), vertex.IndexOf('X'), 8));


            var temp = new HashSet<KeyValuePair<char, int>>();
            temp.Add(new KeyValuePair<char, int>('D', 8));
            temp.Add(new KeyValuePair<char, int>('Z', 5));
            adjList.Add('A', temp);
            temp = new HashSet<KeyValuePair<char, int>>();
            temp.Add(new KeyValuePair<char, int>('A', 5));
            temp.Add(new KeyValuePair<char, int>('D', 8));
            adjList.Add('B', temp);

            temp = new HashSet<KeyValuePair<char, int>>();
            temp.Add(new KeyValuePair<char, int>('Z', 5));
            adjList.Add('C', temp);


            temp = new HashSet<KeyValuePair<char, int>>();
            temp.Add(new KeyValuePair<char, int>('A', 9));
            temp.Add(new KeyValuePair<char, int>('W', 5));
            adjList.Add('D', temp);

            temp = new HashSet<KeyValuePair<char, int>>();
            temp.Add(new KeyValuePair<char, int>('X', 5));
            adjList.Add('W', temp);

            temp = new HashSet<KeyValuePair<char, int>>();
            temp.Add(new KeyValuePair<char, int>('A', 5));
            adjList.Add('X', temp);

            temp = new HashSet<KeyValuePair<char, int>>();
            temp.Add(new KeyValuePair<char, int>('X', 5));
            temp.Add(new KeyValuePair<char, int>('W', 8));
            adjList.Add('Z', temp);

        }
    }
    class Edge
    {

        public int asal, tujuan, bobot;
        public Edge(int asal, int tujuan, int bobot)
        {
            this.asal = asal;
            this.tujuan = tujuan;
            this.bobot = bobot;
        }
    }
}
