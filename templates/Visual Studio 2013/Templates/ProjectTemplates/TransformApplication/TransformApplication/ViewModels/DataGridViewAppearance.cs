using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace $safeprojectname$.ViewModels
{
    class DataGridViewAppearance
    {
        public int MaxRows { get; set; }

        public List<DataGridColumnAppearance> ColumnAppearances { get; set; }

        public static DataGridViewAppearance Parse(string serialized)
        {
            return string.IsNullOrEmpty(serialized) ? null : JsonConvert.DeserializeObject<DataGridViewAppearance>(serialized);
        }
    }

    class DataGridColumnAppearance
    {
        public DataGridColumnAppearance(string name, int width)
        {
            this.Name = name;
            this.Width = width;
        }

        public string Name { get; set; }

        public int Width { get; set; }
    }
}
