namespace ShapePerimeterCalculatorClient
{
    partial class mainForm
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
            this.shapeLabel = new System.Windows.Forms.Label();
            this.paramLabel1 = new System.Windows.Forms.Label();
            this.paramLabel3 = new System.Windows.Forms.Label();
            this.paramLabel2 = new System.Windows.Forms.Label();
            this.comboBoxShapes = new System.Windows.Forms.ComboBox();
            this.textBoxParam1 = new System.Windows.Forms.TextBox();
            this.textBoxParam2 = new System.Windows.Forms.TextBox();
            this.textBoxParam3 = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.PerimeterLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(54, 48);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(44, 13);
            this.shapeLabel.TabIndex = 0;
            this.shapeLabel.Text = "Shape :";
            // 
            // paramLabel1
            // 
            this.paramLabel1.AutoSize = true;
            this.paramLabel1.Location = new System.Drawing.Point(121, 117);
            this.paramLabel1.Name = "paramLabel1";
            this.paramLabel1.Size = new System.Drawing.Size(70, 13);
            this.paramLabel1.TabIndex = 1;
            this.paramLabel1.Text = "Parameter 1 :";
            // 
            // paramLabel3
            // 
            this.paramLabel3.AutoSize = true;
            this.paramLabel3.Location = new System.Drawing.Point(121, 223);
            this.paramLabel3.Name = "paramLabel3";
            this.paramLabel3.Size = new System.Drawing.Size(70, 13);
            this.paramLabel3.TabIndex = 2;
            this.paramLabel3.Text = "Parameter 3 :";
            // 
            // paramLabel2
            // 
            this.paramLabel2.AutoSize = true;
            this.paramLabel2.Location = new System.Drawing.Point(121, 172);
            this.paramLabel2.Name = "paramLabel2";
            this.paramLabel2.Size = new System.Drawing.Size(70, 13);
            this.paramLabel2.TabIndex = 3;
            this.paramLabel2.Text = "Parameter 2 :";
            // 
            // comboBoxShapes
            // 
            this.comboBoxShapes.FormattingEnabled = true;
            this.comboBoxShapes.Location = new System.Drawing.Point(157, 45);
            this.comboBoxShapes.Name = "comboBoxShapes";
            this.comboBoxShapes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShapes.TabIndex = 4;
            this.comboBoxShapes.Text = "Select Shape";
            this.comboBoxShapes.SelectedIndexChanged += new System.EventHandler(this.comboBoxShapes_SelectedIndexChanged);
            // 
            // textBoxParam1
            // 
            this.textBoxParam1.Location = new System.Drawing.Point(274, 114);
            this.textBoxParam1.Name = "textBoxParam1";
            this.textBoxParam1.Size = new System.Drawing.Size(100, 20);
            this.textBoxParam1.TabIndex = 5;
            // 
            // textBoxParam2
            // 
            this.textBoxParam2.Location = new System.Drawing.Point(274, 165);
            this.textBoxParam2.Name = "textBoxParam2";
            this.textBoxParam2.Size = new System.Drawing.Size(100, 20);
            this.textBoxParam2.TabIndex = 6;
            // 
            // textBoxParam3
            // 
            this.textBoxParam3.Location = new System.Drawing.Point(274, 216);
            this.textBoxParam3.Name = "textBoxParam3";
            this.textBoxParam3.Size = new System.Drawing.Size(100, 20);
            this.textBoxParam3.TabIndex = 7;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(216, 290);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 8;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(333, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PerimeterLabel
            // 
            this.PerimeterLabel.AutoSize = true;
            this.PerimeterLabel.Location = new System.Drawing.Point(154, 358);
            this.PerimeterLabel.Name = "PerimeterLabel";
            this.PerimeterLabel.Size = new System.Drawing.Size(57, 13);
            this.PerimeterLabel.TabIndex = 10;
            this.PerimeterLabel.Text = "Perimeter :";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(296, 358);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 11;
            this.resultLabel.Text = "Result";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 413);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.PerimeterLabel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.textBoxParam3);
            this.Controls.Add(this.textBoxParam2);
            this.Controls.Add(this.textBoxParam1);
            this.Controls.Add(this.comboBoxShapes);
            this.Controls.Add(this.paramLabel2);
            this.Controls.Add(this.paramLabel3);
            this.Controls.Add(this.paramLabel1);
            this.Controls.Add(this.shapeLabel);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shape Perimeter Calculator";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.Label paramLabel1;
        private System.Windows.Forms.Label paramLabel3;
        private System.Windows.Forms.Label paramLabel2;
        private System.Windows.Forms.ComboBox comboBoxShapes;
        private System.Windows.Forms.TextBox textBoxParam1;
        private System.Windows.Forms.TextBox textBoxParam2;
        private System.Windows.Forms.TextBox textBoxParam3;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label PerimeterLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

