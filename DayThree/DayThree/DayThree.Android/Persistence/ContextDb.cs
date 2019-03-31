using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DayThree.Persistence;

namespace DayThree.Droid.Persistence
{
    public class ContextDb : ISQLiteDb
    {
        public string GetDatabasePath()
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "MyData.db");
        }
    }
}