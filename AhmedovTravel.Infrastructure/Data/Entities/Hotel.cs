﻿using AhmedovTravel.Infrastructure.DataConstants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AhmedovTravel.Infrastructure.Data.Entities
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(HotelConstants.HotelNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [MaxLength(HotelConstants.HotelDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Precision(18, 2)]
        public decimal HotelRating { get; set; }

        [Required]
        public int? RoomId { get; set; }

        [Required]
        [ForeignKey(nameof(RoomId))]
        public Room? Room { get; set; }

        public ICollection<Room> Rooms { get; set; } = new List<Room>();

        public ICollection<Town> TownHotels { get; set; } = new List<Town>();

        [Required]
        public bool IsActive { get; set; }
    }
}
