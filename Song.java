public class Song
{
    // instance variables - replace the example below with your own
    public int rating;
    private String title;
    public double price;
    private boolean favorite;
    public static int numSongsInLibrary;
    

    public Song()
    {
        // initialise instance variables
        rating = 0;
        title = "";
        price = 0.0;
    }
    public Song(String title, double price) {
        this.title = title;
        this.price = price;
        numSongsInLibrary = numSongsInLibrary + 1;
    }
    public Song(String title, double price, int rating) {
        this.title = title;
        this.price = price;
        this.rating = rating;
        numSongsInLibrary = numSongsInLibrary + 1;
    }
    public String getTitle() {
        return title;
    }
    public void setTitle(String t) {
        title = t;
    }
    public int getRating() {
     return rating;   
    }
    public void setRating(int r) {
    rating = r;    
    }
    public double getPrice() {
     return price;   
    }
    public void setPrice(double p) {
    price = p;    
    }
    public void addToFavorites() {
    favorite = true;
    }
    public void setNumSongsInLibrary(int n) {
    numSongsInLibrary = n;
    }
    public int getNumSongsInLibrary() {
     return numSongsInLibrary;   
    }
}
