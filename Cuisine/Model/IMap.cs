
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Element;

namespace Model{
    public interface IMap {

        void setMobileHasChanged();

        Element getOnTheMapXY();

    }
}