public class Movie
{private int rating;
    private String title;
    private double price;
    private boolean favorite;
    public int time;
    public static int numMIL;

    public Movie()
    {
        // initialise instance variables
        rating = 0;
        title = "";
        price = 0.0;
        time = 0;
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
public Movie(String title, double price, int rating, int time) {
    this.title = title;
    this.price = price;
    this.rating = rating;
    this.time = time;
    numMIL = numMIL + 1;
}
public int getTime() {
     return time;   
    }
public void setTime(int t) {
    time = t;    
    }   
    public void setNumMIL(int m) {
    numMIL = m;
    }
    public int getnumMIL() {
     return numMIL;   
    }
}
