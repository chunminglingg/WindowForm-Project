namespace OOP_Practice
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
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.txt_floor = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_des = new System.Windows.Forms.Label();
            this.lb_floor = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(314, 277);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(105, 34);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(132, 129);
            this.txt_des.Margin = new System.Windows.Forms.Padding(4);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(237, 126);
            this.txt_des.TabIndex = 7;
            // 
            // txt_floor
            // 
            this.txt_floor.Location = new System.Drawing.Point(132, 83);
            this.txt_floor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_floor.Name = "txt_floor";
            this.txt_floor.Size = new System.Drawing.Size(237, 22);
            this.txt_floor.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(132, 50);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(237, 22);
            this.txt_name.TabIndex = 9;
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.Location = new System.Drawing.Point(34, 132);
            this.lb_des.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(75, 16);
            this.lb_des.TabIndex = 4;
            this.lb_des.Text = "Description";
            // 
            // lb_floor
            // 
            this.lb_floor.AutoSize = true;
            this.lb_floor.Location = new System.Drawing.Point(34, 83);
            this.lb_floor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_floor.Name = "lb_floor";
            this.lb_floor.Size = new System.Drawing.Size(38, 16);
            this.lb_floor.TabIndex = 5;
            this.lb_floor.Text = "Floor";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(34, 50);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(44, 16);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 600);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.txt_floor);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lb_des);
            this.Controls.Add(this.lb_floor);
            this.Controls.Add(this.lb_name);
            this.Name = "Form1";
            this.Text = "Listing App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.TextBox txt_floor;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lb_des;
        private System.Windows.Forms.Label lb_floor;
        private System.Windows.Forms.Label lb_name;
    }
}

