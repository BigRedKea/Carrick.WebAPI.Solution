﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrick.Data.DataControllers
{
    internal interface IClientDataProvider
    {
            void Initialise();

            void Sync();

            Type GetDataType();

            void LoadLocalData();
    }
}