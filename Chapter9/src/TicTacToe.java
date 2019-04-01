import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

public class TicTacToe {
    public static void main(String[] args) {
        int [] [] board = {{1, 2, 3},
                              {4, 5, 6},
                              {7, 8, 9}};

        Scanner sc = new Scanner(System.in);
        int answer = 100;
        Boolean gameRun = true;

        while (gameRun = true) {
            for (int i = 0; i < board.length; i++) {
                System.out.println(Arrays.toString(board[i]));
            }
            System.out.print("Enter your answer >> ");
            answer = sc.nextInt();
            random();

            if (answer == 1) {
                board[0][0] = 00;
            }
            else if (answer == 2) {
                board[0][1] = 00;
            }
            else if (answer == 3) {
                board[0][2] = 00;
            }
            else if (answer == 4) {
                board[1][0] = 00;
            }
            else if (answer == 5) {
                board[1][1] = 00;
            }
            else if (answer == 6) {
                board[1][2] = 00;
            }
            else if (answer == 7) {
                board[2][0] = 00;
            }
            else if (answer == 8) {
                board[2][1] = 00;
            }
            else if (answer == 9) {
                board[2][2] = 00;
            }
        }



    }
    public static void random() {
        Random rand = new Random();
        int n = rand.nextInt(10);

    }
}
