namespace MGR
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
            this.OpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.buttonXDondur = new System.Windows.Forms.Button();
            this.buttonYDondur = new System.Windows.Forms.Button();
            this.buttonZDondur = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // OpenGlControl
            // 
            this.OpenGlControl.AccumBits = ((byte)(0));
            this.OpenGlControl.AutoCheckErrors = false;
            this.OpenGlControl.AutoFinish = false;
            this.OpenGlControl.AutoMakeCurrent = true;
            this.OpenGlControl.AutoSwapBuffers = true;
            this.OpenGlControl.BackColor = System.Drawing.Color.Black;
            this.OpenGlControl.ColorBits = ((byte)(32));
            this.OpenGlControl.DepthBits = ((byte)(16));
            this.OpenGlControl.Location = new System.Drawing.Point(0, -1);
            this.OpenGlControl.Name = "OpenGlControl";
            this.OpenGlControl.Size = new System.Drawing.Size(1163, 607);
            this.OpenGlControl.StencilBits = ((byte)(0));
            this.OpenGlControl.TabIndex = 0;
            this.OpenGlControl.Load += new System.EventHandler(this.OpenGlControl_Load);
            this.OpenGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPaint);
            this.OpenGlControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.OpenGlControl.MouseHover += new System.EventHandler(this.MyMouseHover);
            this.OpenGlControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyMouseMove);
            // 
            // buttonXDondur
            // 
            this.buttonXDondur.Location = new System.Drawing.Point(1184, 28);
            this.buttonXDondur.Name = "buttonXDondur";
            this.buttonXDondur.Size = new System.Drawing.Size(124, 66);
            this.buttonXDondur.TabIndex = 1;
            this.buttonXDondur.Text = "X dondur";
            this.buttonXDondur.UseVisualStyleBackColor = true;
            this.buttonXDondur.Click += new System.EventHandler(this.buttonXDondur_Click);
            // 
            // buttonYDondur
            // 
            this.buttonYDondur.Location = new System.Drawing.Point(1184, 247);
            this.buttonYDondur.Name = "buttonYDondur";
            this.buttonYDondur.Size = new System.Drawing.Size(124, 66);
            this.buttonYDondur.TabIndex = 2;
            this.buttonYDondur.Text = "Y dondur";
            this.buttonYDondur.UseVisualStyleBackColor = true;
            this.buttonYDondur.Click += new System.EventHandler(this.buttonYDondur_Click);
            // 
            // buttonZDondur
            // 
            this.buttonZDondur.Location = new System.Drawing.Point(1184, 474);
            this.buttonZDondur.Name = "buttonZDondur";
            this.buttonZDondur.Size = new System.Drawing.Size(124, 66);
            this.buttonZDondur.TabIndex = 3;
            this.buttonZDondur.Text = "Z dondur";
            this.buttonZDondur.UseVisualStyleBackColor = true;
            this.buttonZDondur.Click += new System.EventHandler(this.buttonZDondur_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 607);
            this.Controls.Add(this.buttonZDondur);
            this.Controls.Add(this.buttonYDondur);
            this.Controls.Add(this.buttonXDondur);
            this.Controls.Add(this.OpenGlControl);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKey);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl OpenGlControl;
        private System.Windows.Forms.Button buttonXDondur;
        private System.Windows.Forms.Button buttonYDondur;
        private System.Windows.Forms.Button buttonZDondur;
        private System.Windows.Forms.Timer timer1;
    }
}