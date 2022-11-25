﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet.Interfaces
{
    public interface IIMC
    {
        double Calc(double Height, double Weigth);
        string GetIMCCategory(double IMC);
        bool IsValid(double Height, double Weigth);    

    }
}
