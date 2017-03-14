using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryEntityFramework
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }

        IAuthorRepository Authors { get; }

        int Complete();

    }
}
