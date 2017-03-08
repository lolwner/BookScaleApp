using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BookScaleApp.Model;

namespace BookScaleApp.View
{
    public interface IAuthorsView : IView
    {
        string ChosenAuthor { get; }

    }
}
