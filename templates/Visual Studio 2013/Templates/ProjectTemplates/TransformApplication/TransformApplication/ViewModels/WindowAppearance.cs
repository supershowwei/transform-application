using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace $safeprojectname$.ViewModels
{
    class WindowAppearance
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public static WindowAppearance Parse(string serialized)
        {
            return string.IsNullOrEmpty(serialized) ? null : JsonConvert.DeserializeObject<WindowAppearance>(serialized);
        }
    }
}
