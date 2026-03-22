namespace CalcolatriceWinFormCam1
{
  using global::CalcolatriceWinForms;

  using System;
  using System.Windows.Forms;

  namespace CalcolatriceWinForms
  {
    internal static class Program
    {
      [STAThread]
      static void Main ( )
      {
        ApplicationConfiguration.Initialize ( );
        Application.Run (new Form1 ( ));
      }
    }
  }
}

