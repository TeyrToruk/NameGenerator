namespace NameGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.genButton = new System.Windows.Forms.Button();
            this.genBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.min_length_box = new System.Windows.Forms.NumericUpDown();
            this.max_length_box = new System.Windows.Forms.NumericUpDown();
            this.max_in_row_box = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_length_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_length_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_in_row_box)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Name Generator";
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(12, 56);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(337, 88);
            this.genButton.TabIndex = 1;
            this.genButton.Text = "Generate New Name";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // genBox
            // 
            this.genBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genBox.Location = new System.Drawing.Point(12, 12);
            this.genBox.Name = "genBox";
            this.genBox.Size = new System.Drawing.Size(337, 38);
            this.genBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "V0.2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.max_in_row_box);
            this.groupBox1.Controls.Add(this.max_length_box);
            this.groupBox1.Controls.Add(this.min_length_box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(355, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 98);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Max Name Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Min Name Length:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Max in-a-row vowels/consonants:";
            // 
            // min_length_box
            // 
            this.min_length_box.Location = new System.Drawing.Point(185, 14);
            this.min_length_box.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.min_length_box.Name = "min_length_box";
            this.min_length_box.Size = new System.Drawing.Size(120, 20);
            this.min_length_box.TabIndex = 3;
            this.min_length_box.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // max_length_box
            // 
            this.max_length_box.Location = new System.Drawing.Point(185, 40);
            this.max_length_box.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.max_length_box.Name = "max_length_box";
            this.max_length_box.Size = new System.Drawing.Size(120, 20);
            this.max_length_box.TabIndex = 3;
            this.max_length_box.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // max_in_row_box
            // 
            this.max_in_row_box.Location = new System.Drawing.Point(185, 66);
            this.max_in_row_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.max_in_row_box.Name = "max_in_row_box";
            this.max_in_row_box.Size = new System.Drawing.Size(120, 20);
            this.max_in_row_box.TabIndex = 3;
            this.max_in_row_box.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 157);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.genBox);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Name Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_length_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_length_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_in_row_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.TextBox genBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown max_in_row_box;
        private System.Windows.Forms.NumericUpDown max_length_box;
        private System.Windows.Forms.NumericUpDown min_length_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

