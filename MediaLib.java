public class MediaLib
{
    public static void main(String args[]){
        System.out.println("Welcome to your media library\n");
        Song song1 = new Song();
        song1.setTitle("Song Title: Johnny B. Goode");
        System.out.println(song1.getTitle());
        song1.setRating(4);
        System.out.println("Rating: " + song1.getRating());
        song1.setPrice(7.99);
        System.out.println("Price: " + song1.getPrice() + "\n");
        
        Book book1 = new Book();
        song1.setTitle("Book Title: OJ Simpson: A Testimony");
        System.out.println(song1.getTitle());
        song1.setRating(10);
        System.out.println("Rating: " + song1.getRating());
        song1.setPrice(75.99);
        System.out.println("Price: " + song1.getPrice() + "\n");
        
        Movie movie1 = new Movie();
        song1.setTitle("Movie Title: Cloudy with a Chance of Meatballs");
        System.out.println(song1.getTitle());
        song1.setRating(4);
        System.out.println("Rating: " + song1.getRating());
        song1.setPrice(2.99);
        System.out.println("Price: " + song1.getPrice());
        }
}
