using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryEntityFramework
{
    class ICourseRepository
    {
        public interface ICourseRepository : IRepository<Course>
        {
        IEnumerable<Course> GetTopSellingCourses(int count);

        IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize);
        

        }
    }
}
