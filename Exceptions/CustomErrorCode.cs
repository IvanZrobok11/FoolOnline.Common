﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public enum CustomErrorCode : short
    {
        SessionHasNotYetStartedFailed = short.MaxValue - 1,
    }
}
