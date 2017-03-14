using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryEntityFramework
{
    public class CourseRepository :Repository<Course>,ICourseRepository
    {
        public CourseRepository(PlutoContext context)
            :base(context)
        {

        }
        public IEnumerable<Course>GetTopSellingCourses(int count)
        {
            return PlutoContext.Courses.OrderByDescending(char => char.FullPrice).Take(count).ToList();
        }
        public IEnumerable<Course>GetCourseWithAuthors(int pageIndex, int pageSize)
        {
            return PlutoContext.Courses
                .Include(char => char.Author)
                .OrderBy(char => char.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
