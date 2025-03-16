using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding 50 products
            modelBuilder.Entity<Product>().HasData(
                 new Product { Id = 1, Name = "To Kill a Mockingbird", Description = "A novel by Harper Lee published in 1960. It is widely studied for its themes of racial injustice and moral growth.", Price = 10.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8226091-L.jpg" },
    new Product { Id = 2, Name = "1984", Description = "A dystopian social science fiction novel and cautionary tale by the English writer George Orwell.", Price = 9.99m, ImageUrl = "https://covers.openlibrary.org/b/id/10450190-L.jpg" },
    new Product { Id = 3, Name = "The Great Gatsby", Description = "A 1925 novel by American writer F. Scott Fitzgerald. It explores themes of wealth, decadence, and the American Dream.", Price = 8.99m, ImageUrl = "https://covers.openlibrary.org/b/id/10352927-L.jpg" },
    new Product { Id = 4, Name = "Moby Dick", Description = "Herman Melville’s 1851 classic that explores the obsessive quest of Captain Ahab for revenge against the white whale.", Price = 11.99m, ImageUrl = "https://covers.openlibrary.org/b/id/9687349-L.jpg" },
    new Product { Id = 5, Name = "The Catcher in the Rye", Description = "J.D. Salinger’s 1951 novel about a young man named Holden Caulfield and his journey to adulthood and self-awareness.", Price = 10.50m, ImageUrl = "https://covers.openlibrary.org/b/id/9319162-L.jpg" },
    new Product { Id = 6, Name = "Pride and Prejudice", Description = "Jane Austen’s 1813 novel, which centers on the love story between Elizabeth Bennet and Mr. Darcy.", Price = 7.99m, ImageUrl = "https://covers.openlibrary.org/b/id/9530739-L.jpg" },
    new Product { Id = 7, Name = "War and Peace", Description = "Leo Tolstoy’s epic novel set during the Napoleonic Wars. It explores Russian society and the lives of aristocratic families.", Price = 14.99m, ImageUrl = "https://covers.openlibrary.org/b/id/9535249-L.jpg" },
    new Product { Id = 8, Name = "The Lord of the Rings", Description = "J.R.R. Tolkien’s fantasy epic about the quest to destroy the One Ring and save Middle-earth.", Price = 19.99m, ImageUrl = "https://covers.openlibrary.org/b/id/9898993-L.jpg" },
    new Product { Id = 9, Name = "The Chronicles of Narnia", Description = "C.S. Lewis’s classic fantasy series that follows the adventures of children in the magical land of Narnia.", Price = 24.99m, ImageUrl = "https://covers.openlibrary.org/b/id/9220226-L.jpg" },
    new Product { Id = 10, Name = "The Hobbit", Description = "J.R.R. Tolkien’s prequel to The Lord of the Rings, telling the story of Bilbo Baggins’ journey to reclaim a stolen treasure.", Price = 10.50m, ImageUrl = "https://covers.openlibrary.org/b/id/8176976-L.jpg" },
    new Product { Id = 11, Name = "Brave New World", Description = "A dystopian novel by Aldous Huxley, set in a world where technology controls human behavior and society.", Price = 9.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8740197-L.jpg" },
    new Product { Id = 12, Name = "Fahrenheit 451", Description = "Ray Bradbury’s novel about a future society where books are banned and 'firemen' burn any that are found.", Price = 8.99m, ImageUrl = "https://covers.openlibrary.org/b/id/10020691-L.jpg" },
    new Product { Id = 13, Name = "The Handmaid's Tale", Description = "Margaret Atwood’s dystopian novel about a society where women have been stripped of their rights and forced into servitude.", Price = 10.00m, ImageUrl = "https://covers.openlibrary.org/b/id/9238475-L.jpg" },
    new Product { Id = 14, Name = "Little Women", Description = "Louisa May Alcott’s coming-of-age story about the four March sisters growing up during the American Civil War.", Price = 6.99m, ImageUrl = "https://covers.openlibrary.org/b/id/9257804-L.jpg" },
    new Product { Id = 15, Name = "The Hunger Games", Description = "Suzanne Collins’ first book in a trilogy set in a dystopian future where children fight to the death in televised gladiator-style games.", Price = 12.99m, ImageUrl = "https://covers.openlibrary.org/b/id/9240147-L.jpg" },
    new Product { Id = 16, Name = "The Fault in Our Stars", Description = "John Green’s emotional novel about two teenagers with cancer who fall in love and struggle with the realities of life and death.", Price = 8.99m, ImageUrl = "https://covers.openlibrary.org/b/id/10520774-L.jpg" },
    new Product { Id = 17, Name = "The Alchemist", Description = "Paulo Coelho’s inspiring novel about a young shepherd's journey to find his personal legend and a hidden treasure.", Price = 9.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8033251-L.jpg" },
    new Product { Id = 18, Name = "Animal Farm", Description = "George Orwell’s political allegory about a group of farm animals who overthrow their human owner and create their own society.", Price = 7.99m, ImageUrl = "https://covers.openlibrary.org/b/id/11101016-L.jpg" },
    new Product { Id = 19, Name = "Jane Eyre", Description = "Charlotte Brontë’s novel about an orphan who becomes a governess at a mysterious manor and falls in love with her employer.", Price = 10.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8364107-L.jpg" },
    new Product { Id = 20, Name = "The Picture of Dorian Gray", Description = "Oscar Wilde’s philosophical novel about a man who remains eternally young while his portrait ages and reflects his corrupt soul.", Price = 8.00m, ImageUrl = "https://covers.openlibrary.org/b/id/8364108-L.jpg" },
        new Product { Id = 21, Name = "Gone with the Wind", Description = "Margaret Mitchell’s novel set during the American Civil War and Reconstruction, focusing on the life of Scarlett O'Hara.", Price = 12.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8358539-L.jpg" },
    new Product { Id = 22, Name = "Catch-22", Description = "Joseph Heller’s satirical novel about the absurdity of war, focusing on the story of Captain John Yossarian.", Price = 10.49m, ImageUrl = "https://covers.openlibrary.org/b/id/9789209-L.jpg" },
    new Product { Id = 23, Name = "The Outsiders", Description = "S.E. Hinton’s novel about a gang of teenagers from different social classes who face challenges in their community.", Price = 8.99m, ImageUrl = "https://covers.openlibrary.org/b/id/10284792-L.jpg" },
    new Product { Id = 24, Name = "The Road", Description = "Cormac McCarthy’s post-apocalyptic novel about a father and son surviving in a bleak, destroyed world.", Price = 11.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8219812-L.jpg" },
    new Product { Id = 25, Name = "The Shining", Description = "Stephen King’s horror novel about a family trapped in a haunted hotel with a malevolent force that drives the father to insanity.", Price = 9.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8197904-L.jpg" },
    new Product { Id = 26, Name = "The Catcher in the Rye", Description = "J.D. Salinger’s 1951 novel about a young man named Holden Caulfield and his journey to adulthood and self-awareness.", Price = 10.50m, ImageUrl = "https://covers.openlibrary.org/b/id/9319162-L.jpg" },
    new Product { Id = 27, Name = "The Secret Garden", Description = "Frances Hodgson Burnett’s classic novel about a young girl who discovers a magical secret garden that brings healing.", Price = 6.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8148157-L.jpg" },
    new Product { Id = 28, Name = "The Giver", Description = "Lois Lowry’s dystopian novel about a boy named Jonas who lives in a society that eliminates all pain and memories.", Price = 8.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8241990-L.jpg" },
    new Product { Id = 29, Name = "The Sun Also Rises", Description = "Ernest Hemingway’s novel about a group of expatriates traveling through Europe in the 1920s, exploring themes of love and disillusionment.", Price = 9.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8497425-L.jpg" },
    new Product { Id = 30, Name = "The Bell Jar", Description = "Sylvia Plath’s novel about a young woman’s descent into mental illness and her struggle with depression and societal expectations.", Price = 7.99m, ImageUrl = "https://covers.openlibrary.org/b/id/10799260-L.jpg" },
    new Product { Id = 31, Name = "The Color Purple", Description = "Alice Walker’s Pulitzer Prize-winning novel about a black woman’s journey through oppression, pain, and eventual self-realization.", Price = 10.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8538665-L.jpg" },
    new Product { Id = 32, Name = "Beloved", Description = "Toni Morrison’s novel about a runaway slave who returns to her family, only to be haunted by the past.", Price = 11.99m, ImageUrl = "https://covers.openlibrary.org/b/id/9266494-L.jpg" },
    new Product { Id = 33, Name = "Crime and Punishment", Description = "Fyodor Dostoevsky’s novel that explores the psychological torment of a young man who commits a crime and tries to justify it.", Price = 8.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8489294-L.jpg" },
    new Product { Id = 34, Name = "The Divine Comedy", Description = "Dante Alighieri’s epic poem that describes the journey of a soul through Hell, Purgatory, and Heaven.", Price = 13.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8477642-L.jpg" },
    new Product { Id = 35, Name = "Les Misérables", Description = "Victor Hugo’s historical novel set during the French Revolution, focusing on the lives of several characters and their struggles for redemption.", Price = 14.99m, ImageUrl = "https://covers.openlibrary.org/b/id/9315504-L.jpg" },
    new Product { Id = 36, Name = "Dracula", Description = "Bram Stoker’s Gothic horror novel about the infamous vampire Count Dracula and his attempt to spread his undead curse.", Price = 9.99m, ImageUrl = "https://covers.openlibrary.org/b/id/9486335-L.jpg" },
    new Product { Id = 37, Name = "Frankenstein", Description = "Mary Shelley’s novel about a scientist who creates a creature and faces the consequences of playing God.", Price = 7.49m, ImageUrl = "https://covers.openlibrary.org/b/id/9408352-L.jpg" },
    new Product { Id = 38, Name = "The Brothers Karamazov", Description = "Fyodor Dostoevsky’s philosophical novel about the moral and spiritual struggles of the Karamazov family.", Price = 15.00m, ImageUrl = "https://covers.openlibrary.org/b/id/9888813-L.jpg" },
    new Product { Id = 39, Name = "The Art of War", Description = "Sun Tzu’s ancient Chinese text on military strategy and tactics that has been applied in various fields of life and business.", Price = 5.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8437644-L.jpg" },
    new Product { Id = 40, Name = "Meditations", Description = "Marcus Aurelius’ collection of personal writings about Stoic philosophy and his reflections on life and leadership.", Price = 6.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8408337-L.jpg" },
    new Product { Id = 41, Name = "The Prince", Description = "Niccolò Machiavelli’s political treatise that offers advice on political leadership and the acquisition of power.", Price = 7.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8314184-L.jpg" },
    new Product { Id = 42, Name = "The Republic", Description = "Plato’s work on philosophy and justice, focusing on the nature of the ideal state and the roles of individuals within it.", Price = 8.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8475929-L.jpg" },
    new Product { Id = 43, Name = "The Iliad", Description = "Homer’s epic poem about the Trojan War, focusing on the hero Achilles and his role in the conflict.", Price = 10.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8444629-L.jpg" },
    new Product { Id = 44, Name = "The Odyssey", Description = "Homer’s epic poem about the hero Odysseus’ long journey home after the Trojan War.", Price = 9.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8526704-L.jpg" },
    new Product { Id = 45, Name = "The Canterbury Tales", Description = "Geoffrey Chaucer’s collection of stories told by a group of pilgrims on their way to Canterbury.", Price = 10.00m, ImageUrl = "https://covers.openlibrary.org/b/id/8402679-L.jpg" },
    new Product { Id = 46, Name = "The Count of Monte Cristo", Description = "Alexandre Dumas’ adventure novel about Edmond Dantès’ quest for revenge after being wrongfully imprisoned.", Price = 12.00m, ImageUrl = "https://covers.openlibrary.org/b/id/8200577-L.jpg" },
    new Product { Id = 47, Name = "Don Quixote", Description = "Miguel de Cervantes’ novel about a man who sets out on adventures as a self-proclaimed knight, inspired by chivalric tales.", Price = 13.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8492039-L.jpg" },
    new Product { Id = 48, Name = "Anna Karenina", Description = "Leo Tolstoy’s novel about a married aristocrat who engages in a tragic affair with the young Count Vronsky.", Price = 12.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8586820-L.jpg" },
    new Product { Id = 49, Name = "Wuthering Heights", Description = "Emily Brontë’s novel about the intense and tragic love between Heathcliff and Catherine Earnshaw.", Price = 8.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8664462-L.jpg" },
    new Product { Id = 50, Name = "The Scarlet Letter", Description = "Nathaniel Hawthorne’s novel about the life of Hester Prynne, who is shamed for having an affair in Puritan New England.", Price = 7.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8734181-L.jpg" }


            );
        }
    }
}
