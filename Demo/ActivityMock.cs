﻿using System.Collections.Generic;

namespace Demo
{
    public static class ActivityMock
    {
        public static readonly List<ActivityDetailes> Detailes = new List<ActivityDetailes>
        {
            new ActivityDetailes() {Id = "1",Name = "Running",CaloriesPerHourse = 600 },
            new ActivityDetailes() {Id = "2",Name="Walking",CaloriesPerHourse =300 },
            new ActivityDetailes() { Id ="3",Name="Swimming",CaloriesPerHourse =500 }
        };
    }
}
