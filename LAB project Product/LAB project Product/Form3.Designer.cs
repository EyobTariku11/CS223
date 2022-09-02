namespace LAB_project_Product
{
    partial class update1
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
            this.txt_object = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_object
            // 
            this.txt_object.AutoSize = true;
            this.txt_object.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_object.Location = new System.Drawing.Point(192, 153);
            this.txt_object.Name = "txt_object";
            this.txt_object.Size = new System.Drawing.Size(122, 22);
            this.txt_object.TabIndex = 5;
            this.txt_object.Text = "Object name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(228, 243);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(109, 30);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Find";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(410, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // update1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_object);
            this.Name = "update1";
            this.Text = "Update1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_object;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button button1;
    }
}