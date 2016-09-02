using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PresentMonLauncher
{
    public class GameData
    {
        public string Name;
        public string Executable;
        public API Engine;

        public GameData()
        {
            this.Name = string.Empty;
            this.Executable = string.Empty;
            this.Engine = API.Unknown;
        }

        public GameData(string Name, string Executable, API Engine)
        {
            this.Name = Name;
            this.Executable = Executable;
            this.Engine = Engine;
        }

    }
}
