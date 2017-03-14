using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryEntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            Authors = new AuthorRepository(_context);
        }
        public ICourseRepository Courses { get; private set; }
        public IAuthorRepository Courses { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
