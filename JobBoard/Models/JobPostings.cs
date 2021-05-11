using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
    public class JobPostings
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContactInfo { get; set; }

        private static List<JobPostings> _jobOpenings = new List<JobPostings> {};

        public JobPostings (string title, string description, string contactInfo )

        {
            Title = title;
            Description = description;
            ContactInfo = contactInfo;

            _jobOpenings.Add(this);
        }

        public static List<JobPostings> GetAll()
        {
            return _jobOpenings;
        }
    }
}
