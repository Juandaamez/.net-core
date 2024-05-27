using usta_videos.Data.Enum;
using usta_videos.Models;

namespace usta_videos.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //Cinema

                if (!context.Cinema.Any())
                {
                    context.Cinema.AddRange(new List<Cinema>()
                    {
                    new Cinema()

                    {
                        Name="Netflix",
                        Logo="https://localhost:7153/images/Cinema/netflix.png",
                        Desciption="es una empresa de entretenimiento y una plataforma de streaming estadounidense. Ubicada en Los Gatos, la compañía fue fundada el 29 de agosto de 1997 y un año después comenzó su actividad"

                    },
                    new Cinema()
                    {
                        Name="Caracol tv",
                        Logo="https://localhost:7153/images/Cinema/caracoltv.png",
                        Desciption="es un canal de televisión abierta colombiano, propiedad de Valorem.​Caracol Televisión es miembro de la Alianza Informativa Latinoamericana"

                    }
                    });

                    context.SaveChanges();
                }

                if (!context.Actor.Any())
                {
                    context.Actor.AddRange(new List<Actor>()
                    {
                    new Actor()

                    {
                        ProfilePictureURL="https://localhost:7153/images/Actor/jesse.jpg",
                        Fullname="Aaron Paul",
                        Bio="es un actor estadounidense. Paul es conocido por haber interpretado al personaje de Jesse Pinkman en la serie de AMC Breaking Bad."

                    },
                    new Actor()
                    {
                       ProfilePictureURL="https://localhost:7153/images/Actor/paseo.jpg",
                        Fullname="John Leguizamo",
                        Bio="es un actor, comediante y productor de cine colomboestadounidense. Ha aparecido en más de 100 películas"

                     }
                    });

                    context.SaveChanges();
                }

                if (!context.Director.Any())
                {
                    context.Director.AddRange(new List<Director>()
                    {
                    new Director()

                    {
                        ProfilePictureURL="https://localhost:7153/images/Director/dr.jpeg",
                        Fullname="Vince Gilligan",
                        Bio="Es el creador de la aclamada serie televisiva Breaking Bad y su spin-off Better Call Saul."

                    },
                    new Director()
                    {
                       ProfilePictureURL="https://localhost:7153/images/Director/dr1.jpg",
                        Fullname="Dago García",
                        Bio="es un libretista, productor, cineasta y comunicador social colombiano. Actualmente, es el vicepresidente de producción de Caracol Televisión."

                     }
                    });

                    context.SaveChanges();
                }

                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(new List<Movie>()
                    {
                    new Movie()

                    {
                        Name="El camino",
                        Description="Tras un dramático escape de su cautiverio, Jesse Pinkman debe lidiar con su pasado para pensar en un futuro.",
                        Price=19.1,
                        ImageURL="https://localhost:7153/images/Movie/camino.jpg",
                        StartDate= DateTime.Now.AddDays(-15),
                        EndDate= DateTime.Now.AddDays(15),
                        CinemaId=1,
                        DirectorId=1,
                        MovieCategory= MovieCategory.Drama



                    },
                    new Movie()
                    {

                         Name="El paseo 2",
                        Description="La historia de un pintor de brocha gorda que se enamora de una de las pacientes del manicomio en el que está trabajando.",
                        Price=9.92,
                        ImageURL="https://localhost:7153/images/Movie/loguito1.jpeg",
                        StartDate= DateTime.Now.AddDays(-15),
                        EndDate= DateTime.Now.AddDays(15),
                        CinemaId=2,
                        DirectorId=2,
                        MovieCategory= MovieCategory.Comedy



                     }
                    });

                    context.SaveChanges();
                }

                //actor-movie
                if (!context.Actor_Movie.Any())
                {
                    context.Actor_Movie.AddRange(new List<Actor_Movie>()
                    {
                    new Actor_Movie()

                    {
                        
                        ActorId=1,
                        MovieId=1,

                    },

                    new Actor_Movie()

                    {

                        ActorId=2,
                        MovieId=2,

                    },
                    

                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
