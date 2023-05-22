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
            this.AddNewVertices = new System.Windows.Forms.TextBox();
            this.AddVertex = new System.Windows.Forms.Button();
            this.AllEdges = new System.Windows.Forms.ListBox();
            this.ShortestPath = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Disable_Enable_Edges_Vertex = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
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
            this.AddEdge.Location = new System.Drawing.Point(24, 28);
            this.AddEdge.Name = "AddEdge";
            this.AddEdge.Size = new System.Drawing.Size(97, 29);
            this.AddEdge.TabIndex = 1;
            this.AddEdge.Text = "AddEdge";
            this.AddEdge.UseVisualStyleBackColor = true;
            this.AddEdge.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewVertices
            // 
            this.AddNewVertices.Location = new System.Drawing.Point(196, 139);
            this.AddNewVertices.Name = "AddNewVertices";
            this.AddNewVertices.Size = new System.Drawing.Size(120, 20);
            this.AddNewVertices.TabIndex = 2;
            this.AddNewVertices.TextChanged += new System.EventHandler(this.AddNewVertices_TextChanged);
            // 
            // AddVertex
            // 
            this.AddVertex.Location = new System.Drawing.Point(24, 63);
            this.AddVertex.Name = "AddVertex";
            this.AddVertex.Size = new System.Drawing.Size(97, 29);
            this.AddVertex.TabIndex = 3;
            this.AddVertex.Text = "AddVertex";
            this.AddVertex.UseVisualStyleBackColor = true;
            this.AddVertex.Click += new System.EventHandler(this.AddVertex_Click);
            // 
            // AllEdges
            // 
            this.AllEdges.FormattingEnabled = true;
            this.AllEdges.Location = new System.Drawing.Point(196, 28);
            this.AllEdges.Name = "AllEdges";
            this.AllEdges.Size = new System.Drawing.Size(120, 95);
            this.AllEdges.TabIndex = 4;
            this.AllEdges.SelectedIndexChanged += new System.EventHandler(this.AllEdges_SelectedIndexChanged);
            // 
            // ShortestPath
            // 
            this.ShortestPath.Location = new System.Drawing.Point(24, 98);
            this.ShortestPath.Name = "ShortestPath";
            this.ShortestPath.Size = new System.Drawing.Size(98, 29);
            this.ShortestPath.TabIndex = 5;
            this.ShortestPath.Text = "ShortestPath";
            this.ShortestPath.UseVisualStyleBackColor = true;
            this.ShortestPath.Click += new System.EventHandler(this.ShortestPath_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(24, 207);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(97, 29);
            this.Load.TabIndex = 6;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(24, 242);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 31);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Disable_Enable_Edges_Vertex
            // 
            this.Disable_Enable_Edges_Vertex.Location = new System.Drawing.Point(24, 133);
            this.Disable_Enable_Edges_Vertex.Name = "Disable_Enable_Edges_Vertex";
            this.Disable_Enable_Edges_Vertex.Size = new System.Drawing.Size(97, 31);
            this.Disable_Enable_Edges_Vertex.TabIndex = 8;
            this.Disable_Enable_Edges_Vertex.Text = "Dis/Enable";
            this.Disable_Enable_Edges_Vertex.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(24, 170);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(98, 31);
            this.Edit.TabIndex = 9;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Disable_Enable_Edges_Vertex);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.ShortestPath);
            this.Controls.Add(this.AllEdges);
            this.Controls.Add(this.AddVertex);
            this.Controls.Add(this.AddNewVertices);
            this.Controls.Add(this.AddEdge);
            this.Controls.Add(this.AllVertices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AllVertices;
        private System.Windows.Forms.Button AddEdge;
        private System.Windows.Forms.TextBox AddNewVertices;
        private System.Windows.Forms.Button AddVertex;
        private System.Windows.Forms.ListBox AllEdges;
        private System.Windows.Forms.Button ShortestPath;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Disable_Enable_Edges_Vertex;
        private System.Windows.Forms.Button Edit;
    }
}

