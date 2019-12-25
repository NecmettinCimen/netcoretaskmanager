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

    public class WorkDto : Work
    {
        public string EventName { get; set; }
        public string FirstLabelName { get; set; }
        public List<int> Labels { get; set; }
        public int WorkProgres { get; set; }
    }
}
