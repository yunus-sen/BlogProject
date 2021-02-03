using BlogProject.Data.Abstract;
using BlogProject.Data.Concrete.EntityFramework.Contexts;
using BlogProject.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogProjectContext _context;
        private readonly EfArticleRepository _articleRepository;
        private readonly EfCategoryRepository _categoryRepsoitory;
        private readonly EfCommentRepository _commentRepository;
        private readonly EfRoleRepository _roleRepository;
        private readonly EfUserRepository _userRepository;

        public UnitOfWork(BlogProjectContext context)
        {
            _context = context;
        }
        public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context);

        public ICategoryRepository Categories => _categoryRepsoitory ?? new EfCategoryRepository(_context);

        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);

        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
