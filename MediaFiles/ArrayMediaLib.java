public class ArrayMediaLib
{
    public static void main(){
        
    String[] sharingFriends = {"Jamal",
                   "Emily",
                   "Destiny",
                   "Mateo",
                   "Sofia"  // notice no comma
 };
    for (int i = 0; i< 5; ++i) {
        System.out.println(sharingFriends[i]);
}
int [] daysBtwnPurchase = {2, 5, 1, 2, 4, 2, 1, 3};
int total = 0;
for (int val: daysBtwnPurchase) {
    total = total + val;
}
Song [] topTenSongs = {
new Song ("The Twist"),
new Song ("Smooth"),
new Song ("Mack the Knife"),
new Song ("How Do I Live"),
new Song ("Party Rock Anthem"),
new Song ("I Gotta Feeling"),
new Song ("Macaren"),
new Song ("Physical"),
new Song ("You Light Up My Life"),
new Song ("Hey Jude")
};
for (Song s: topTenSongs)
{
    System.out.println(s.getTitle());
}
System.out.println("-BEFORE--");
for (Song changeSong : topTenSongs) {
    changeSong.setTitle("test");
}
System.out.println("-AFTER--");
for (Song showSong : topTenSongs) {
    System.out.println(showSong.getTitle());
}

}
}