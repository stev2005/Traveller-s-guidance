namespace Project_Spravochnik_na_Puteshestvenika
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AllVertices = new System.Windows.Forms.ListBox();
            this.AddEdge = new System.Windows.Forms.Button();
            this.AddNewVertex = new System.Windows.Forms.TextBox();
            this.AddVertex = new System.Windows.Forms.Button();
            this.AllEdgesBox = new System.Windows.Forms.ListBox();
            this.ShortestPath = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.NodeStart = new System.Windows.Forms.TextBox();
            this.NodeEnd = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.TextBox();
            this.numTime = new System.Windows.Forms.TextBox();
            this.numLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NodeName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NodeX = new System.Windows.Forms.TextBox();
            this.NodeY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteVertex = new System.Windows.Forms.Button();
            this.DeleteEdge = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ShortPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteVertexInfo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DeleteEdgeInfo = new System.Windows.Forms.TextBox();
            this.Diable_Enable_Vertex = new System.Windows.Forms.Button();
            this.Disable_Enable_Vertex_Info = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Disable_Enable_Edge = new System.Windows.Forms.Button();
            this.Disable_Enable_Edge_Info = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.OldNameInfo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // AllVertices
            // 
            this.AllVertices.FormattingEnabled = true;
            this.AllVertices.Location = new System.Drawing.Point(343, 28);
            this.AllVertices.Name = "AllVertices";
            this.AllVertices.Size = new System.Drawing.Size(120, 95);
            this.AllVertices.TabIndex = 0;
            // 
            // AddEdge
            // 
            this.AddEdge.Location = new System.Drawing.Point(24, 36);
            this.AddEdge.Name = "AddEdge";
            this.AddEdge.Size = new System.Drawing.Size(97, 29);
            this.AddEdge.TabIndex = 1;
            this.AddEdge.Text = "AddEdge";
            this.AddEdge.UseVisualStyleBackColor = true;
            this.AddEdge.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewVertex
            // 
            this.AddNewVertex.Location = new System.Drawing.Point(343, 144);
            this.AddNewVertex.Name = "AddNewVertex";
            this.AddNewVertex.Size = new System.Drawing.Size(120, 20);
            this.AddNewVertex.TabIndex = 2;
            this.AddNewVertex.TextChanged += new System.EventHandler(this.AddNewVertices_TextChanged);
            // 
            // AddVertex
            // 
            this.AddVertex.Location = new System.Drawing.Point(26, 108);
            this.AddVertex.Name = "AddVertex";
            this.AddVertex.Size = new System.Drawing.Size(97, 29);
            this.AddVertex.TabIndex = 3;
            this.AddVertex.Text = "AddVertex";
            this.AddVertex.UseVisualStyleBackColor = true;
            this.AddVertex.Click += new System.EventHandler(this.AddVertex_Click);
            // 
            // AllEdgesBox
            // 
            this.AllEdgesBox.FormattingEnabled = true;
            this.AllEdgesBox.Location = new System.Drawing.Point(196, 28);
            this.AllEdgesBox.Name = "AllEdgesBox";
            this.AllEdgesBox.Size = new System.Drawing.Size(120, 95);
            this.AllEdgesBox.TabIndex = 4;
            this.AllEdgesBox.SelectedIndexChanged += new System.EventHandler(this.AllEdges_SelectedIndexChanged);
            // 
            // ShortestPath
            // 
            this.ShortestPath.Location = new System.Drawing.Point(25, 180);
            this.ShortestPath.Name = "ShortestPath";
            this.ShortestPath.Size = new System.Drawing.Size(98, 29);
            this.ShortestPath.TabIndex = 5;
            this.ShortestPath.Text = "ShortestPath";
            this.ShortestPath.UseVisualStyleBackColor = true;
            this.ShortestPath.Click += new System.EventHandler(this.ShortestPath_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(23, 352);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(97, 29);
            this.Load.TabIndex = 6;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(25, 387);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 31);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(22, 305);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(98, 41);
            this.Edit.TabIndex = 9;
            this.Edit.Text = "Edit Name of Vetex";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // NodeStart
            // 
            this.NodeStart.Location = new System.Drawing.Point(343, 170);
            this.NodeStart.Name = "NodeStart";
            this.NodeStart.Size = new System.Drawing.Size(120, 20);
            this.NodeStart.TabIndex = 10;
            // 
            // NodeEnd
            // 
            this.NodeEnd.Location = new System.Drawing.Point(343, 199);
            this.NodeEnd.Name = "NodeEnd";
            this.NodeEnd.Size = new System.Drawing.Size(120, 20);
            this.NodeEnd.TabIndex = 11;
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Location = new System.Drawing.Point(469, 173);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(55, 13);
            this.Start.TabIndex = 12;
            this.Start.Text = "StartNode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "EndNode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "AddNewVertex";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(196, 199);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 20);
            this.numPrice.TabIndex = 15;
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(196, 170);
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(120, 20);
            this.numTime.TabIndex = 16;
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(196, 144);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(120, 20);
            this.numLength.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Price";
            // 
            // NodeName
            // 
            this.NodeName.Location = new System.Drawing.Point(343, 225);
            this.NodeName.Name = "NodeName";
            this.NodeName.Size = new System.Drawing.Size(120, 20);
            this.NodeName.TabIndex = 21;
            this.NodeName.TextChanged += new System.EventHandler(this.NodeName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "NodeName";
            // 
            // NodeX
            // 
            this.NodeX.Location = new System.Drawing.Point(343, 253);
            this.NodeX.Name = "NodeX";
            this.NodeX.Size = new System.Drawing.Size(120, 20);
            this.NodeX.TabIndex = 23;
            // 
            // NodeY
            // 
            this.NodeY.Location = new System.Drawing.Point(343, 279);
            this.NodeY.Name = "NodeY";
            this.NodeY.Size = new System.Drawing.Size(120, 20);
            this.NodeY.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "NodeX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(469, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "NodeY";
            // 
            // DeleteVertex
            // 
            this.DeleteVertex.Location = new System.Drawing.Point(27, 143);
            this.DeleteVertex.Name = "DeleteVertex";
            this.DeleteVertex.Size = new System.Drawing.Size(96, 31);
            this.DeleteVertex.TabIndex = 28;
            this.DeleteVertex.Text = "DeleteVertex";
            this.DeleteVertex.UseVisualStyleBackColor = true;
            this.DeleteVertex.Click += new System.EventHandler(this.DeleteVertex_Click);
            // 
            // DeleteEdge
            // 
            this.DeleteEdge.Location = new System.Drawing.Point(27, 71);
            this.DeleteEdge.Name = "DeleteEdge";
            this.DeleteEdge.Size = new System.Drawing.Size(96, 31);
            this.DeleteEdge.TabIndex = 29;
            this.DeleteEdge.Text = "DeleteEdge";
            this.DeleteEdge.UseVisualStyleBackColor = true;
            this.DeleteEdge.Click += new System.EventHandler(this.DeleteEdge_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ShortPath
            // 
            this.ShortPath.Location = new System.Drawing.Point(196, 229);
            this.ShortPath.Name = "ShortPath";
            this.ShortPath.Size = new System.Drawing.Size(120, 20);
            this.ShortPath.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Shortest path";
            // 
            // DeleteVertexInfo
            // 
            this.DeleteVertexInfo.Location = new System.Drawing.Point(343, 305);
            this.DeleteVertexInfo.Name = "DeleteVertexInfo";
            this.DeleteVertexInfo.Size = new System.Drawing.Size(120, 20);
            this.DeleteVertexInfo.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Delete Edge Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(469, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Delete Vertex";
            // 
            // DeleteEdgeInfo
            // 
            this.DeleteEdgeInfo.Location = new System.Drawing.Point(343, 335);
            this.DeleteEdgeInfo.Name = "DeleteEdgeInfo";
            this.DeleteEdgeInfo.Size = new System.Drawing.Size(120, 20);
            this.DeleteEdgeInfo.TabIndex = 35;
            // 
            // Diable_Enable_Vertex
            // 
            this.Diable_Enable_Vertex.Location = new System.Drawing.Point(24, 215);
            this.Diable_Enable_Vertex.Name = "Diable_Enable_Vertex";
            this.Diable_Enable_Vertex.Size = new System.Drawing.Size(99, 34);
            this.Diable_Enable_Vertex.TabIndex = 36;
            this.Diable_Enable_Vertex.Text = "DIsable/Enable Vertex";
            this.Diable_Enable_Vertex.UseVisualStyleBackColor = true;
            this.Diable_Enable_Vertex.Click += new System.EventHandler(this.Diable_Enable_Vertex_Click);
            // 
            // Disable_Enable_Vertex_Info
            // 
            this.Disable_Enable_Vertex_Info.Location = new System.Drawing.Point(343, 370);
            this.Disable_Enable_Vertex_Info.Name = "Disable_Enable_Vertex_Info";
            this.Disable_Enable_Vertex_Info.Size = new System.Drawing.Size(120, 20);
            this.Disable_Enable_Vertex_Info.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(469, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Disable/Enable Vertex";
            // 
            // Disable_Enable_Edge
            // 
            this.Disable_Enable_Edge.Location = new System.Drawing.Point(24, 255);
            this.Disable_Enable_Edge.Name = "Disable_Enable_Edge";
            this.Disable_Enable_Edge.Size = new System.Drawing.Size(97, 40);
            this.Disable_Enable_Edge.TabIndex = 39;
            this.Disable_Enable_Edge.Text = "Disable/Enable Edge";
            this.Disable_Enable_Edge.UseVisualStyleBackColor = true;
            this.Disable_Enable_Edge.Click += new System.EventHandler(this.Disable_Enable_Edge_Click);
            // 
            // Disable_Enable_Edge_Info
            // 
            this.Disable_Enable_Edge_Info.Location = new System.Drawing.Point(343, 398);
            this.Disable_Enable_Edge_Info.Name = "Disable_Enable_Edge_Info";
            this.Disable_Enable_Edge_Info.Size = new System.Drawing.Size(120, 20);
            this.Disable_Enable_Edge_Info.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(469, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Disable/Enable Edge";
            // 
            // OldNameInfo
            // 
            this.OldNameInfo.Location = new System.Drawing.Point(611, 33);
            this.OldNameInfo.Name = "OldNameInfo";
            this.OldNameInfo.Size = new System.Drawing.Size(100, 20);
            this.OldNameInfo.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(726, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Old Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(611, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(726, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "New Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.OldNameInfo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Disable_Enable_Edge_Info);
            this.Controls.Add(this.Disable_Enable_Edge);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Disable_Enable_Vertex_Info);
            this.Controls.Add(this.Diable_Enable_Vertex);
            this.Controls.Add(this.DeleteEdgeInfo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeleteVertexInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ShortPath);
            this.Controls.Add(this.DeleteEdge);
            this.Controls.Add(this.DeleteVertex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NodeY);
            this.Controls.Add(this.NodeX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NodeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.numTime);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.NodeEnd);
            this.Controls.Add(this.NodeStart);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.ShortestPath);
            this.Controls.Add(this.AllEdgesBox);
            this.Controls.Add(this.AddVertex);
            this.Controls.Add(this.AddNewVertex);
            this.Controls.Add(this.AddEdge);
            this.Controls.Add(this.AllVertices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AllVertices;
        private System.Windows.Forms.Button AddEdge;
        private System.Windows.Forms.TextBox AddNewVertex;
        private System.Windows.Forms.Button AddVertex;
        private System.Windows.Forms.ListBox AllEdgesBox;
        private System.Windows.Forms.Button ShortestPath;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox NodeStart;
        private System.Windows.Forms.TextBox NodeEnd;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numPrice;
        private System.Windows.Forms.TextBox numTime;
        private System.Windows.Forms.TextBox numLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NodeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NodeX;
        private System.Windows.Forms.TextBox NodeY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DeleteVertex;
        private System.Windows.Forms.Button DeleteEdge;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ShortPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DeleteVertexInfo;
        private System.Windows.Forms.TextBox DeleteEdgeInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Disable_Enable_Vertex_Info;
        private System.Windows.Forms.Button Diable_Enable_Vertex;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Disable_Enable_Edge_Info;
        private System.Windows.Forms.Button Disable_Enable_Edge;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox OldNameInfo;
    }
}

