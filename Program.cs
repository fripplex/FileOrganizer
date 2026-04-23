namespace FileOrganizer;

static class Program
{
    [STAThread]
    static void Main()
    {
        try
        {
            ApplicationConfiguration.Initialize();
            var login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
        catch (Exception ex)
        {
            File.WriteAllText("crash.log", ex.ToString());
            MessageBox.Show(ex.ToString(), "Error");
        }
    }
}