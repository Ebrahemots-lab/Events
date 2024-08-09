using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.AssignmentEmployee
{
    public class BoardMember : Employee
    {
        public BoardMember(int id, DateTime birthDate, int vacation) : base(id, birthDate, vacation)
        {
        }

        public void Resign()
        {
            throw new NotImplementedException();
        }
    }
}
