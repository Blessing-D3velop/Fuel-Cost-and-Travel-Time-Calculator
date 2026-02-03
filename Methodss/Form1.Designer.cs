namespace Methodss
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProceed = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblOutput = new Label();
            button1 = new Button();
            btnClear = new Button();
            txtDistance = new TextBox();
            txtFuel = new TextBox();
            txtPrice = new TextBox();
            txtSpeed = new TextBox();
            SuspendLayout();
            // 
            // btnProceed
            // 
            btnProceed.Location = new Point(54, 270);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(104, 41);
            btnProceed.TabIndex = 0;
            btnProceed.Text = "Calculate";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 60);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 2;
            label1.Text = "Distance To be Traveled(km): ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 105);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 3;
            label2.Text = "Vehicle's fuel efficiency(km/I):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 144);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 4;
            label3.Text = "Current fuel price per liter($):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 182);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 5;
            label4.Text = "Speed(km/h):";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(54, 223);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 15);
            lblOutput.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(296, 270);
            button1.Name = "button1";
            button1.Size = new Size(100, 41);
            button1.TabIndex = 7;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(180, 270);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 41);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(296, 57);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(100, 23);
            txtDistance.TabIndex = 10;
            // 
            // txtFuel
            // 
            txtFuel.Location = new Point(296, 97);
            txtFuel.Name = "txtFuel";
            txtFuel.Size = new Size(100, 23);
            txtFuel.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(296, 136);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 14;
            // 
            // txtSpeed
            // 
            txtSpeed.Location = new Point(296, 174);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(100, 23);
            txtSpeed.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.highway;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(462, 353);
            Controls.Add(txtSpeed);
            Controls.Add(txtPrice);
            Controls.Add(txtFuel);
            Controls.Add(txtDistance);
            Controls.Add(btnClear);
            Controls.Add(button1);
            Controls.Add(lblOutput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnProceed);
            Name = "Form1";
            Text = "Fuel Cost And Travel Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProceed;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblOutput;
        private Button button1;
        private Button btnClear;
        private TextBox txtDistance;
        private TextBox txtFuel;
        private TextBox txtPrice;
        private TextBox txtSpeed;
    }
}
