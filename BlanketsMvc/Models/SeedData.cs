using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BlanketsMvc.Data;
using System;
using System.Linq;
using BlanketsMvc.Data;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Drawing;

namespace BlanketsMvc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Blankets.Any())
                {
                    return;   // DB has been seeded
                }

                context.Blankets.AddRange(
                    new Blankets
                    {
                        Type = "Throw Blanket",
                        Size = "Double",
                        Color = "Grey",
                        Pattern = "Solid",
                        Weight = "Heavy",
                        Material = "Cotton",
                        Rating = "4"
                    },
                    new Blankets
                    {
                        Type = "Quilt",
                        Size = "King",
                        Color = "Blue",
                        Pattern = "Floral",
                        Weight = "Heavy",
                        Material = "Nylon",
                        Rating = "3"
                    },
                    new Blankets
                    {
                        Type = "Electric Blanket",
                        Size = "Queen",
                        Color = "Pink",
                        Pattern = "Strip",
                        Weight = "UltraHeavy",
                        Material = "Fleece",
                        Rating = "5"
                    },
                      new Blankets
                      {
                          Type = "Baby Blanket",
                          Size = "Baby",
                          Color = "Purple",
                          Pattern = "Check",
                          Weight = "MediumHeavy",
                          Material = "Silk",
                          Rating = "2"
                      },
                       new Blankets
                       {
                           Type = "Throw Blanket",
                           Size = "Oversized",
                           Color = "Multicolor",
                           Pattern = "Animal Print",
                           Weight = "UltraThin",
                           Material = "Acrylic",
                           Rating = "4"
                       },
                        new Blankets
                        {
                            Type = "Quilt Blanket",
                            Size = "Travel",
                            Color = "Pink",
                            Pattern = "Geometric",
                            Weight = "Medium",
                            Material = "Slik",
                            Rating = "3"
                        },
                         new Blankets
                         {
                             Type = "Electric Blanket",
                             Size = "Queen",
                             Color = "Red",
                             Pattern = "Animal Print",
                             Weight = "UltraHeavy",
                             Material = "Wool",
                             Rating = "5"
                         },
                          new Blankets
                          {
                              Type = "Weighted Blanket",
                              Size = "King",
                              Color = "Pink",
                              Pattern = "Holiday",
                              Weight = "Heavy",
                              Material = "Wool",
                              Rating = "5"
                          },
                           new Blankets
                           {
                               Type = "Baby Blanket",
                               Size = "Single",
                               Color = "Yellow",
                               Pattern = "Floral",
                               Weight = "Thin",
                               Material = "Polyster",
                               Rating = "3"
                           },
                            new Blankets
                            {
                                Type = "Throw Blanket",
                                Size = "Double",
                                Color = "Blue",
                                Pattern = "Strip",
                                Weight = "UltraHeavy",
                                Material = "Fleece",
                                Rating = "2"
                            }
                );
                context.SaveChanges();
            }
        }
    }
}