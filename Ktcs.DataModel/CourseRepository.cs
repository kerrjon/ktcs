using System.Linq;
using Ktcs.Classes;
using Ktcs.Datamodel;

namespace Ktcs.DataModel
{
    public class CourseRepository
    {
        public Course GetCourseById(string courseNumber)
        {
            using (var context = new KtcsDbContext())
            {
                return context.Courses.AsNoTracking().FirstOrDefault(n => n.courseNumber == courseNumber);
            }
        }
    }
}
