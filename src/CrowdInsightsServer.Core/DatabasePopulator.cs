using CrowdInsightsServer.Core.Entities;
using CrowdInsightsServer.Core.Interfaces;
using System.Linq;

namespace CrowdInsightsServer.Core
{
    public static class DatabasePopulator
    {
        //TODO: Add Test Data
        public static int PopulateDatabase(IRepository<LogItem> logItemRepository)
        {
            //if (todoRepository.List().Any()) return 0;

            //todoRepository.Add(new ToDoItem()
            //{
            //    Title = "Get Sample Working",
            //    Description = "Try to get the sample to build."
            //});
            //todoRepository.Add(new ToDoItem()
            //{
            //    Title = "Review Solution",
            //    Description = "Review the different projects in the solution and how they relate to one another."
            //});
            //todoRepository.Add(new ToDoItem()
            //{
            //    Title = "Run and Review Tests",
            //    Description = "Make sure all the tests run and review what they are doing."
            //});
            return logItemRepository.List().Count;
        }
    }
}
