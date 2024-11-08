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
        bool IsWidgetTransformPossible(Views.Widget sender, (int, int, int, int) newBound);
    }

    internal class WidgetTransformSolver : IWidgetTransformSolver
    {
        private readonly IEnumerable<Widget> widgets;

        public bool IgnoreWidgetCollision { get; set; }

        internal WidgetTransformSolver(IEnumerable<Widget> widgets)
        {
            this.widgets = widgets;
        }

        public bool IsWidgetTransformPossible(Views.Widget sender, (int, int, int, int) newBound)
        {
            if(IgnoreWidgetCollision)
                return true;
            return widgets.Where(x => x.WidgetView != sender).All(x =>
            {
                //Out of bounds
                if (
                    newBound.Item1 < 0 || newBound.Item2 < 0
                ) return false;

                //NW inner corner check
                if (
                    newBound.Item1 >= x.Bound.Item1 &&
                    newBound.Item1 < x.Bound.Item3 &&
                    newBound.Item2 >= x.Bound.Item2 &&
                    newBound.Item2 < x.Bound.Item4
                ) return false;
                
                //NE inner corner check
                if (
                    newBound.Item3 > x.Bound.Item1 &&
                    newBound.Item3 <= x.Bound.Item3 &&
                    newBound.Item2 >= x.Bound.Item2 &&
                    newBound.Item2 < x.Bound.Item4
                ) return false;

                //SE inner corner check
                if (
                    newBound.Item3 > x.Bound.Item1 &&
                    newBound.Item3 <= x.Bound.Item3 &&
                    newBound.Item4 > x.Bound.Item2 &&
                    newBound.Item4 <= x.Bound.Item4
                ) return false;
                
                //SW inner corner check
                if (
                    newBound.Item1 >= x.Bound.Item1 &&
                    newBound.Item1 < x.Bound.Item3 &&
                    newBound.Item4 > x.Bound.Item2 &&
                    newBound.Item4 <= x.Bound.Item4
                ) return false;

                //NW outer corner check
                if (
                    x.Bound.Item1 >= newBound.Item1 &&
                    x.Bound.Item1 < newBound.Item3 &&
                    x.Bound.Item2 >= newBound.Item2 &&
                    x.Bound.Item2 < newBound.Item4
                ) return false;

                //NE outer corner check
                if (
                    x.Bound.Item3 > newBound.Item1 &&
                    x.Bound.Item3 <= newBound.Item3 &&
                    x.Bound.Item2 >= newBound.Item2 &&
                    x.Bound.Item2 < newBound.Item4
                ) return false;

                //SE outer corner check
                if (
                    x.Bound.Item3 > newBound.Item1 &&
                    x.Bound.Item3 <= newBound.Item3 &&
                    x.Bound.Item4 > newBound.Item2 &&
                    x.Bound.Item4 <= newBound.Item4
                ) return false;

                //SW outer corner check
                if (
                    x.Bound.Item1 >= newBound.Item1 &&
                    x.Bound.Item1 < newBound.Item3 &&
                    x.Bound.Item4 > newBound.Item2 &&
                    x.Bound.Item4 <= newBound.Item4
                ) return false;


                return true;
            });
        }
    }
}
