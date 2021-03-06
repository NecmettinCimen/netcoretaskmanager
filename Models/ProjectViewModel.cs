﻿using System.Collections.Generic;

namespace TaskManager.Models
{
    public class ProjectViewModel
    {
        public Project Project { get; set; }
        public List<WorkDto> WorkList { get; set; }
        public List<Event> EventList { get; set; }
        public List<Label> LabelList { get; set; }
    }
}