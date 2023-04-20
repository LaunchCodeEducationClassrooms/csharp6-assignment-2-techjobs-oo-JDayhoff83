using System;
namespace TechJobsOOAutoGraded6
{
	public class CoreCompetency : JobField
	{

        // TODO: Task 2: Change the fields to auto-implemented properties.
        public CoreCompetency(string value) : base(value)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

    }
}

