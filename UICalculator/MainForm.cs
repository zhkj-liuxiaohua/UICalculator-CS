/*
 * 由SharpDevelop创建。
 * 用户： admin
 * 日期: 2018/11/16
 * 时间: 11:17
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UICalculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(lOutput.Text)) {
				Clipboard.SetDataObject(lOutput.Text, true);
				copyboard.Text = "左百分比已复制，内容：" + lOutput.Text + "%";
			}
		}
		void LinputTextChanged(object sender, EventArgs e)
		{
			try {
				lOutput.Text =  String.Format("{0:F2}", (double.Parse(lInput.Text)) * 100 / double.Parse(baseWidth.Text));
			} catch(Exception) {
				lOutput.Text = "Err";
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(topOutput.Text)) {
				Clipboard.SetDataObject(topOutput.Text, true);
				copyboard.Text = "上百分比已复制，内容：" + topOutput.Text + "%";
			}
		}
		void topInputTextChanged(object sender, EventArgs e)
		{
			try {
				topOutput.Text =  String.Format("{0:F2}", (double.Parse(topInput.Text)) * 100 / double.Parse(baseHeight.Text));
			} catch(Exception) {
				topOutput.Text = "Err";
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(widthOutput.Text)) {
				Clipboard.SetDataObject(widthOutput.Text, true);
				copyboard.Text = "长百分比已复制，内容：" + widthOutput.Text + "%";
			}
		}
		void widthInputTextChanged(object sender, EventArgs e)
		{
			try {
				widthOutput.Text =  String.Format("{0:F2}", (double.Parse(widthInput.Text)) * 100 / double.Parse(baseWidth.Text));
			} catch(Exception) {
				lOutput.Text = "Err";
			}
		}
		void Button4Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(heightOutput.Text)) {
				Clipboard.SetDataObject(heightOutput.Text, true);
				copyboard.Text = "高百分比已复制，内容：" + heightOutput.Text + "%";
			}
		}
		void heightInputTextChanged(object sender, EventArgs e)
		{
			try {
				heightOutput.Text =  String.Format("{0:F2}", (double.Parse(heightInput.Text)) * 100 / double.Parse(baseHeight.Text));
			} catch(Exception) {
				lOutput.Text = "Err";
			}
		}
	}
}
