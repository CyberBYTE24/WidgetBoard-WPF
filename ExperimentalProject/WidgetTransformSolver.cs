using ExperimentalProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalProject
{
    internal interface IWidgetTransformSolver
    {
        bool IgnoreWidgetCollision { get; set; }
        bool IsWidgetTransformPossible(Views.Widget sender, (int x1, int y1, int x2, int y2) newBound);
    }

    internal class WidgetTransformSolver : IWidgetTransformSolver
    {
        private readonly IEnumerable<Widget> widgets;

        public bool IgnoreWidgetCollision { get; set; }

        internal WidgetTransformSolver(IEnumerable<Widget> widgets)
        {
            this.widgets = widgets;
        }

        public bool IsWidgetTransformPossible(Views.Widget sender, (int x1, int y1, int x2, int y2) newBound)
        {
            if(IgnoreWidgetCollision)
                return true;

            if (
                newBound.Item1 < 0 || newBound.Item2 < 0
            ) return false;

            return widgets.Where(x => x.WidgetView != sender).All(x =>
            {
                return newBound.y1 >= x.Bound.y2 || x.Bound.y1 >= newBound.y2 || newBound.x1 >= x.Bound.x2 || x.Bound.x1 >= newBound.x2;
            });
        }
    }
}