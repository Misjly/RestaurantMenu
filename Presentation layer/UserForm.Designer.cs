namespace Object_2.Presentation_layer
{
    partial class UserForm
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
            this.AgeBox = new System.Windows.Forms.NumericUpDown();
            this.WeightBox = new System.Windows.Forms.NumericUpDown();
            this.HeightBox = new System.Windows.Forms.NumericUpDown();
            this.ActivityBox = new System.Windows.Forms.ListBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.ActivityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AgeBox
            // 
            this.AgeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeBox.Location = new System.Drawing.Point(335, 37);
            this.AgeBox.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.AgeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(173, 38);
            this.AgeBox.TabIndex = 0;
            this.AgeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WeightBox
            // 
            this.WeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightBox.Location = new System.Drawing.Point(335, 81);
            this.WeightBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.WeightBox.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(173, 38);
            this.WeightBox.TabIndex = 1;
            this.WeightBox.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // HeightBox
            // 
            this.HeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightBox.Location = new System.Drawing.Point(335, 125);
            this.HeightBox.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.HeightBox.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(173, 38);
            this.HeightBox.TabIndex = 2;
            this.HeightBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ActivityBox
            // 
            this.ActivityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivityBox.FormattingEnabled = true;
            this.ActivityBox.ItemHeight = 31;
            this.ActivityBox.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "Average",
            "High"});
            this.ActivityBox.Location = new System.Drawing.Point(335, 170);
            this.ActivityBox.Name = "ActivityBox";
            this.ActivityBox.Size = new System.Drawing.Size(173, 128);
            this.ActivityBox.TabIndex = 3;
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(335, 355);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(173, 59);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeLabel.Location = new System.Drawing.Point(68, 43);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(66, 32);
            this.AgeLabel.TabIndex = 5;
            this.AgeLabel.Text = "Age";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightLabel.Location = new System.Drawing.Point(68, 87);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(104, 32);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "Weight";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightLabel.Location = new System.Drawing.Point(68, 131);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(98, 32);
            this.HeightLabel.TabIndex = 7;
            this.HeightLabel.Text = "Height";
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivityLabel.Location = new System.Drawing.Point(68, 266);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(106, 32);
            this.ActivityLabel.TabIndex = 8;
            this.ActivityLabel.Text = "Activity";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActivityLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.ActivityBox);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.AgeBox);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown AgeBox;
        private System.Windows.Forms.NumericUpDown WeightBox;
        private System.Windows.Forms.NumericUpDown HeightBox;
        private System.Windows.Forms.ListBox ActivityBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label ActivityLabel;
    }
}