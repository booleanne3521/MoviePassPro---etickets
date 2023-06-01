using WebshopApp.Models;

namespace WebshopApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationContext>();
                context.Database.EnsureCreated();
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Filmstaden Sergel",
                            Logo= "https://www.folketsbio.se/wp-content/uploads/2017/04/filmstaden.png",
                            Description = "One of Stockholm's oldest cinemas, located in the heart of the city on Sergelgatan. Offers a wide variety of movies and events."
                        },
                        new Cinema()
                        {
                            Name = "Saga Bio",
                            Logo = "https://www.svenskabiografer.se/wp-content/uploads/2017/10/saga-bio-ombyggd.jpg",
                            Description = "A classic art-house cinema in Uppsala, with a focus on independent and foreign films. Recently renovated to offer modern amenities."
                        },
                        new Cinema()
                        {
                            Name = "Capitol",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/68/Capitol_Stockholm.JPG/320px-Capitol_Stockholm.JPG",
                            Description = "A historic cinema in Stockholm with a grand Art Deco facade. Known for its large screen and immersive sound system."
                        },
                        new Cinema() 
                        {
                            Name = "Zita Folkets Bio",
                            Logo = "https://www.zitafolketsbio.se/images/ZITA_logga_2016_stor.jpg",
                            Description = "A popular cinema in Stockholm's trendy Södermalm neighborhood, showing a mix of independent, international and classic films."
                        },
                        new Cinema()
                        {
                            Name = "Folkets Hus Bio",
                            Logo = "https://www.svenskabiografer.se/wp-content/uploads/2017/09/folkets-hus-bio.jpg",
                            Description = "A community cinema in Malmö, operated by the local chapter of the Swedish Social Democratic Party. Offers a range of films and events, with a focus on social issues and cultural diversity."
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Alicia Vikander",
                            Bio = "Alicia Vikander is a Swedish actress known for her roles in Ex Machina, The Danish Girl, and Tomb Raider. She has won an Academy Award, a SAG Award, and a BAFTA Award for her work.",
                            ProfilePictureURL = "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcTvDA_5oXVd_L3O1kp4z67JdkFDbkm3l4AM4RfqmzHzEaIf-oiW3hepSf3jQ7RuPufK9OHvwzGWOa6vvBA"
                        },
                        new Actor()
                        {
                            FullName = "Alexander Skarsgård",
                            Bio = "Alexander Skarsgård is a Swedish actor best known for his roles in True Blood, The Legend of Tarzan, and Big Little Lies. He has won a Primetime Emmy Award, a Golden Globe Award, and a Screen Actors Guild Award for his work.",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcT1qOrZFnK3TYQGONhZ9ZMvAMYSdkviAsIluXAFtl95yet8zUCMcI9Hz5RSGopou2UJ-tPTDKpng7e-IJg"
                        },
                        new Actor()
                        {
                            FullName = "Noomi Rapace",
                            Bio = "Noomi Rapace is a Swedish actress best known for her role in the original Swedish film adaptations of The Girl with the Dragon Tattoo trilogy. She has also appeared in international films such as Prometheus and What Happened to Monday.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1d/Noomi_Rapace_at_the_2017_San_Diego_Comic-Con_International.jpg/220px-Noomi_Rapace_at_the_2017_San_Diego_Comic-Con_International.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Stellan Skarsgård",
                            Bio = "Stellan Skarsgård is a Swedish actor known for his roles in Good Will Hunting, The Girl with the Dragon Tattoo, and the Marvel Cinematic Universe films. He has been nominated for four Guldbagge Awards and a European Film Award for his work.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Stellan_Skarsgard_2017.jpg/220px-Stellan_Skarsgard_2017.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Rebecca Ferguson",
                            Bio = "Rebecca Ferguson is a Swedish actress best known for her roles in Mission: Impossible - Rogue Nation, The Greatest Showman, and Doctor Sleep. She has been nominated for a BAFTA Award and a Screen Actors Guild Award for her work.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Rebecca_Ferguson_by_Gage_Skidmore_2.jpg/220px-Rebecca_Ferguson_by_Gage_Skidmore_2.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                                FullName = "Bertil Ohlsson",
                                Bio = "Bertil Ohlsson is a Swedish film producer who has worked on films such as My Life as a Dog, The Best Intentions, and A Pigeon Sat on a Branch Reflecting on Existence. He has won multiple awards, including a Guldbagge Award and an Academy Award.",
                                ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/Bertil_Ohlsson.jpg/220px-Bertil_Ohlsson.jpg"
                        },
                        new Producer()
                        {
                                FullName = "Malin Idevall",
                                Bio = "Malin Idevall is a Swedish film producer who has worked on films such as The Square, Border, and Aniara. She has been nominated for multiple awards, including a Guldbagge Award and an European Film Award.",
                                ProfilePictureURL = "https://pbs.twimg.com/profile_images/906974201935958016/82r0rYnv_400x400.jpg"
                        },
                        new Producer()
                        {
                                FullName = "Annika Sucksdorff",
                                Bio = "Annika Sucksdorff is a Swedish film producer who has worked on films such as Show Me Love, Under the Sun, and Everlasting Moments. She has won multiple awards, including a Guldbagge Award and a Crystal Bear at the Berlin International Film Festival.",
                                ProfilePictureURL = "https://pbs.twimg.com/profile_images/888868603756570880/3n9qWc1f_400x400.jpg"
                        },
                        new Producer()
                        {
                                FullName = "Jessica Ask",
                                Bio = "Jessica Ask is a Swedish film producer who has worked on films such as Force Majeure, The Square, and A Man Called Ove. She has been nominated for multiple awards, including a Guldbagge Award and an European Film Award.",
                                ProfilePictureURL = "https://pbs.twimg.com/profile_images/1305790248679667202/vD8-zYyG_400x400.jpg"
                        },
                        new Producer()
                        {
                                FullName = "Lena Rehnberg",
                                Bio = "Lena Rehnberg is a Swedish film producer who has worked on films such as Cries and Whispers, Scenes from a Marriage, and The Best Intentions. She has won multiple awards, including a Guldbagge Award and an Academy Award.",
                                ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7e/Lena_Rehnberg_%28cropped%29.jpg/220px-Lena_Rehnberg_%28cropped%29.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Midsommar",
                            Description = "A couple travels to Sweden to visit a rural hometown's fabled mid-summer festival. What begins as an idyllic retreat quickly devolves into an increasingly violent and bizarre competition at the hands of a pagan cult.",
                            Price = 69.99,
                            ImageURL = "https://www.assignmentx.com/wp-content/uploads/2019/06/MIDSOMMAR-movie-poster.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = Enums.MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "The Girl with the Dragon Tattoo",
                            Description = "Journalist Mikael Blomkvist is aided in his search for a woman who has been missing for forty years by Lisbeth Salander, a young computer hacker.",
                            Price = 99.99,
                            StartDate = DateTime.Now.AddDays(-15),
                            EndDate = DateTime.Now.AddDays(-10),
                            CinemaId = 1,
                            ProducerId = 2,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTczNDk4NTQ0OV5BMl5BanBnXkFtZTcwNDAxMDgxNw@@._V1_.jpg",
                            MovieCategory= Enums.MovieCategory.Thriller
                        },
                        new Movie()
                        {
                            Name = "Let the Right One In",
                            Description = "Oskar, an overlooked and bullied boy, finds love and revenge through Eli, a beautiful but peculiar girl who turns out to be a vampire.",
                            Price = 79.50,
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now,
                            CinemaId = 3,
                            ProducerId = 3,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BOWM4NTY2NTMtZDZlZS00NTgyLWEzZDMtODE3ZGI1MzI3ZmU5XkEyXkFqcGdeQXVyNzI1NzMxNzM@._V1_.jpg",
                            MovieCategory = Enums.MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "A Man Called Ove",
                            Description = "Ove, an ill-tempered, isolated retiree who spends his days enforcing block association rules and visiting his wife's grave, has finally given up on life just as an unlikely friendship develops with his boisterous new neighbors.",
                            Price = 89,
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now,
                            CinemaId = 1,
                            ProducerId = 3,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMjE0NDUyOTc2MV5BMl5BanBnXkFtZTgwODk2NzU3OTE@._V1_.jpg",
                            MovieCategory = Enums.MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Force Majeure",
                            Description = "A family on a ski holiday in the French Alps find themselves staring down an avalanche during lunch one day; in the aftermath, their dynamic has been shaken to its core, with a question mark hanging over their patriarch in particular.",
                            Price = 109.50,
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now,
                            CinemaId = 2,
                            ProducerId = 3,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMDdhN2QzNzItZWVkZC00ZWFkLTk0ZDEtNmRjMjdlYjFjZWY3XkEyXkFqcGdeQXVyMTA4NjE0NjEy._V1_.jpg",
                            MovieCategory = Enums.MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "The Hundred-Year-Old Man Who Climbed Out the Window and Disappeared",
                            Description = "After living a long and colorful life, Allan Karlsson finds himself stuck in a nursing home. On his 100th birthday, he leaps out a window and begins an unexpected journey, involving a suitcase full of cash, a dangerous criminal gang, and an elephant.",
                            Price = 99.29,
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now,
                            CinemaId = 5,
                            ProducerId = 5,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNDUyMzU5MTk5MF5BMl5BanBnXkFtZTgwNjcxNDQxNTE@._V1_.jpg",
                            MovieCategory = Enums.MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "The Square",
                            Description = "Christian, the respected curator of a contemporary art museum, struggles to put together a new installation called 'The Square'. The installation invites passersby to altruism, reminding them of their role as responsible fellow human beings. But Christian's own life is soon disrupted in unexpected ways.",
                            Price = 89,
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now,
                            CinemaId = 4,
                            ProducerId = 5,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMzc1MDY3NDIwMV5BMl5BanBnXkFtZTgwNzkwNzU0MzI@._V1_FMjpg_UX1000_.jpg",
                            MovieCategory = Enums.MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Actors_Movie.Any())
                {
                    context.Actors_Movie.AddRange(new List<Actor_Movie>()
                    { 
                        new Actor_Movie() 
                        { 
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
