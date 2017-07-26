﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.Dto
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public int StayId { get; set; }
        public int DoctorId { get; set; }
        public int TestId { get; set; }
        public DateTime Date { get; set; }
    }
}