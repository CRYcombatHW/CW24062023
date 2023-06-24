namespace CW24062023
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
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			button = new Button();
			numericDay = new NumericUpDown();
			numericMounth = new NumericUpDown();
			numericYear = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)numericDay).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericMounth).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericYear).BeginInit();
			SuspendLayout();
			// 
			// button
			// 
			button.Location = new Point(12, 93);
			button.Name = "button";
			button.Size = new Size(258, 23);
			button.TabIndex = 1;
			button.Text = "button";
			button.UseVisualStyleBackColor = true;
			button.Click += button_Click;
			// 
			// numericDay
			// 
			numericDay.Location = new Point(12, 12);
			numericDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
			numericDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericDay.Name = "numericDay";
			numericDay.Size = new Size(82, 23);
			numericDay.TabIndex = 2;
			numericDay.Value = new decimal(new int[] { 24, 0, 0, 0 });
			// 
			// numericMounth
			// 
			numericMounth.Location = new Point(100, 12);
			numericMounth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
			numericMounth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericMounth.Name = "numericMounth";
			numericMounth.Size = new Size(82, 23);
			numericMounth.TabIndex = 3;
			numericMounth.Value = new decimal(new int[] { 6, 0, 0, 0 });
			numericMounth.ValueChanged += numeric_UdpateDay;
			// 
			// numericYear
			// 
			numericYear.Location = new Point(188, 12);
			numericYear.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numericYear.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericYear.Name = "numericYear";
			numericYear.Size = new Size(82, 23);
			numericYear.TabIndex = 4;
			numericYear.Value = new decimal(new int[] { 2023, 0, 0, 0 });
			numericYear.ValueChanged += numeric_UdpateDay;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(284, 128);
			Controls.Add(numericYear);
			Controls.Add(numericMounth);
			Controls.Add(numericDay);
			Controls.Add(button);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)numericDay).EndInit();
			((System.ComponentModel.ISupportInitialize)numericMounth).EndInit();
			((System.ComponentModel.ISupportInitialize)numericYear).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Button button;
		private NumericUpDown numericDay;
		private NumericUpDown numericMounth;
		private NumericUpDown numericYear;
	}
}