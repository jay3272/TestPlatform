﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlatform.Views
{
    public interface IMainView
    {
        event EventHandler ShowPetView;
        event EventHandler ShowAdtranView;
        event EventHandler ShowOwnerView;
        event EventHandler ShowVetsView;

    }
}
