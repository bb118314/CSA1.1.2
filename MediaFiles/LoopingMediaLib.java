public class LoopingMediaLib
{
    public static void main(){
        String songInfo = MediaFile.readString();
        System.out.println("My Favorite Songs" + "\n---------------");
        while (4 > 3){
            System.out.println(songInfo);
            songInfo = MediaFile.readString();
        }
    }
}