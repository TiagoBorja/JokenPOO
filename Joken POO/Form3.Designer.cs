namespace Joken_POO
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pedraBox1 = new System.Windows.Forms.PictureBox();
            this.ganhaBox = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.empateBox = new System.Windows.Forms.PictureBox();
            this.papelBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.perdeBox = new System.Windows.Forms.PictureBox();
            this.tesouraBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pedraBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganhaBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papelBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perdeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesouraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pedraBox1
            // 
            this.pedraBox1.Image = global::Joken_POO.Properties.Resources.Preda;
            this.pedraBox1.Location = new System.Drawing.Point(44, 61);
            this.pedraBox1.Name = "pedraBox1";
            this.pedraBox1.Size = new System.Drawing.Size(150, 150);
            this.pedraBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pedraBox1.TabIndex = 0;
            this.pedraBox1.TabStop = false;
            this.pedraBox1.Click += new System.EventHandler(this.pedraBox1_Click_1);
            // 
            // ganhaBox
            // 
            this.ganhaBox.Location = new System.Drawing.Point(44, 295);
            this.ganhaBox.Name = "ganhaBox";
            this.ganhaBox.Size = new System.Drawing.Size(150, 150);
            this.ganhaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ganhaBox.TabIndex = 3;
            this.ganhaBox.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Preda.png");
            this.imageList1.Images.SetKeyName(1, "Papel.png");
            this.imageList1.Images.SetKeyName(2, "Tesoura.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ganha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.ganhaBox);
            this.panel1.Controls.Add(this.pedraBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 495);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.empateBox);
            this.panel2.Controls.Add(this.papelBox);
            this.panel2.Location = new System.Drawing.Point(255, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 495);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Empata";
            // 
            // empateBox
            // 
            this.empateBox.Location = new System.Drawing.Point(66, 297);
            this.empateBox.Name = "empateBox";
            this.empateBox.Size = new System.Drawing.Size(150, 150);
            this.empateBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.empateBox.TabIndex = 9;
            this.empateBox.TabStop = false;
            // 
            // papelBox
            // 
            this.papelBox.Image = global::Joken_POO.Properties.Resources.Papel;
            this.papelBox.Location = new System.Drawing.Point(66, 75);
            this.papelBox.Name = "papelBox";
            this.papelBox.Size = new System.Drawing.Size(150, 150);
            this.papelBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.papelBox.TabIndex = 8;
            this.papelBox.TabStop = false;
            this.papelBox.Click += new System.EventHandler(this.papelBox_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.perdeBox);
            this.panel3.Controls.Add(this.tesouraBox);
            this.panel3.Location = new System.Drawing.Point(544, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 495);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Perde";
            // 
            // perdeBox
            // 
            this.perdeBox.Location = new System.Drawing.Point(47, 297);
            this.perdeBox.Name = "perdeBox";
            this.perdeBox.Size = new System.Drawing.Size(150, 150);
            this.perdeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.perdeBox.TabIndex = 10;
            this.perdeBox.TabStop = false;
            // 
            // tesouraBox
            // 
            this.tesouraBox.Image = global::Joken_POO.Properties.Resources.Tesoura1;
            this.tesouraBox.Location = new System.Drawing.Point(47, 75);
            this.tesouraBox.Name = "tesouraBox";
            this.tesouraBox.Size = new System.Drawing.Size(150, 150);
            this.tesouraBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tesouraBox.TabIndex = 9;
            this.tesouraBox.TabStop = false;
            this.tesouraBox.Click += new System.EventHandler(this.tesouraBox_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(66, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 504);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedraBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganhaBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papelBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perdeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesouraBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pedraBox1;
        private System.Windows.Forms.PictureBox ganhaBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox empateBox;
        private System.Windows.Forms.PictureBox papelBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox perdeBox;
        private System.Windows.Forms.PictureBox tesouraBox;
        private System.Windows.Forms.Button button1;
    }
}