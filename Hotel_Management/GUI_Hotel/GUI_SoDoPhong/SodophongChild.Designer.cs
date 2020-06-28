namespace Hotel_Management.GUI_SoDoPhong
{
    partial class SodophongChild
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_sophong = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_malp = new System.Windows.Forms.Label();
            this.btnsdp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_sophong
            // 
            this.lb_sophong.Location = new System.Drawing.Point(3, 21);
            this.lb_sophong.Name = "lb_sophong";
            this.lb_sophong.Size = new System.Drawing.Size(117, 37);
            this.lb_sophong.TabIndex = 1;
            this.lb_sophong.Text = "label1";
            this.lb_sophong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_status
            // 
            this.lb_status.Location = new System.Drawing.Point(126, 21);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(117, 37);
            this.lb_status.TabIndex = 2;
            this.lb_status.Text = "label1";
            this.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_malp
            // 
            this.lb_malp.Location = new System.Drawing.Point(249, 21);
            this.lb_malp.Name = "lb_malp";
            this.lb_malp.Size = new System.Drawing.Size(117, 37);
            this.lb_malp.TabIndex = 3;
            this.lb_malp.Text = "label1";
            this.lb_malp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsdp
            // 
            this.btnsdp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsdp.Location = new System.Drawing.Point(0, 0);
            this.btnsdp.Name = "btnsdp";
            this.btnsdp.Size = new System.Drawing.Size(385, 78);
            this.btnsdp.TabIndex = 0;
            this.btnsdp.UseVisualStyleBackColor = true;
            // 
            // SodophongChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_malp);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_sophong);
            this.Controls.Add(this.btnsdp);
            this.Name = "SodophongChild";
            this.Size = new System.Drawing.Size(385, 78);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_sophong;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label lb_malp;
        private System.Windows.Forms.Button btnsdp;
    }
}
