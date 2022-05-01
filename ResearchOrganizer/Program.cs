namespace ResearchOrganizer
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {



/*         string Title = "";
         string Abstract = "";
         string URI = "";
         string Notes = "";
         string Bib_Text = "";*/

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}