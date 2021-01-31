namespace FormBusSeats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userControlBus1 = new CustomBusReservation.UserControlBus();
            this.SuspendLayout();
            // 
            // userControlBus1
            // 
            this.userControlBus1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlBus1.BackgroundImage")));
            this.userControlBus1.Capacity = 8;
            this.userControlBus1.FreeSeats = 8;
            this.userControlBus1.Location = new System.Drawing.Point(12, 36);
            this.userControlBus1.Name = "userControlBus1";
            this.userControlBus1.Size = new System.Drawing.Size(1068, 538);
            this.userControlBus1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 586);
            this.Controls.Add(this.userControlBus1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomBusReservation.UserControlBus userControlBus1;
    }
}

