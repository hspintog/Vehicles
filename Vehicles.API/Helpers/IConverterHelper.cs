﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Data.Entities;
using Vehicles.API.Models;

namespace Vehicles.API.Helpers
{
    public interface IConverterHelper
    {
        Task<User> ToUserAsync(UserViewModel model, Guid imageId, bool isNew);

        UserViewModel ToUserViewModel(User user);

        VehicleViewModel ToVehicleViewModel(Vehicle vehicle);
        Task<Vehicle> ToVehicleAsync(VehicleViewModel model, bool isNew);

        Task<Detail> ToDetailAsync(DetailViewModel model, bool isNew);

        DetailViewModel ToDetailViewModel(Detail detail);
    }
}