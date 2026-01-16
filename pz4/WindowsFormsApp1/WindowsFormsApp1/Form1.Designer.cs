namespace Lab4_Shapes
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
            this.listBoxShapes = new System.Windows.Forms.ListBox();
            this.txtParam1 = new System.Windows.Forms.TextBox();
            this.txtParam2 = new System.Windows.Forms.TextBox();
            this.btnAddCircle = new System.Windows.Forms.Button();
            this.btnAddRect = new System.Windows.Forms.Button();
            this.btnAddSquare = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTotalArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxShapes
            // 
            this.listBoxShapes.FormattingEnabled = true;
            this.listBoxShapes.ItemHeight = 24;
            this.listBoxShapes.Location = new System.Drawing.Point(22, 30);
            this.listBoxShapes.Name = "listBoxShapes";
            this.listBoxShapes.Size = new System.Drawing.Size(1424, 220);
            this.listBoxShapes.TabIndex = 0;
            // 
            // txtParam1
            // 
            this.txtParam1.Location = new System.Drawing.Point(22, 269);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(360, 29);
            this.txtParam1.TabIndex = 1;
            // 
            // txtParam2
            // 
            this.txtParam2.Location = new System.Drawing.Point(22, 315);
            this.txtParam2.Name = "txtParam2";
            this.txtParam2.Size = new System.Drawing.Size(360, 29);
            this.txtParam2.TabIndex = 2;
            // 
            // btnAddCircle
            // 
            this.btnAddCircle.Location = new System.Drawing.Point(506, 372);
            this.btnAddCircle.Name = "btnAddCircle";
            this.btnAddCircle.Size = new System.Drawing.Size(458, 56);
            this.btnAddCircle.TabIndex = 3;
            this.btnAddCircle.Text = "Circle";
            this.btnAddCircle.UseVisualStyleBackColor = true;
            this.btnAddCircle.Click += new System.EventHandler(this.btnAddCircle_Click);
            // 
            // btnAddRect
            // 
            this.btnAddRect.Location = new System.Drawing.Point(988, 372);
            this.btnAddRect.Name = "btnAddRect";
            this.btnAddRect.Size = new System.Drawing.Size(458, 56);
            this.btnAddRect.TabIndex = 4;
            this.btnAddRect.Text = "Rectangle";
            this.btnAddRect.UseVisualStyleBackColor = true;
            this.btnAddRect.Click += new System.EventHandler(this.btnAddRect_Click);
            // 
            // btnAddSquare
            // 
            this.btnAddSquare.Location = new System.Drawing.Point(22, 372);
            this.btnAddSquare.Name = "btnAddSquare";
            this.btnAddSquare.Size = new System.Drawing.Size(458, 56);
            this.btnAddSquare.TabIndex = 5;
            this.btnAddSquare.Text = "Square";
            this.btnAddSquare.UseVisualStyleBackColor = true;
            this.btnAddSquare.Click += new System.EventHandler(this.btnAddSquare_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.ForeColor = System.Drawing.Color.Snow;
            this.btnRemove.Location = new System.Drawing.Point(506, 489);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(458, 83);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblTotalArea
            // 
            this.lblTotalArea.AutoSize = true;
            this.lblTotalArea.Font = new System.Drawing.Font("Franklin Gothic Demi", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalArea.Location = new System.Drawing.Point(12, 657);
            this.lblTotalArea.Name = "lblTotalArea";
            this.lblTotalArea.Size = new System.Drawing.Size(518, 141);
            this.lblTotalArea.TabIndex = 7;
            this.lblTotalArea.Text = "Площа: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 818);
            this.Controls.Add(this.lblTotalArea);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddSquare);
            this.Controls.Add(this.btnAddRect);
            this.Controls.Add(this.btnAddCircle);
            this.Controls.Add(this.txtParam2);
            this.Controls.Add(this.txtParam1);
            this.Controls.Add(this.listBoxShapes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShapes;
        private System.Windows.Forms.TextBox txtParam1;
        private System.Windows.Forms.TextBox txtParam2;
        private System.Windows.Forms.Button btnAddCircle;
        private System.Windows.Forms.Button btnAddRect;
        private System.Windows.Forms.Button btnAddSquare;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotalArea;
    }
}

