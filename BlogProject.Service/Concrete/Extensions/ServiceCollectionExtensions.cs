using BlogProject.Data.Abstract;
using BlogProject.Data.Concrete;
using BlogProject.Data.Concrete.EntityFramework.Contexts;
using BlogProject.Service.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Service.Concrete.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<BlogProjectContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            return serviceCollection;
        }
    }
}
