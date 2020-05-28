using System;
using System.Collections.Generic;
using System.Text;

namespace TimeObject
{
    [Flags]
    enum Regions
    {
        Kaliningrad = 2,
        Moscow = 3,
        Samara = 4,
        Yekaterinburg = 5,
        Omsk = 6,
        Krasnoyarsk = 7,
        Irkutsk = 8,
        Yakutsk = 9,
        Vladivostok = 10,
        Sakhalin = 11,
        PetropavlovskKamchatsky = 12
    }

    public interface IFunctions
    {
        void SetRegion();
    }
}
