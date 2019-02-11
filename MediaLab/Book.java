public class Book
{
   // instance variables - replace the example below with your own
    private int rating;
    private String title;
    private double price;
    private boolean favorite;

    public Book()
    {
        // initialise instance variables
        rating = 0;
        title = "";
        price = 0.0;
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
public Book(String title, double price) {
    this.title = title;
    this.price = price;
}
}
