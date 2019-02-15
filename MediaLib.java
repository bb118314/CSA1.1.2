public class MediaLib
{
    public static void main(){

        int numSongs = 0;
        System.out.println("Welcome to your Media Library\n");
        
        System.out.println("Songs\n");
        
        Song song1 = new Song("Song Title: Johnny B. Goode", 0.99, 4);
        System.out.println(song1.getTitle());
        System.out.println("Rating: " + song1.getRating());
        System.out.println("Price: $" + song1.getPrice() + "\n");
        
        Song song2 = new Song("Song Title: Big Iron", 1.10, 9);
        System.out.println(song2.getTitle());
        System.out.println("Rating: " + song2.getRating());
        System.out.println("Price: $" + song2.getPrice() + "\n");
        
        Song song3 = new Song("Song Title: Ave Maria", 1.19, 7);
        System.out.println(song3.getTitle());
        System.out.println("Rating: " + song3.getRating());
        System.out.println("Price: $" + song3.getPrice() + "\n");
        
        Song song4 = new Song("Song Title: Chase's Autobiography", 1.05, 1);
        System.out.println(song4.getTitle());
        System.out.println("Rating: " + song4.getRating());
        System.out.println("Price: $" + song4.getPrice() + "\n");
        
        Song song5 = new Song("Song Title: Grandma Ate the Blueberries", 1.00, 5);
        System.out.println(song5.getTitle());
        System.out.println("Rating: " + song5.getRating());
        System.out.println("Price: $" + song5.getPrice() + "\n");
        
        Song song6 = new Song("Song Title: Help?", 0.99, 7);
        System.out.println(song6.getTitle());
        System.out.println("Rating: " + song6.getRating());
        System.out.println("Price: $" + song6.getPrice() + "\n");
        
        Song song7 = new Song("Song Title: Guatamela", 1.15, 8);
        System.out.println(song7.getTitle());
        System.out.println("Rating: " + song7.getRating());
        System.out.println("Price: $" + song7.getPrice() + "\n");
        
        Song song8 = new Song("Song Title: Shween", 1.07, 9);
        System.out.println(song8.getTitle());
        System.out.println("Rating: " + song8.getRating());
        System.out.println("Price: $" + song8.getPrice() + "\n");
       
    numSongs = numSongs + 1;
    double avgPrice = (song1.price + song2.price + song3.price + song4.price + song5.price + song6.price + song7.price + song8.price) / song8.getNumSongsInLibrary();
    int avgRating  = (song1.rating + song2.rating + song3.rating + song4.rating + song5.rating + song6.rating + song7.rating + song8.rating) / song8.getNumSongsInLibrary();
    System.out.print("Number of Songs: ");
    System.out.println(song8.getNumSongsInLibrary());
    System.out.print("\nAverage Song Rating: ");
    System.out.println(avgRating);
    System.out.print("Average Song Cost: $");
    System.out.println(avgPrice + "\n");
    
        System.out.println("Books\n");
        
        
        Book book1 = new Book("Book Title: OJ Simpson: A Testimony", 75.99, 10, 8265);
        System.out.println(book1.getTitle());
        System.out.println("Rating: " + book1.getRating());
        System.out.println("Length: " + book1.getPages() + " Pages");
        System.out.println("Price: $" + book1.getPrice() + "\n");
        
         Book book2 = new Book("Book Title: Easy Money", 0.01, 10, 1);
        System.out.println(book2.getTitle());
        System.out.println("Rating: " + book2.getRating());
        System.out.println("Length: " + book2.getPages() + " Page");
        System.out.println("Price: $" + book2.getPrice() + "\n");
        
         Book book3 = new Book("Book Title: The Emoji Handbook", 5.26, 9, 50);
        System.out.println(book3.getTitle());
        System.out.println("Rating: " + book3.getRating());
        System.out.println("Length: " + book3.getPages() + " Pages");
        System.out.println("Price: $" + book3.getPrice() + "\n");
        
         Book book4 = new Book("Book Title: The Death of Lincoln", 314.99, 3, 412);
        System.out.println(book4.getTitle());
        System.out.println("Rating: " + book4.getRating());
        System.out.println("Length: " + book4.getPages() + " Pages");
        System.out.println("Price: $" + book4.getPrice() + "\n");
        
        int totalPages = (book1.pages + book2.pages + book3.pages + book4.pages);
        int avgPages = totalPages / book4.getNumBook();
        System.out.println("Total Books: " + book4.getNumBook() + "\n");
        System.out.println("Total Pages: " + totalPages);
        System.out.println("Average Pages: " + avgPages + "\n");
        
        
        
        System.out.println("Movies\n");
        
        Movie movie1 = new Movie("Movie Title: Cloudy with a Chance of Meatballs", 
        2.99, 4, 232);
        System.out.println(movie1.getTitle());
        System.out.println("Rating: " + movie1.getRating());
        System.out.println("Price: $" + movie1.getPrice());
        System.out.println("Length: " + movie1.getTime() + " Minutes" + "\n");
        
        Movie movie2 = new Movie("Movie Title: Avengers: Infinty War", 
        6.99, 7, 112);
        System.out.println(movie2.getTitle());
        System.out.println("Rating: " + movie2.getRating());
        System.out.println("Price: $" + movie2.getPrice());
        System.out.println("Length: " + movie2.getTime() + " Minutes" + "\n");
        
        Movie movie3 = new Movie("Movie Title: Captain Marvel", 
        8.99, 3, 152);
        System.out.println(movie3.getTitle());
        System.out.println("Rating: " + movie3.getRating());
        System.out.println("Price: $" + movie3.getPrice());
        System.out.println("Length: " + movie3.getTime() + " Minutes" + "\n");
        
        Movie movie4 = new Movie("Movie Title: Black Panther", 
        12.99, 7, 124);
        System.out.println(movie4.getTitle());
        System.out.println("Rating: " + movie4.getRating());
        System.out.println("Price: $" + movie4.getPrice());
        System.out.println("Length: " + movie4.getTime() + " Minutes" + "\n");
        
        Movie movie5 = new Movie("Movie Title: Paddington 2", 
       49.99, 10, 201);
       System.out.println(movie5.getTitle());
        System.out.println("Rating: " + movie5.getRating());
        System.out.println("Price: $" + movie5.getPrice());
        System.out.println("Length: " + movie5.getTime() + " Minutes" + "\n");
       

        int timeMinutes = movie1.time + movie2.time + movie3.time + movie4.time + movie5.time;
        int timeHours = timeMinutes / 60;
        int timeLeft = timeMinutes % 60;
        int avgMinutes = timeMinutes / movie5.getnumMIL();
        int avgHours = avgMinutes / 60;
        int avgLeft = avgMinutes % 60;
        System.out.println("Total Number of Movies: " + movie5.getnumMIL() + "\n");
        System.out.println("Total Time in Minutes: " + timeMinutes);
        System.out.println("Total Time in Hours: " + timeHours + " hours and " + timeLeft + " minutes\n");
        System.out.println("Average Time in Minutes: " + avgMinutes);
        System.out.println("Average Time in Hours: " + avgHours + " hour(s) and " + avgLeft + " minutes\n");
        

        }
}
