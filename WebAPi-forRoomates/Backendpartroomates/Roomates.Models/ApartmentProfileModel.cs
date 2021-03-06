﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Roomates.Models
{
    public class ApartmentProfileModel
    {
        public string Id { get; set; }
        //    public Municipality Region { get; set;}
        public string Name { get; set; }
        public string Area { get; set; }
        public int Price { get; set; }
        public bool InternetAccess { get; set; }
        public bool TvAccess { get; set; }
        public string TvOperator { get; set; }
        public string TypeOfHEating { get; set; }
        public int Rooms { get; set; }
        public bool TwoSepratedBedRooms { get; set; }
        public bool BedroomsEquipped { get; set; }
        public bool Smoking { get; set; }
        public bool KitchenEqupped { get; set; }
        public bool BathEquipped { get; set; }
        public bool LivingRoomEqupped { get; set; }
        public string Token { get; set; }
    }
}
