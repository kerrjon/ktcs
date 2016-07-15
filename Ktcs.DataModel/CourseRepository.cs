using System.Linq;
using Ktcs.Classes;
using Ktcs.Datamodel;

namespace Ktcs.DataModel
{
    public class CourseRepository
    {
    readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public Course GetCourseById(string courseNumber)
        {
      
            using (var context = new KtcsDbContext())
            {
                return context.Courses.AsNoTracking().FirstOrDefault(n => n.CourseNumber == courseNumber);
            }
        }
    }
}
