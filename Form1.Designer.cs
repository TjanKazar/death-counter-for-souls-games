namespace death_counter
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
			label1 = new Label();
			number = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ActiveCaptionText;
			label1.Location = new Point(20, 9);
			label1.Name = "label1";
			label1.Size = new Size(162, 57);
			label1.TabIndex = 0;
			label1.Text = "DEATHS";
			label1.Click += label1_Click;
			// 
			// number
			// 
			number.AutoSize = true;
			number.Font = new Font("Bernard MT Condensed", 36F);
			number.ForeColor = Color.WhiteSmoke;
			number.Location = new Point(53, 71);
			number.Name = "number";
			number.Size = new Size(104, 57);
			number.TabIndex = 3;
			number.Text = "zero";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			ClientSize = new Size(194, 137);
			Controls.Add(number);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label number;
	}
}
