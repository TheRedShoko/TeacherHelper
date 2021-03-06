﻿using System;
using System.Collections.Generic;

namespace TeacherHelper.Models.Models
{
    public partial class TestsQuestions
    {
        public int TestId { get; set; }
        public int QuestionId { get; set; }
        public int? QuestionPlace { get; set; }

        public virtual Questions Question { get; set; }
        public virtual Tests Test { get; set; }
    }
}
