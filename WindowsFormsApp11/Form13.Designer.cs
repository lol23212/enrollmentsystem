namespace WindowsFormsApp1
{
    partial class formgradesput
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbclass = new System.Windows.Forms.Label();
            this.lbcllass = new System.Windows.Forms.Label();
            this.lbprogr = new System.Windows.Forms.Label();
            this.lbprog = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(238, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(442, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbclass
            // 
            this.lbclass.AutoSize = true;
            this.lbclass.BackColor = System.Drawing.Color.Transparent;
            this.lbclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclass.Location = new System.Drawing.Point(22, 9);
            this.lbclass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbclass.Name = "lbclass";
            this.lbclass.Size = new System.Drawing.Size(62, 17);
            this.lbclass.TabIndex = 47;
            this.lbclass.Text = "CLASS:";
            // 
            // lbcllass
            // 
            this.lbcllass.AutoSize = true;
            this.lbcllass.BackColor = System.Drawing.Color.Transparent;
            this.lbcllass.Location = new System.Drawing.Point(111, 9);
            this.lbcllass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcllass.Name = "lbcllass";
            this.lbcllass.Size = new System.Drawing.Size(51, 16);
            this.lbcllass.TabIndex = 48;
            this.lbcllass.Text = "label12";
            // 
            // lbprogr
            // 
            this.lbprogr.AutoSize = true;
            this.lbprogr.BackColor = System.Drawing.Color.Transparent;
            this.lbprogr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprogr.Location = new System.Drawing.Point(261, 9);
            this.lbprogr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbprogr.Name = "lbprogr";
            this.lbprogr.Size = new System.Drawing.Size(86, 17);
            this.lbprogr.TabIndex = 49;
            this.lbprogr.Text = "PROGRAM";
            // 
            // lbprog
            // 
            this.lbprog.AutoSize = true;
            this.lbprog.BackColor = System.Drawing.Color.Transparent;
            this.lbprog.Location = new System.Drawing.Point(397, 9);
            this.lbprog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbprog.Name = "lbprog";
            this.lbprog.Size = new System.Drawing.Size(51, 16);
            this.lbprog.TabIndex = 50;
            this.lbprog.Text = "label12";
            this.lbprog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "STUDENT ID:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.BackColor = System.Drawing.Color.Transparent;
            this.lbid.Location = new System.Drawing.Point(646, 9);
            this.lbid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(51, 16);
            this.lbid.TabIndex = 52;
            this.lbid.Text = "label12";
            this.lbid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formgradesput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.lbprogr);
            this.Controls.Add(this.lbprog);
            this.Controls.Add(this.lbclass);
            this.Controls.Add(this.lbcllass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formgradesput";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.formgradesput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbclass;
        private System.Windows.Forms.Label lbcllass;
        private System.Windows.Forms.Label lbprogr;
        private System.Windows.Forms.Label lbprog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbid;
    }
}