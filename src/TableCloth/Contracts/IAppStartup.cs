﻿using System;
using System.Collections.Generic;

namespace TableCloth.Contracts
{
    public interface IAppStartup
    {
        IEnumerable<string> Arguments { get; set; }

        bool HasRequirementsMet(List<string> warnings, out Exception failedResaon, out bool isCritical);

        bool Initialize(out Exception failedReason, out bool isCritical);
    }
}
