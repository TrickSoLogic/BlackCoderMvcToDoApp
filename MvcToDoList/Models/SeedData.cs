using Microsoft.EntityFrameworkCore;
using BlackCoderMvcToDoApp.Data;

namespace BlackCoderMvcToDoApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BlackCoderMvcToDoAppContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<BlackCoderMvcToDoAppContext>>()))
            {
                // Look for an To-Do tasks
                if (context.ToDoList.Any())
                {
                    return; // DB has been seeded
                }



                context.ToDoList.AddRange(

                  //  below are some dummy lists i have created for testing purpose

                    new ToDoList
                    {
                        Task = "Do some more DSA challenges",
                        Description = "Use resources like HackerRank or Leetcode",
                        Status = "Planned",
                        Priority = "High",
                        Assgignee = "Example",
                        Comments = "",
                        Created = DateTime.Now.AddDays(3),
                        CompleteBy = DateTime.Now.AddDays(5)
                    },

                    new ToDoList
                    {
                        Task = "Look at Linux/Ubuntu",
                        Description = "",
                        Status = "Planned",
                        Priority = "High",
                        Assgignee = "Example",
                        Comments = "",
                        Created = DateTime.Now.AddDays(3),
                        CompleteBy = DateTime.Now.AddDays(5)
                    },

                    new ToDoList
                    {
                        Task = "Look at Linux/Ubuntu",
                        Description = "",
                        Status = "Planned",
                        Priority = "High",
                        Assgignee = "Example",
                        Comments = "",
                        Created = DateTime.Now.AddDays(3),
                        CompleteBy = DateTime.Now.AddDays(5)
                    }
                    ); ;
                context.SaveChanges();
            }
        }
    }
}
