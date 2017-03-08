using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookScaleApp.View
{
    public interface IBooksView : IView
    {
        string ChosenBook { get; }
    }
}
