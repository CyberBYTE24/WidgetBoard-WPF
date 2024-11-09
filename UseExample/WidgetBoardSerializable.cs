using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseExample
{
    public struct WidgetBoardSerializable
    {
        public bool IgnoreWidgetCollision;
        public bool AutomaticCellSize;
        public int ColumnCount;
        public int RowCount;
        public double CellWidth;
        public double CellHeight;
        public string BackgroundImagePath;
        public List<WidgetSerializable> WidgetsOnBoard;
    }
}
