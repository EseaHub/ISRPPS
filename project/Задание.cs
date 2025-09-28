﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Задание : Form
    {
        Form1 otec;
        Graph graph;
        DrawGraph drawGraph;
        Brush brush = Brushes.White;
        Random random = new Random();
        Thread thread;
        bool end = true;
        DagProduct product;
        public Задание(DagProduct product, Form1 form1)
        {
            InitializeComponent();
            otec = form1;
            List<Vertex> vertices; List<Edge> edges;
            drawGraph = new DrawGraph(Canvas.Width, Canvas.Height);
            vertices = new List<Vertex>();
            edges = new List<Edge>();
            graph = new Graph(vertices, edges);
            label2.Text = "";
            this.product = product;
        }

        private void Задание_Load(object sender, EventArgs e)
        {

        }

        private void Задание_FormClosing(object sender, FormClosingEventArgs e)
        {
            otec.Visible = true;
        }
        private bool canDrawVert(int x, int y)
        {
            int n = graph.vertices.Count;
            for (int i = 0; i < n; i++)
            {
                if (Math.Pow((graph.vertices[i].X - x), 2) + Math.Pow((graph.vertices[i].Y - y), 2) <= 1000)
                    return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e) //start
        {
            end = false;
            if (numericUpDown1.Value < 2) MessageBox.Show("Введите большее число вершин");
            else
            {
                button1.Enabled = false;            
                int W = Canvas.Width - 20; int H = Canvas.Height - 20;
                int i = 0;
                while (i != numericUpDown1.Value)               //задание и отрисовка вершин графа
                {
                    int x = random.Next(20, W); int y = random.Next(20, H);
                    if (canDrawVert(x, y))          //проверка, нет ли слишком близко других точек
                    {
                        Vertex vertex = new Vertex(x, y, brush, graph.vertices.Count);
                        graph.vertices.Add(vertex);
                        drawGraph.drawVertex(vertex);
                        Canvas.Image = drawGraph.GetBitmap();
                        i++;
                    }
                }
                //Вершины нарисовались, теперь надо строить дуги
                thread = new Thread(DAG);   //создание потока
                thread.Start();     //старт новосозданного потока
            }
        }

        private void DAG()  // реализует собственно заданный алгоритм
        {
            Edge edge;
            int k;
            for (int i=1; i < graph.vertices.Count; i++)
            {
               
                int p = random.Next(1, product.D(i)+1);
                //int p = i;
                for (int j=1; j < p+1; j++)
                {
                    drawGraph.drawVertex(graph.vertices[i], Brushes.Goldenrod);
                    Canvas.Image = drawGraph.GetBitmap();
                    do
                    {
                        k = random.Next(0, i);
                    }
                    while (product.canMakeEdge(i, k, graph.vertices, graph.edges) == false);
                    Thread.Sleep(500);

                    drawGraph.drawVertex(graph.vertices[k], Brushes.Red);
                    Canvas.Image = drawGraph.GetBitmap();

                    edge = new Edge(graph.vertices[i], graph.vertices[k], true);
                    graph.edges.Add(edge);
                    Thread.Sleep(500);
                    drawGraph.drawEdge(edge);
                    Thread.Sleep(500);
                    Canvas.Image = drawGraph.GetBitmap();
                    graph = new Graph(graph.vertices, graph.edges);
                }
            }
            MessageBox.Show("Алгоритм закончил работу");
            end = true;
        }

        private void button2_Click(object sender, EventArgs e) //clear
        {
            if (end)
            {
                List<Vertex> vertices = new List<Vertex>(); List<Edge> edges = new List<Edge>();
                graph = new Graph(vertices, edges);
                drawGraph.clearSheet();
                Canvas.Image = drawGraph.GetBitmap();
                button1.Enabled = true;
                end = false;
            }
            else label2.Text = "Подождите,\nпока программа\nзавершит работу!";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void Задание_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void Canvas_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
