﻿using AhmedovTravel.Core.Models.RoomService;
using AhmedovTravel.Core.Models.Transport;

namespace AhmedovTravel.Core.Contracts
{
    public interface IRoomServiceService
    {
        Task<IEnumerable<RoomServiceViewModel>> GetAllAsync();
        Task AddRoomServiceToCollectionAsync(int roomServiceId, string userId);
        Task<IEnumerable<RoomServiceViewModel>> ShowRoomServicetCollectionAsync(string userId);
        Task RemoveRoomServiceFromCollectionAsync(int roomServiceId, string userId);
    }
}
