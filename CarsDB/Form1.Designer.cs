namespace CarsDB
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
            this.label2 = new System.Windows.Forms.Label();
            this.listCarMark = new System.Windows.Forms.ListBox();
            this.listCarInGarage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Mark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car In Garage";
            // 
            // listCarMark
            // 
            this.listCarMark.FormattingEnabled = true;
            this.listCarMark.ItemHeight = 16;
            this.listCarMark.Location = new System.Drawing.Point(75, 137);
            this.listCarMark.Name = "listCarMark";
            this.listCarMark.Size = new System.Drawing.Size(120, 84);
            this.listCarMark.TabIndex = 2;
            this.listCarMark.SelectedIndexChanged += new System.EventHandler(this.listCarMark_SelectedIndexChanged);
            // 
            // listCarInGarage
            // 
            this.listCarInGarage.FormattingEnabled = true;
            this.listCarInGarage.ItemHeight = 16;
            this.listCarInGarage.Location = new System.Drawing.Point(389, 137);
            this.listCarInGarage.Name = "listCarInGarage";
            this.listCarInGarage.Size = new System.Drawing.Size(120, 84);
            this.listCarInGarage.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listCarInGarage);
            this.Controls.Add(this.listCarMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCarMark;
        private System.Windows.Forms.ListBox listCarInGarage;
    }
}

