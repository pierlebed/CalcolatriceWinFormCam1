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
      contextMenuStrip1 = new ContextMenuStrip (components);
      salvaParzialeToolStripMenuItem1 = new ToolStripMenuItem ( );
      contextMenuStrip1.SuspendLayout ( );
      SuspendLayout ( );
      // 
      // txtDisplay
      // 
      txtDisplay.Font = new Font ("Microsoft Sans Serif", 14F, FontStyle.Bold);
      txtDisplay.Location = new Point (18, 15);
      txtDisplay.Name = "txtDisplay";
      txtDisplay.ReadOnly = true;
      txtDisplay.Size = new Size (220, 29);
      txtDisplay.TabIndex = 0;
      txtDisplay.TextAlign = HorizontalAlignment.Right;
      // 
      // btn1
      // 
      btn1.Location = new Point (18, 60);
      btn1.Name = "btn1";
      btn1.Size = new Size (40, 40);
      btn1.TabIndex = 1;
      btn1.Text = "1";
      btn1.UseVisualStyleBackColor = true;
      btn1.Click += BtnNumero_Click;
      // 
      // btn2
      // 
      btn2.Location = new Point (64, 60);
      btn2.Name = "btn2";
      btn2.Size = new Size (40, 40);
      btn2.TabIndex = 2;
      btn2.Text = "2";
      btn2.UseVisualStyleBackColor = true;
      btn2.Click += BtnNumero_Click;
      // 
      // btn3
      // 
      btn3.Location = new Point (110, 60);
      btn3.Name = "btn3";
      btn3.Size = new Size (40, 40);
      btn3.TabIndex = 3;
      btn3.Text = "3";
      btn3.UseVisualStyleBackColor = true;
      btn3.Click += BtnNumero_Click;
      // 
      // btn4
      // 
      btn4.Location = new Point (18, 106);
      btn4.Name = "btn4";
      btn4.Size = new Size (40, 40);
      btn4.TabIndex = 4;
      btn4.Text = "4";
      btn4.UseVisualStyleBackColor = true;
      btn4.Click += BtnNumero_Click;
      // 
      // btn5
      // 
      btn5.Location = new Point (64, 106);
      btn5.Name = "btn5";
      btn5.Size = new Size (40, 40);
      btn5.TabIndex = 5;
      btn5.Text = "5";
      btn5.UseVisualStyleBackColor = true;
      btn5.Click += BtnNumero_Click;
      // 
      // btn6
      // 
      btn6.Location = new Point (110, 106);
      btn6.Name = "btn6";
      btn6.Size = new Size (40, 40);
      btn6.TabIndex = 6;
      btn6.Text = "6";
      btn6.UseVisualStyleBackColor = true;
      btn6.Click += BtnNumero_Click;
      // 
      // btn7
      // 
      btn7.Location = new Point (18, 152);
      btn7.Name = "btn7";
      btn7.Size = new Size (40, 40);
      btn7.TabIndex = 7;
      btn7.Text = "7";
      btn7.UseVisualStyleBackColor = true;
      btn7.Click += BtnNumero_Click;
      // 
      // btn8
      // 
      btn8.Location = new Point (64, 152);
      btn8.Name = "btn8";
      btn8.Size = new Size (40, 40);
      btn8.TabIndex = 8;
      btn8.Text = "8";
      btn8.UseVisualStyleBackColor = true;
      btn8.Click += BtnNumero_Click;
      // 
      // btn9
      // 
      btn9.Location = new Point (110, 152);
      btn9.Name = "btn9";
      btn9.Size = new Size (40, 40);
      btn9.TabIndex = 9;
      btn9.Text = "9";
      btn9.UseVisualStyleBackColor = true;
      btn9.Click += BtnNumero_Click;
      // 
      // btn0
      // 
      btn0.Location = new Point (64, 198);
      btn0.Name = "btn0";
      btn0.Size = new Size (40, 40);
      btn0.TabIndex = 10;
      btn0.Text = "0";
      btn0.UseVisualStyleBackColor = true;
      btn0.Click += BtnNumero_Click;
      // 
      // btnAdd
      // 
      btnAdd.Location = new Point (170, 60);
      btnAdd.Name = "btnAdd";
      btnAdd.Size = new Size (40, 40);
      btnAdd.TabIndex = 11;
      btnAdd.Text = "+";
      btnAdd.UseVisualStyleBackColor = true;
      btnAdd.Click += btnAdd_Click;
      // 
      // btnSub
      // 
      btnSub.Location = new Point (170, 106);
      btnSub.Name = "btnSub";
      btnSub.Size = new Size (40, 40);
      btnSub.TabIndex = 12;
      btnSub.Text = "-";
      btnSub.UseVisualStyleBackColor = true;
      btnSub.Click += btnSub_Click;
      // 
      // btnMul
      // 
      btnMul.Location = new Point (170, 152);
      btnMul.Name = "btnMul";
      btnMul.Size = new Size (40, 40);
      btnMul.TabIndex = 13;
      btnMul.Text = "*";
      btnMul.UseVisualStyleBackColor = true;
      btnMul.Click += btnMul_Click;
      // 
      // btnDiv
      // 
      btnDiv.Location = new Point (170, 198);
      btnDiv.Name = "btnDiv";
      btnDiv.Size = new Size (40, 40);
      btnDiv.TabIndex = 14;
      btnDiv.Text = "/";
      btnDiv.UseVisualStyleBackColor = true;
      btnDiv.Click += btnDiv_Click;
      // 
      // btnEquals
      // 
      btnEquals.AllowDrop = true;
      btnEquals.Location = new Point (18, 198);
      btnEquals.Name = "btnEquals";
      btnEquals.Size = new Size (40, 40);
      btnEquals.TabIndex = 15;
      btnEquals.Text = "=";
      btnEquals.UseVisualStyleBackColor = true;
      btnEquals.Click += btnEquals_Click;
      // 
      // btnClear
      // 
      btnClear.Location = new Point (110, 198);
      btnClear.Name = "btnClear";
      btnClear.Size = new Size (40, 40);
      btnClear.TabIndex = 16;
      btnClear.Text = "C";
      btnClear.UseVisualStyleBackColor = true;
      btnClear.Click += btnClear_Click;
      // 
      // contextMenuStrip1
      // 
      contextMenuStrip1.Items.AddRange (new ToolStripItem[] { salvaParzialeToolStripMenuItem1 });
      contextMenuStrip1.Name = "contextMenuStrip1";
      contextMenuStrip1.ShowCheckMargin = true;
      contextMenuStrip1.Size = new Size (203, 48);
      // 
      // salvaParzialeToolStripMenuItem1
      // 
      salvaParzialeToolStripMenuItem1.Name = "salvaParzialeToolStripMenuItem1";
      salvaParzialeToolStripMenuItem1.Size = new Size (202, 22);
      salvaParzialeToolStripMenuItem1.Text = "Salva parziale";
      salvaParzialeToolStripMenuItem1.Click += salvaParzialeToolStripMenuItem1_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF (8F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size (344, 341);
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
      Controls.Add (txtDisplay);
      Font = new Font ("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      Name = "Form1";
      Text = "Calcolatrice";
      Load += Form1_Load;
      contextMenuStrip1.ResumeLayout (false);
      ResumeLayout (false);
      PerformLayout ( );
    }

    #endregion

    private TextBox txtDisplay;
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

    private void btnSub_Click ( object sender, EventArgs e )
    {
      // Implementare qui la logica per il pulsante "-" oppure
      // richiamare il metodo che già gestisce le operazioni
      btnSub.Enabled = true;
      System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

      if(double.TryParse (txtDisplay.Text, out double v))
      {
        valore1 = v;
        operatore = b.Text;
        nuovoNumero = true; // il prossimo numero sostituirà il display
      }
    }

    private void btnMul_Click ( object sender, EventArgs e )
    {
      // Implementazione minimale: gestore vuoto che risolve l'errore di compilazione.
      btnMul.Enabled = true;
      System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

      if(double.TryParse (txtDisplay.Text, out double v))
      {
        valore1 = v;
        operatore = b.Text;
        nuovoNumero = true; // il prossimo numero sostituirà il display
      }
    }

    private void btnDiv_Click ( object sender, EventArgs e )
    {
      // Gestore minimo per risolvere l'errore di compilazione.
      btnDiv.Enabled = true;
      System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

      if(double.TryParse (txtDisplay.Text, out double v))
      {
        valore1 = v;
        operatore = b.Text;
        nuovoNumero = true; // il prossimo numero sostituirà il display
      }
    }

    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem salvaParzialeToolStripMenuItem1;
  }
}

