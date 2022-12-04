﻿using AhmedovTravel.Core.Contracts;
using AhmedovTravel.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace AhmedovTravel.Controllers
{
    public class RoomServiceController : Controller
    {
        private readonly IRoomServiceService roomService;

        public RoomServiceController(IRoomServiceService _roomService)
        {
            roomService = _roomService;
        }

        //public async Task<IActionResult> All()
        //{
        //    var model = await transportService.GetAllAsync();

        //    return View("All", model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> AddToCollection(int transportId)
        //{
        //    try
        //    {
        //        var userId = User.Id();
        //        await transportService.AddTransportToCollectionAsync(transportId, userId);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    return RedirectToAction(nameof(All));
        //}

        //[HttpGet]
        //public async Task<IActionResult> ShowTransportCollection()
        //{
        //    var userId = User.Id();
        //    var model = await transportService.ShowTransportCollectionAsync(userId);

        //    return View("Mine", model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> RemoveFromCollection(int transportId)
        //{
        //    var userId = User.Id();

        //    await transportService.RemoveTransportFromCollectionAsync(transportId, userId);

        //    return RedirectToAction(nameof(ShowTransportCollection));
        //}
    }
}
