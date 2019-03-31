using System;
using System.Collections.Generic;
using System.Text;

namespace DayThree.Persistence
{
    public interface ISQLiteDb
    {
        string GetDatabasePath();
    }
}