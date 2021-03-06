﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FPT_Training_System.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int TraineeId { get; set; }
        public Trainee trainee { get; set; }
        public int CourseCategoryId { get; set; }
        public CourseCategory CourseCategory { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}