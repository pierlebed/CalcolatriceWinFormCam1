using System;
using System.IO;
using System.Windows.Forms;

namespace CalcolatriceWinFormCam1
{
  public partial class Form1 : Form
  {
    double valore1 = 0;
    string operatore = "";
    bool nuovoNumero = false;

    public Form1 ( )
    {
      InitializeComponent ( );
      txtDisplay.Text = "0";


    }

    private void Form1_Load ( object sender, EventArgs e )
    {
      txtDisplay.Text = "0";
      txtDisplay.ContextMenuStrip = contextMenuStrip1;
      //contextMenuStrip1.Text_ = "Salva Parziale";
      //toolStripMenuItem1.Click += menuSalvaParziale_Click;

    }

    // ------------------------------
    //  NUMERI (0–9)
    // ------------------------------
    private void BtnNumero_Click ( object sender, EventArgs e )
    {
      Button b = (Button)sender;

      // Se devo iniziare un nuovo numero
      if(txtDisplay.Text == "0" || nuovoNumero)
      {
        txtDisplay.Text = b.Text;
        nuovoNumero = false;
      }
      else
      {
        txtDisplay.Text += b.Text;
      }
    }

    // ------------------------------
    //  OPERATORI (+ - * /)
    // ------------------------------
    private void BtnOperatore_Click ( object sender, EventArgs e )
    {
      Button b = (Button)sender;

      if(double.TryParse (txtDisplay.Text, out double v))
      {
        valore1 = v;
        operatore = b.Text;
        nuovoNumero = true;
      }
    }

    // ------------------------------
    //  UGUALE (=)
    // ------------------------------
    private void btnEquals_Click ( object sender, EventArgs e )
    {
      if(!double.TryParse (txtDisplay.Text, out double valore2))
        return;

      double risultato = 0;

      switch(operatore)
      {
        case "+":
          risultato = valore1 + valore2;
          break;
        case "-":
          risultato = valore1 - valore2;
          break;
        case "*":
          risultato = valore1 * valore2;
          break;
        case "/":
          if(valore2 == 0)
          {
            MessageBox.Show ("Divisione per zero non consentita");
            return;
          }
          risultato = valore1 / valore2;
          break;
        default:
          return;
      }

      txtDisplay.Text = risultato.ToString ( );
      nuovoNumero = true;
    }

    // ------------------------------
    //  CLEAR (C)
    // ------------------------------
    private void btnClear_Click ( object sender, EventArgs e )
    {
      txtDisplay.Text = "0";
      valore1 = 0;
      operatore = "";
      nuovoNumero = false;
    }

    // ------------------------------
    //  OPERATORI SPECIFICI (reindirizzati)
    // ------------------------------
    private void btnAdd_Click ( object sender, EventArgs e )
    {
      BtnOperatore_Click (sender, e);
    }

    private void btndiv_Click ( object sender, EventArgs e )
    {
      BtnOperatore_Click (sender, e);
    }

    // ------------------------------
    //  MENU: Salva Parziale (ancora da implementare)
    // ------------------------------
    private void menuSalvaParziale_Click ( object? sender, EventArgs e )
    {
      try
      {
        string valore = txtDisplay.Text;
        string percorso = "salvataggio.txt";

        // Aggiunge il valore al file, creando il file se non esiste
        System.IO.File.AppendAllText (percorso, valore + Environment.NewLine);

        MessageBox.Show ("Valore salvato correttamente!", "Salvataggio",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch(Exception ex)

      {
        MessageBox.Show ("Errore durante il salvataggio:\n" + ex.Message,
            "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void salvaParzialeToolStripMenuItem1_Click ( object sender, EventArgs e )
    {
      menuSalvaParziale_Click (sender, e);
    }
    private void toolStripMenuItem1_Click ( object sender, EventArgs e )
    {
      menuSalvaParziale_Click (sender, e);
      {
        string valore = txtDisplay.Text;
        string percorso = "salvataggio.txt";

        System.IO.File.AppendAllText (percorso, valore + Environment.NewLine);

        MessageBox.Show ("Valore salvato correttamente!", "Salvataggio",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }
  }
}






