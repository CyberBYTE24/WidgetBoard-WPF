using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseExample
{
    public struct WidgetSerializable
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public int ColumnSpan { get; set; }
        public int RowSpan { get; set; }
        public string Settings { get; set; }
        public Guid WidgetId { get; set; }
    }
}
