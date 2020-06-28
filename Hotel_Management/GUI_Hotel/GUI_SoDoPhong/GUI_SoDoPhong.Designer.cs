namespace Hotel_Management.GUI_SoDoPhong
{
    partial class GUI_SoDoPhong
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
            this.btn_load = new System.Windows.Forms.Button();
            this.flpnlSODOPHONG = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(589, 20);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(150, 45);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "LOAD";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // flpnlSODOPHONG
            // 
            this.flpnlSODOPHONG.AutoScroll = true;
            this.flpnlSODOPHONG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpnlSODOPHONG.Location = new System.Drawing.Point(0, 126);
            this.flpnlSODOPHONG.Name = "flpnlSODOPHONG";
            this.flpnlSODOPHONG.Size = new System.Drawing.Size(1384, 705);
            this.flpnlSODOPHONG.TabIndex = 3;
            // 
            // GUI_SoDoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.flpnlSODOPHONG);
            this.Controls.Add(this.btn_load);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_SoDoPhong";
            this.Size = new System.Drawing.Size(1384, 831);
            this.Load += new System.EventHandler(this.GUI_SoDoPhong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.FlowLayoutPanel flpnlSODOPHONG;
    }
}
