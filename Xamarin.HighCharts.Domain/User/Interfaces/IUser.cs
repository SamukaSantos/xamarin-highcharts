﻿using System;

namespace Xamarin.HighCharts.Domain.Interfaces
{
    public interface IUser : IDomain
    {
        string Name { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        bool Transaction { get; set; }
    }
}
