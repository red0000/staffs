﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staffs.Models
{
    public class TodoItem
    {
            public long Id { get; set; }
            public string first_name { get; set; }
            public string middle_name { get; set; }
            public string last_name { get; set; }
            public DateTime birth_date { get; set; }
            public DateTime bdate { get; set; }
            public DateTime edate { get; set; }
            public bool is_active { get; set; }
            public DateTime create_date { get; set; }
    }
}
