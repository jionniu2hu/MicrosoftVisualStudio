﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        //导航属性
        public virtual List<Student> Student { get; set; }
    }
}
