/*
 * 由SharpDevelop创建。
 * 用户： admin
 * 日期: 2018/11/16
 * 时间: 11:17
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace UICalculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox baseWidth;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox baseHeight;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox lInput;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox lOutput;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox topInput;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox topOutput;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox widthInput;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox widthOutput;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox heightInput;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox heightOutput;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label copyboard;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.baseWidth = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.baseHeight = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lInput = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lOutput = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.topInput = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.topOutput = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.widthInput = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.widthOutput = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.heightInput = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.heightOutput = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.copyboard = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "基本版面：长：";
			// 
			// baseWidth
			// 
			this.baseWidth.Location = new System.Drawing.Point(109, 6);
			this.baseWidth.Name = "baseWidth";
			this.baseWidth.Size = new System.Drawing.Size(100, 21);
			this.baseWidth.TabIndex = 1;
			this.baseWidth.Text = "960";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(215, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "高：";
			// 
			// baseHeight
			// 
			this.baseHeight.Location = new System.Drawing.Point(252, 6);
			this.baseHeight.Name = "baseHeight";
			this.baseHeight.Size = new System.Drawing.Size(100, 21);
			this.baseHeight.TabIndex = 3;
			this.baseHeight.Text = "540";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "元素信息：左：";
			// 
			// lInput
			// 
			this.lInput.Location = new System.Drawing.Point(109, 39);
			this.lInput.Name = "lInput";
			this.lInput.Size = new System.Drawing.Size(100, 21);
			this.lInput.TabIndex = 5;
			this.lInput.TextChanged += new System.EventHandler(this.LinputTextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(215, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "像素";
			// 
			// lOutput
			// 
			this.lOutput.Location = new System.Drawing.Point(374, 38);
			this.lOutput.Name = "lOutput";
			this.lOutput.Size = new System.Drawing.Size(64, 21);
			this.lOutput.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(353, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(11, 12);
			this.label5.TabIndex = 8;
			this.label5.Text = "=";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(444, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(11, 12);
			this.label6.TabIndex = 9;
			this.label6.Text = "%";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(468, 37);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "复制";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(74, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 12);
			this.label7.TabIndex = 4;
			this.label7.Text = "上：";
			// 
			// topInput
			// 
			this.topInput.Location = new System.Drawing.Point(252, 77);
			this.topInput.Name = "topInput";
			this.topInput.Size = new System.Drawing.Size(65, 21);
			this.topInput.TabIndex = 5;
			this.topInput.TextChanged += new System.EventHandler(this.topInputTextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(323, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 6;
			this.label8.Text = "像素";
			// 
			// topOutput
			// 
			this.topOutput.Location = new System.Drawing.Point(374, 77);
			this.topOutput.Name = "topOutput";
			this.topOutput.Size = new System.Drawing.Size(64, 21);
			this.topOutput.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(353, 81);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(11, 12);
			this.label9.TabIndex = 8;
			this.label9.Text = "=";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(444, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(11, 12);
			this.label10.TabIndex = 9;
			this.label10.Text = "%";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(468, 76);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "复制";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(72, 120);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 12);
			this.label11.TabIndex = 4;
			this.label11.Text = "长：";
			// 
			// widthInput
			// 
			this.widthInput.Location = new System.Drawing.Point(109, 117);
			this.widthInput.Name = "widthInput";
			this.widthInput.Size = new System.Drawing.Size(100, 21);
			this.widthInput.TabIndex = 5;
			this.widthInput.TextChanged += new System.EventHandler(this.widthInputTextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(215, 120);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(29, 12);
			this.label12.TabIndex = 6;
			this.label12.Text = "像素";
			// 
			// widthOutput
			// 
			this.widthOutput.Location = new System.Drawing.Point(374, 116);
			this.widthOutput.Name = "widthOutput";
			this.widthOutput.Size = new System.Drawing.Size(64, 21);
			this.widthOutput.TabIndex = 7;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(353, 120);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(11, 12);
			this.label13.TabIndex = 8;
			this.label13.Text = "=";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(444, 119);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(11, 12);
			this.label14.TabIndex = 9;
			this.label14.Text = "%";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(468, 115);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 10;
			this.button3.Text = "复制";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(72, 157);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(29, 12);
			this.label15.TabIndex = 4;
			this.label15.Text = "高：";
			// 
			// heightInput
			// 
			this.heightInput.Location = new System.Drawing.Point(252, 154);
			this.heightInput.Name = "heightInput";
			this.heightInput.Size = new System.Drawing.Size(65, 21);
			this.heightInput.TabIndex = 5;
			this.heightInput.TextChanged += new System.EventHandler(this.heightInputTextChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(323, 157);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(29, 12);
			this.label16.TabIndex = 6;
			this.label16.Text = "像素";
			// 
			// heightOutput
			// 
			this.heightOutput.Location = new System.Drawing.Point(374, 154);
			this.heightOutput.Name = "heightOutput";
			this.heightOutput.Size = new System.Drawing.Size(64, 21);
			this.heightOutput.TabIndex = 7;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(353, 158);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(11, 12);
			this.label17.TabIndex = 8;
			this.label17.Text = "=";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(444, 157);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(11, 12);
			this.label18.TabIndex = 9;
			this.label18.Text = "%";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(468, 153);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 10;
			this.button4.Text = "复制";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// copyboard
			// 
			this.copyboard.Location = new System.Drawing.Point(12, 217);
			this.copyboard.Name = "copyboard";
			this.copyboard.Size = new System.Drawing.Size(531, 29);
			this.copyboard.TabIndex = 11;
			this.copyboard.Text = "复制信息版：未复制";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 255);
			this.Controls.Add(this.copyboard);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.heightOutput);
			this.Controls.Add(this.topOutput);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.widthOutput);
			this.Controls.Add(this.lOutput);
			this.Controls.Add(this.heightInput);
			this.Controls.Add(this.topInput);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.widthInput);
			this.Controls.Add(this.lInput);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.baseHeight);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.baseWidth);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "UI百分比速算";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
