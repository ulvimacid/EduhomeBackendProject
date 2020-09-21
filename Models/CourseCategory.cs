﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationBackendFinal.Models
{
    public class CourseCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
