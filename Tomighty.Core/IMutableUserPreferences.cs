﻿//
//  Tomighty - http://www.tomighty.org
//
//  This software is licensed under the Apache License Version 2.0:
//  http://www.apache.org/licenses/LICENSE-2.0.txt
//

namespace Tomighty
{
    public interface IMutableUserPreferences : IUserPreferences
    {
        void SetIntervalDuration(IntervalType intervalType, Duration duration);
        new bool ShowToastNotifications { get; set; }
        new bool PlaySoundNotifications { get; set; }
        new int MaxPomodoroCount { get; set; }
        new bool AutoUpdate { get; set; }
    }
}
