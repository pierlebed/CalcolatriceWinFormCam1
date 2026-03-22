using System;
using System.Drawing;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CalcolatriceWinFormCam1
{
  public partial class Form1 : Form
  {
    public Form1 ( )
    {
      InitializeComponent ( );
    }

    private void displayTxt ( object sender, EventArgs e )
    {

    }

    private void Form1_Load ( object sender, EventArgs e )
    {
      txtDisplay.Text = "0";

    }

    private void Btn0_Click ( object sender, EventArgs e )
    {
      System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

      // Se il display è 0 o vuoto, sostituisco; altrimenti concateno
      if(txtDisplay.Text == "0")
        txtDisplay.Text = b.Text;
      else
        txtDisplay.Text += b.Text;
    }


    private void Btn1_click ( object sender, EventArgs e )
    {
      {
        System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

        // Se il display è 0 o vuoto, sostituisco; altrimenti concateno
        if(txtDisplay.Text == "0")
          txtDisplay.Text = b.Text;
        else
          txtDisplay.Text += b.Text;
      }
    }

    private void Btn2_click ( object sender, EventArgs e )
    {
      {
        System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

        // Se il display è 0 o vuoto, sostituisco; altrimenti concateno
        if(txtDisplay.Text == "0")
          txtDisplay.Text = b.Text;
        else
          txtDisplay.Text += b.Text;
      }
    }

    private void Btn3_click ( object sender, EventArgs e )
    {
      {
        System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

        // Se il display è 0 o vuoto, sostituisco; altrimenti concateno
        if(txtDisplay.Text == "0")
          txtDisplay.Text = b.Text;
        else
          txtDisplay.Text += b.Text;
      }
    }

    private void Btn4_click ( object sender, EventArgs e )
    {
      {
        System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

        // Se il display è 0 o vuoto, sostituisco; altrimenti concateno
        if(txtDisplay.Text == "0")
          txtDisplay.Text = b.Text;
        else
          txtDisplay.Text += b.Text;
      }
    }

    private void Btn5_ckick ( object sender, EventArgs e )
    {
      {
        System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

        // Se il display è 0 o vuoto, sostituisco; altrimenti concateno
        if(txtDisplay.Text == "0")
          txtDisplay.Text = b.Text;
        else
          txtDisplay.Text += b.Text;
      }
    }

    private void Btn6_click ( object sender, EventArgs e )
    {
      {
        System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

        // Se il display è 0 o vuoto, sostituisco; altrimenti concateno
        if(txtDisplay.Text == "0")
          txtDisplay.Text = b.Text;
        else
          txtDisplay.Text += b.Text;
      }
    }

    private void Btn7_click ( object sender, EventArgs e )
    {
      {
        System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

        // Se il display è 0 o vuoto, sostituisco; altrimenti concateno
        if(txtDisplay.Text == "0")
          txtDisplay.Text = b.Text;
        else
          txtDisplay.Text += b.Text;
      }
    }

    private void Btn8_click ( object sender, EventArgs e )
    {
      {
        System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

        // Se il display è 0 o vuoto, sostituisco; altrimenti concateno
        if(txtDisplay.Text == "0")
          txtDisplay.Text = b.Text;
        else
          txtDisplay.Text += b.Text;
      }
    }

    private void Btn9_click ( object sender, EventArgs e )
    {
      {
        System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

        // Se il display è 0 o vuoto, sostituisco; altrimenti concateno
        if(txtDisplay.Text == "0")
          txtDisplay.Text = b.Text;
        else
          txtDisplay.Text += b.Text;
      }
    }

    private void (object sender, EventArgs e) btnAdd_Click ( object sender, EventArgs e ) => (sender, e);
    

    private void btnSub_Click ( object sender, EventArgs e )
    {

    }
  }
}
