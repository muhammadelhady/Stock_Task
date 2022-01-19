﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entites
{
    public class Audit
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDelted { get; set; }
    }
}
