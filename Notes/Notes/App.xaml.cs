using System;
using System.IO;
using Xamarin.Forms;

using Notes.Data;

namespace Notes
{
    public partial class App : Application
    {
    /*
        Creating a database as a singleton gives an advantage of a single database connection
        that is kept open while the app is open and running, thus avoiding the expense
        of opening and closing the database file each time a database operation is performed.
    */
        static NoteDatabase database;

        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new NotesPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
