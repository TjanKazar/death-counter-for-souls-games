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
			labelRadahn = new Label();
			numberRadahn = new Label();
			radahnMode = new Button();
			radioButton1 = new RadioButton();
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
			number.Location = new Point(36, 66);
			number.Name = "number";
			number.Size = new Size(104, 57);
			number.TabIndex = 3;
			number.Text = "zero";
			// 
			// labelRadahn
			// 
			labelRadahn.AutoSize = true;
			labelRadahn.BackColor = SystemColors.ActiveCaptionText;
			labelRadahn.BorderStyle = BorderStyle.FixedSingle;
			labelRadahn.Font = new Font("Bernard MT Condensed", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
			labelRadahn.ForeColor = Color.Crimson;
			labelRadahn.Location = new Point(-2, 123);
			labelRadahn.Name = "labelRadahn";
			labelRadahn.Size = new Size(204, 40);
			labelRadahn.TabIndex = 4;
			labelRadahn.Text = "Radahn Deaths";
			// 
			// numberRadahn
			// 
			numberRadahn.AutoSize = true;
			numberRadahn.Font = new Font("Bernard MT Condensed", 36F);
			numberRadahn.ForeColor = Color.Goldenrod;
			numberRadahn.Location = new Point(47, 161);
			numberRadahn.Name = "numberRadahn";
			numberRadahn.Size = new Size(104, 57);
			numberRadahn.TabIndex = 5;
			numberRadahn.Text = "zero";
			// 
			// radahnMode
			// 
			radahnMode.BackColor = Color.PaleGreen;
			radahnMode.Font = new Font("Bernard MT Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			radahnMode.Location = new Point(-9, 221);
			radahnMode.Name = "radahnMode";
			radahnMode.Size = new Size(211, 48);
			radahnMode.TabIndex = 6;
			radahnMode.Text = "Radahn mode off/on";
			radahnMode.UseVisualStyleBackColor = false;
			radahnMode.Click += radahnMode_Click;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(168, 197);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(14, 13);
			radioButton1.TabIndex = 7;
			radioButton1.TabStop = true;
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			ClientSize = new Size(194, 262);
			Controls.Add(radioButton1);
			Controls.Add(radahnMode);
			Controls.Add(numberRadahn);
			Controls.Add(labelRadahn);
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
		private Label labelRadahn;
		private Label numberRadahn;
		private Button radahnMode;
		private RadioButton radioButton1;
	}
}
