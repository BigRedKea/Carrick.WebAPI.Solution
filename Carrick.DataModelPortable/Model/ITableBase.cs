﻿using System;

namespace Carrick.Data.Model
{
    internal interface ITableBase
        {
        int Id { get; set; }

        Guid? RowGUID { get; set; }

        bool IsDeleted { get; set; }

        DateTime? RowLastUpdated { get; set; }

        DateTime? RowCreated { get; set; }

    }
}

