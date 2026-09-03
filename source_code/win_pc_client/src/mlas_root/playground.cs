using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

[DesignerGenerated]
public class playground : Form
{
	private IContainer components;

	private List<string> strings;

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TreeView1")]
	internal virtual TreeView TreeView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button2")]
	internal virtual Button Button2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public playground()
	{
		base.Load += playground_Load;
		strings = new List<string>();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.Button1 = new System.Windows.Forms.Button();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.TreeView1 = new System.Windows.Forms.TreeView();
		this.Button2 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.Button1.Location = new System.Drawing.Point(323, 24);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.TextBox1.Location = new System.Drawing.Point(42, 24);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(257, 21);
		this.TextBox1.TabIndex = 1;
		this.TreeView1.Location = new System.Drawing.Point(12, 68);
		this.TreeView1.Name = "TreeView1";
		this.TreeView1.Size = new System.Drawing.Size(225, 430);
		this.TreeView1.TabIndex = 2;
		this.Button2.Location = new System.Drawing.Point(323, 68);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "Button2";
		this.Button2.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(893, 510);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.TreeView1);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Button1);
		base.Name = "playground";
		this.Text = "playground";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void playground_Load(object sender, EventArgs e)
	{
		strings.Add("1");
		strings.Add("1>1");
		strings.Add("1>2");
		strings.Add("1>3");
		strings.Add("1>4");
		strings.Add("1>4>1");
		strings.Add("1>4>2");
		strings.Add("1>4>2>1");
		strings.Add("1>4>2>2");
		strings.Add("1>4>2>3");
		strings.Add("1>5");
		strings.Add("1>5>1");
		strings.Add("2");
		strings.Add("2>1");
		strings.Add("2>2");
		strings.Add("3");
		strings.Add("3>1");
		strings.Add("3>2");
		strings.Add("3>3");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		TreeView1.Nodes.Clear();
		foreach (string @string in strings)
		{
			PutTreeNode(TreeView1, @string);
		}
	}

	private void PutTreeNode(TreeView tv, string path)
	{
		if (path.IndexOf(">") >= 0)
		{
			string[] array = path.Split(new string[1] { ">" }, StringSplitOptions.None);
			TreeNode treeNode = null;
			string[] array2 = array;
			foreach (string textToFind in array2)
			{
				if (treeNode == null)
				{
					treeNode = SearchTheTreeView(tv, textToFind);
					continue;
				}
				TreeNode treeNode2 = SearchTheTreeView(treeNode, textToFind);
				if (treeNode2 != null)
				{
					treeNode = treeNode2;
				}
				else
				{
					treeNode.Nodes.Add(new TreeNode(textToFind));
				}
			}
		}
		else if (SearchTheTreeView(tv, path) == null)
		{
			tv.Nodes.Add(path);
		}
	}

	private TreeNode SearchTheTreeView(TreeView tv, string TextToFind)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = tv.Nodes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				TreeNode treeNode = (TreeNode)enumerator.Current;
				if (Operators.CompareString(treeNode.Text, TextToFind, TextCompare: false) == 0)
				{
					return treeNode;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		return null;
	}

	private TreeNode SearchTheTreeView(TreeNode treeNode, string TextToFind)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = treeNode.Nodes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				TreeNode treeNode2 = (TreeNode)enumerator.Current;
				if (Operators.CompareString(treeNode2.Text, TextToFind, TextCompare: false) == 0)
				{
					return treeNode2;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		return null;
	}
}
