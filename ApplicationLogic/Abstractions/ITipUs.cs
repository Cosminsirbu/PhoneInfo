﻿using PhoneInfo.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneInfo.ApplicationLogic.Abstractions
{
    public interface ITipUs: IRepository<TipUs>
    {
        void AddTipUs(TipUs tipUs);

    }
}
