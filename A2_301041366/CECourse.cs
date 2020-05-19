using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_301041366
{
    [Serializable]
    public class CECourse : Course
    {
        private int breakEvenEnrolement;
        public CECourse() { }
        public CECourse(CourseSubject subject, int number, string title, int breakeven) : base(subject, number, title)
        {
            BreakEvenEnrolement = breakeven;
        }

        public int BreakEvenEnrolement
        {
            get { return breakEvenEnrolement; }
            set { breakEvenEnrolement = value; }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" Brake Even: {BreakEvenEnrolement}";
        }
    }
}
