import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;


public class ArrayTest {
    public static int total = 0;
    public static int avg = 0;
    public static void main(String[] args) {
        ArrayList<Integer> scores = new ArrayList<>();
        int tests = 0;
        int i = 0;

        boolean gameState = true;
        Scanner sc = new Scanner(System.in);
        System.out.println("Test Scores");

        while (gameState) {

                System.out.print("Enter a score >> ");
                tests = sc.nextInt();
                if(tests == 999){
                    gameState = false;
                    scores.remove(i-1);
                }
                else {
                    scores.add(tests);
                    total = total + tests;
                }

                i++;

        }
        display(scores);

    }


    public static void display(ArrayList<Integer> scores){

        System.out.println("The size of the list is " + scores.size());
        for(int i = 0; i < scores.size(); ++i){
            System.out.println("Position: " + (i + 1) + " Score: " + scores.get(i));
        }
        avg = (total / (scores.size()+1));
        System.out.println("Total Score: " + total);
        System.out.println("Average Score: " + avg);
    }
}
