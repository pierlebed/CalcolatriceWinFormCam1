namespace CalcolatriceWinFormCam1
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
    protected override void Dispose ( bool disposing )
    {
      if(disposing && (components != null))
      {
        components.Dispose ( );
      }
      base.Dispose (disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent ( )
    {
      components = new System.ComponentModel.Container ( );
      txtDisplay = new TextBox ( );
      checkBox1 = new CheckBox ( );
      contextMenuStrip1 = new ContextMenuStrip (components);
      btn1 = new Button ( );
      btn2 = new Button ( );
      btn3 = new Button ( );
      btn4 = new Button ( );
      btn5 = new Button ( );
      btn6 = new Button ( );
      btn7 = new Button ( );
      btn8 = new Button ( );
      btn9 = new Button ( );
      btn0 = new Button ( );
      btnAdd = new Button ( );
      btnSub = new Button ( );
      btnMul = new Button ( );
      btnDiv = new Button ( );
      btnEquals = new Button ( );
      btnClear = new Button ( );
      SuspendLayout ( );
      // 
      // txtDisplay
      // 
      txtDisplay.AllowDrop = true;
      txtDisplay.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      txtDisplay.Font = new Font ("Microsoft Sans Serif", 9F, FontStyle.Bold);
      txtDisplay.Location = new Point (18, 43);
      txtDisplay.Name = "txtDisplay";
      txtDisplay.ReadOnly = true;
      txtDisplay.Size = new Size (286, 21);
      txtDisplay.TabIndex = 0;
      txtDisplay.TextAlign = HorizontalAlignment.Right;
      txtDisplay.Click += displayTxt;
      // 
      // checkBox1
      // 
      checkBox1.AutoSize = true;
      checkBox1.BackColor = Color.White;
      checkBox1.Location = new Point (340, 44);
      checkBox1.Name = "checkBox1";
      checkBox1.Size = new Size (95, 19);
      checkBox1.TabIndex = 4;
      checkBox1.Text = "checkBox1";
      checkBox1.UseVisualStyleBackColor = false;
      // 
      // contextMenuStrip1
      // 
      contextMenuStrip1.BackColor = Color.FromArgb (0, 192, 0);
      contextMenuStrip1.Name = "contextMenuStrip1";
      contextMenuStrip1.Size = new Size (61, 4);
      // 
      // btn1
      // 
      btn1.Location = new Point (22, 86);
      btn1.Name = "btn1";
      btn1.Size = new Size (34, 23);
      btn1.TabIndex = 5;
      btn1.Text = "1";
      btn1.UseVisualStyleBackColor = true;
      btn1.Click += Btn1_click;
      // 
      // btn2
      // 
      btn2.Location = new Point (63, 86);
      btn2.Name = "btn2";
      btn2.Size = new Size (34, 23);
      btn2.TabIndex = 6;
      btn2.Text = "2";
      btn2.UseVisualStyleBackColor = true;
      btn2.Click += Btn2_click;
      // 
      // btn3
      // 
      btn3.Location = new Point (101, 86);
      btn3.Name = "btn3";
      btn3.Size = new Size (34, 23);
      btn3.TabIndex = 7;
      btn3.Text = "3";
      btn3.UseVisualStyleBackColor = true;
      btn3.Click += Btn3_click;
      // 
      // btn4
      // 
      btn4.Location = new Point (140, 86);
      btn4.Name = "btn4";
      btn4.Size = new Size (34, 23);
      btn4.TabIndex = 8;
      btn4.Text = "4";
      btn4.UseVisualStyleBackColor = true;
      btn4.Click += Btn4_click;
      // 
      // btn5
      // 
      btn5.Location = new Point (181, 86);
      btn5.Name = "btn5";
      btn5.Size = new Size (34, 23);
      btn5.TabIndex = 9;
      btn5.Text = "5";
      btn5.UseVisualStyleBackColor = true;
      btn5.Click += Btn5_ckick;
      // 
      // btn6
      // 
      btn6.Location = new Point (22, 137);
      btn6.Name = "btn6";
      btn6.Size = new Size (34, 23);
      btn6.TabIndex = 10;
      btn6.Text = "6";
      btn6.UseVisualStyleBackColor = true;
      btn6.Click += Btn6_click;
      // 
      // btn7
      // 
      btn7.Location = new Point (63, 137);
      btn7.Name = "btn7";
      btn7.Size = new Size (34, 23);
      btn7.TabIndex = 11;
      btn7.Text = "7";
      btn7.UseVisualStyleBackColor = true;
      btn7.Click += Btn7_click;
      // 
      // btn8
      // 
      btn8.Location = new Point (101, 137);
      btn8.Name = "btn8";
      btn8.Size = new Size (34, 23);
      btn8.TabIndex = 12;
      btn8.Text = "8";
      btn8.UseVisualStyleBackColor = true;
      btn8.Click += Btn8_click;
      // 
      // btn9
      // 
      btn9.Location = new Point (140, 137);
      btn9.Name = "btn9";
      btn9.Size = new Size (34, 23);
      btn9.TabIndex = 13;
      btn9.Text = "9";
      btn9.UseVisualStyleBackColor = true;
      btn9.Click += Btn9_click;
      // 
      // btn0
      // 
      btn0.Location = new Point (181, 137);
      btn0.Name = "btn0";
      btn0.Size = new Size (34, 23);
      btn0.TabIndex = 14;
      btn0.Text = "0";
      btn0.UseVisualStyleBackColor = true;
      btn0.Click += Btn0_Click;
      // 
      // btnAdd
      // 
      btnAdd.Location = new Point (325, 86);
      btnAdd.Name = "btnAdd";
      btnAdd.Size = new Size (30, 23);
      btnAdd.TabIndex = 15;
      btnAdd.Text = " +";
      btnAdd.UseVisualStyleBackColor = true;
      ResumeLayout (false);
      PerformLayout ( );
      // 
      // btnSub
      // 
      btnSub.Location = new Point (325, 115);
      btnSub.Name = "btnSub";
      btnSub.Size = new Size (30, 23);
      btnSub.TabIndex = 16;
      btnSub.Text = "-";
      btnSub.UseVisualStyleBackColor = true;
      btnSub.Click += btnSub_Click;
      // 
      // btnMul
      // 
      btnMul.Location = new Point (325, 144);
      btnMul.Name = "btnMul";
      btnMul.Size = new Size (30, 23);
      btnMul.TabIndex = 17;
      btnMul.Text = "*";
      btnMul.UseVisualStyleBackColor = true;
      // 
      // btnDiv
      // 
      btnDiv.Location = new Point (325, 173);
      btnDiv.Name = "btnDiv";
      btnDiv.Size = new Size (30, 23);
      btnDiv.TabIndex = 18;
      btnDiv.Text = "/";
      btnDiv.UseVisualStyleBackColor = true;
      // 
      // btnEquals
      // 
      btnEquals.Location = new Point (325, 202);
      btnEquals.Name = "btnEquals";
      btnEquals.Size = new Size (30, 23);
      btnEquals.TabIndex = 19;
      btnEquals.Text = "=";
      btnEquals.UseVisualStyleBackColor = true;
      // 
      // btnClear
      // 
      btnClear.Location = new Point (325, 231);
      btnClear.Name = "btnClear";
      btnClear.Size = new Size (30, 23);
      btnClear.TabIndex = 20;
      btnClear.Text = "C";
      btnClear.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF (8F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size (483, 295);
      Controls.Add (btnClear);
      Controls.Add (btnEquals);
      Controls.Add (btnDiv);
      Controls.Add (btnMul);
      Controls.Add (btnSub);
      Controls.Add (btnAdd);
      Controls.Add (btn0);
      Controls.Add (btn9);
      Controls.Add (btn8);
      Controls.Add (btn7);
      Controls.Add (btn6);
      Controls.Add (btn5);
      Controls.Add (btn4);
      Controls.Add (btn3);
      Controls.Add (btn2);
      Controls.Add (btn1);
      Controls.Add (checkBox1);
      Controls.Add (txtDisplay);
      Font = new Font ("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      Name = "Form1";
      Text = "Calcolatrice";
      Load += Form1_Load;
      ResumeLayout (false);
      PerformLayout ( );
    }

    #endregion

    private TextBox txtDisplay;
    private CheckBox checkBox1;
    private ContextMenuStrip contextMenuStrip1;
    private Button btn1;
    private Button btn2;
    private Button btn3;
    private Button btn4;
    private Button btn5;
    private Button btn6;
    private Button btn7;
    private Button btn8;
    private Button btn9;
    private Button btn0;
    private Button btnAdd;
    private Button btnSub;
    private Button btnMul;
    private Button btnDiv;
    private Button btnEquals;
    private Button btnClear;
  }
}
