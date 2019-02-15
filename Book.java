public class Book
{
   // instance variables - replace the example below with your own
    private int rating;
    private String title;
    private double price;
    private boolean favorite;
    public int pages;
    public static int numBook;
    

    public Book()
    {
        // initialise instance variables
        rating = 0;
        title = "";
        price = 0.0;
        pages = 0;
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
public Book(String title, double price, int rating, int pages) {
    this.title = title;
    this.price = price;
    this.rating = rating;
    this.pages = pages;
    numBook = numBook + 1;
}
public int getPages() {
        return pages;
    }
    public void setPages(int p) {
        pages = p;
    }
    public void setNumBook(int mb) {
    numBook = mb;
    }
    public int getNumBook() {
     return numBook;   
    }
}
