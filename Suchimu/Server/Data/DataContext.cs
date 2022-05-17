using Microsoft.EntityFrameworkCore;
using Suchimu.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suchimu.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<UserAccount> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Category> categories = new List<Category>
            {
                new Category{Id = 1, Name = "FPS", Url = "game-category-FPS"},
                new Category{Id = 2, Name = "RPG", Url = "game-category-RPG"},
                new Category{Id = 3, Name = "Sports", Url = "game-category-sports"},
                new Category{Id = 4, Name = "Indie", Url = "game-category-indie"},
                new Category{Id = 5, Name = "Platformer", Url = "game-category-platformer"},
                new Category{Id = 6, Name = "3D", Url = "game-category-3d"},
            };
            modelBuilder.Entity<Category>().HasData(categories);

            List<Studio> studios = new List<Studio>
            {
                new Studio{Id = 1, Name = "Konami", Email = "contact@konami.com", Location = "Japan", ImageUrl = "https://slotcatalog.com/userfiles/image/brand/Konami_m.jpg", Url="studio_konami"},
                new Studio{Id = 2, Name = "Nintendo", Email = "contact@nintendo.com", Location = "Japan", ImageUrl = "https://logowik.com/content/uploads/images/nintendo4059.jpg", Url="studio_nintendo"},
                new Studio{Id = 3, Name = "SEGA", Email = "contact@sega.com", Location = "Japan", ImageUrl = "https://slotcatalog.com/userfiles/image/brand/Konami_m.jpg", Url="studio_sega"},
                new Studio{Id = 4, Name = "Bankai Namco", Email = "contact@bankai_namco.com", Location = "Japan", ImageUrl = "https://slotcatalog.com/userfiles/image/brand/Konami_m.jpg", Url="studio_bankai_namco"},
                new Studio{Id = 5, Name = "Bathesda", Email = "contact@bathesda.com", Location = "USA", ImageUrl = "https://i0.wp.com/gamehall.com.br/wp-content/uploads/2017/06/bethesda-logo.jpg?ssl=1", Url="studio_bathesda"},
                new Studio{Id = 6, Name = "Electronic Arts", Email = "contact@ea.com", Location = "USA", ImageUrl = "https://wizlogo.com/img/letters/e/ea_logo.jpg", Url="studio_ea"},
                new Studio{Id = 7, Name = "Valve", Email = "contact@valve.com", Location = "USA", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/Valve-logo.jpg/1200px-Valve-logo.jpg", Url="studio_valve"},
                new Studio{Id = 8, Name = "Ubisoft", Email = "contact@ubisoft.com", Location = "USA", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6c/New_Ubisoft_Logo.jpg", Url="studio_ubisoft"}
            };
            modelBuilder.Entity<Studio>().HasData(studios);

            List<Game> games;
            int i = 1;
            games = new List<Game>
            {
                // Fifa
                new Game
                {
                    Id = i++,
                    Title = "Fifa 10",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd",
                    Price = 100000,
                    OriginalPrice = 100000,
                    IsActive = true,
                    CategoryId = 3,
                    StudioId = 6
                },
                new Game
                {
                    Id = i++,
                    Title = "Fifa 11",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd",
                    Price = 100000,
                    OriginalPrice = 100000,
                    IsActive = true,
                    CategoryId = 3,
                    StudioId = 6
                },
                new Game
                {
                    Id = i++,
                    Title = "Fifa 12",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd",
                    Price = 100000,
                    OriginalPrice = 100000,
                    IsActive = true,
                    CategoryId = 3,
                    StudioId = 6
                },
                new Game
                {
                    Id = i++,
                    Title = "Fifa 13",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd",
                    Price = 100000,
                    OriginalPrice = 100000,
                    IsActive = true,
                    CategoryId = 3,
                    StudioId = 6
                },
                new Game
                {
                    Id = i++,
                    Title = "Fifa 14",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd",
                    Price = 100000,
                    OriginalPrice = 100000,
                    IsActive = true,
                    CategoryId = 3,
                    StudioId = 6
                },
                new Game
                {
                    Id = i++,
                    Title = "Fifa 15",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd",
                    Price = 100000,
                    OriginalPrice = 100000,
                    IsActive = true,
                    CategoryId = 3,
                    StudioId = 6
                },
                new Game
                {
                    Id = i++,
                    Title = "Fifa 16",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd",
                    Price = 100000,
                    OriginalPrice = 100000,
                    IsActive = true,
                    CategoryId = 3,
                    StudioId = 6
                },
                new Game
                {
                    Id = i++,
                    Title = "Fifa 17",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd",
                    Price = 100000,
                    OriginalPrice = 100000,
                    IsActive = true,
                    CategoryId = 3,
                    StudioId = 6
                },
                new Game
                {
                    Id = i++,
                    Title = "Fifa 18",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd",
                    Price = 150000,
                    OriginalPrice = 300000,
                    IsActive = true,
                    CategoryId = 3,
                    StudioId = 6
                },
                new Game
                {
                    Id = i++,
                    Title = "Fifa 19",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd",
                    Price = 300000,
                    OriginalPrice = 400000,
                    IsActive = true,
                    CategoryId = 3,
                    StudioId = 6
                },
                new Game
                {
                    Id = i++,
                    Title = "Fifa 20",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://i.scdn.co/image/ab67616d0000b273c634cd65ba525a56904e94bd",
                    Price = 500000,
                    OriginalPrice = 750000,
                    IsActive = true,
                    CategoryId = 3,
                    StudioId = 6
                },

                // Doom
                new Game
                {
                    Id = i++,
                    Title = "Doom 1",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/57/Doom_cover_art.jpg",
                    Price = 70000,
                    OriginalPrice = 70000,
                    IsActive = true,
                    CategoryId = 1,
                    StudioId = 5
                },new Game
                {
                    Id = i++,
                    Title = "Doom 2",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/2/29/Doom_II_-_Hell_on_Earth_Coverart.png",
                    Price = 100000,
                    OriginalPrice = 120000,
                    IsActive = true,
                    CategoryId = 1,
                    StudioId = 5
                },
                new Game
                {
                    Id = i++,
                    Title = "Doom 2016",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/28/Doom_Cover.jpg",
                    Price = 500000,
                    OriginalPrice = 750000,
                    IsActive = true,
                    CategoryId = 1,
                    StudioId = 5
                },
                new Game
                {
                    Id = i++,
                    Title = "Doom Eternal",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://i1.sndcdn.com/artworks-LwIUm8NfefhxgNrz-WlctLg-t500x500.jpg",
                    Price = 750000,
                    OriginalPrice = 1050000,
                    IsActive = true,
                    CategoryId = 1,
                    StudioId = 5
                },

                // Half life
                new Game
                {
                    Id = i++,
                    Title = "Half life 1",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/5/57/Half-life-cover.jpg",
                    Price = 750000,
                    OriginalPrice = 1050000,
                    IsActive = true,
                    CategoryId = 1,
                    StudioId = 7
                },
                new Game
                {
                    Id = i++,
                    Title = "Half life 2",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/2/25/Half-Life_2_cover.jpg",
                    Price = 750000,
                    OriginalPrice = 1050000,
                    IsActive = true,
                    CategoryId = 1,
                    StudioId = 7
                },

                // far cry
                new Game
                {
                    Id = i++,
                    Title = "Far cry 1",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a5/Far_Cry_1_boxshot.jpg",
                    Price = 20000,
                    OriginalPrice = 45000,
                    IsActive = true,
                    CategoryId = 1,
                    StudioId = 8
                },
                new Game
                {
                    Id = i++,
                    Title = "Far cry 2",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/97/Far_Cry_2_cover_art.jpg",
                    Price = 20000,
                    OriginalPrice = 45000,
                    IsActive = true,
                    CategoryId = 1,
                    StudioId = 8
                },
                new Game
                {
                    Id = i++,
                    Title = "Far cry 3",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/7/71/Far_Cry_3_dvd_cover.jpg",
                    Price = 40000,
                    OriginalPrice = 85000,
                    IsActive = true,
                    CategoryId = 1,
                    StudioId = 8
                },
                new Game
                {
                    Id = i++,
                    Title = "Far cry 4",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/1/12/Far_Cry_4_cover.jpg",
                    Price = 220000,
                    OriginalPrice = 450000,
                    IsActive = true,
                    CategoryId = 1,
                    StudioId = 8
                },

                // Yakuza
                new Game
                {
                    Id = i++,
                    Title = "Yakuza 0",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://assets-prd.ignimgs.com/2020/11/05/yakuza-zero-button-fin-1604543502548.jpg",
                    Price = 220000,
                    OriginalPrice = 450000,
                    IsActive = true,
                    CategoryId = 2,
                    StudioId = 3
                },
                new Game
                {
                    Id = i++,
                    Title = "Yakuza: Like a dragon",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://assets-prd.ignimgs.com/2020/11/05/yakuza-zero-button-fin-1604543502548.jpg",
                    Price = 420000,
                    OriginalPrice = 650000,
                    IsActive = true,
                    CategoryId = 2,
                    StudioId = 3
                },

                // Sonic
                new Game
                {
                    Id = i++,
                    Title = "Sonic Adventure",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/60/Sonic_Adventure.PNG",
                    Price = 420000,
                    OriginalPrice = 650000,
                    IsActive = true,
                    CategoryId = 2,
                    StudioId = 3
                },
                new Game
                {
                    Id = i++,
                    Title = "Sonic Adventure 2",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/99/Sonic_Adventure_2_cover.png",
                    Price = 420000,
                    OriginalPrice = 650000,
                    IsActive = true,
                    CategoryId = 2,
                    StudioId = 3
                },
                new Game
                {
                    Id = i++,
                    Title = "Sonic Mania",
                    ShortDescription = "Deez Nut haha, Gothem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec orci nibh, fermentum eget ligula nec, dapibus aliquet nibh. In hac habitasse platea dictumst. Proin consectetur ornare tristique. Integer nec pulvinar ipsum. Mauris venenatis mi varius, accumsan metus ut, porttitor dolor. Sed risus nisl, lacinia venenatis dapibus interdum, facilisis vel erat. Suspendisse vitae pulvinar nisi. Quisque pretium venenatis ante in hendrerit. Donec rhoncus pulvinar scelerisque. Curabitur condimentum ut lacus sed aliquet. Mauris blandit, dolor non interdum bibendum, nunc neque porta mauris, sed egestas diam nibh non sapien. Aliquam vel bibendum nibh, eu luctus tellus. Nam urna tortor, tristique in velit ut, tempus consequat leo. Praesent elementum congue dui, non sagittis ipsum fermentum eu.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Sonic_Mania_%28artwork%29.jpg",
                    Price = 420000,
                    OriginalPrice = 650000,
                    IsActive = true,
                    CategoryId = 2,
                    StudioId = 3
                },
            };
            modelBuilder.Entity<Game>().HasData(games);
        }
    }
}
