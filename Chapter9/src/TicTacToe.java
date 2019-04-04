import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

public class TicTacToe {

    public static int [] [] board = {{1, 2, 3},
                                     {4, 5, 6},
                                     {7, 8, 9}};

    public static void main(String[] args) {


        Scanner sc = new Scanner(System.in);
        int answer = 100;
        Boolean gameRun = true;
        ArrayList<Integer> numbers = new ArrayList<>();

        for(int i=1; i < 10; i++){
            numbers.add(i);
        }

        while (gameRun = true) {
            for (int i = 0; i < board.length; i++) {
                System.out.println(Arrays.toString(board[i]));
            }
            winner();
            System.out.print("Enter your answer >> ");
            answer = sc.nextInt();
            random();

            if (answer == 1) {
                if (numbers.get(0) == 1) {
                    board[0][0] = 0;
                    numbers.set(0, 999);
                }
                else {
                    System.out.println("You're either a bad cheater or just really dumb. You Lose.");
                    System.exit(0);
                }
            }
            else if (answer == 2) {
                board[0][1] = 0;
                numbers.set(1, 999);
            }
            else if (answer == 3) {
                board[0][2] = 0;
                numbers.set(2, 999);
            }
            else if (answer == 4) {
                board[1][0] = 0;
                numbers.set(3, 999);
            }
            else if (answer == 5) {
                board[1][1] = 0;
                numbers.set(4, 999);
            }
            else if (answer == 6) {
                board[1][2] = 0;
                numbers.set(5, 999);
            }
            else if (answer == 7) {
                board[2][0] = 0;
                numbers.set(6, 999);
            }
            else if (answer == 8) {
                board[2][1] = 0;
                numbers.set(7, 999);
            }
            else if (answer == 9) {
                board[2][2] = 0;
                numbers.set(8, 999);
            }



        }



    }
    public static void random() {
        Random rand = new Random();
        int n = rand.nextInt(10);

        if (n == 1) {
            if (board[0][0] == 1) {
                board[0][0] = 11;
            }
            else {
                otherRando();
            }
        }
        else if (n == 2) {
            if (board[0][n -1] == n) {
                board[0][n -1] = 11;
            }
            else {
                otherRando();
            }
        }
        else if (n == 3) {
            if (board[0][2] == 3) {
                board[0][2] = 11;
            }
            else {
                otherRando();
            }
        }
        else if (n == 4) {
            if (board[1][0] == 4) {
                board[1][0] = 11;
            }
            else {
                otherRando();
            }
        }
        else if (n == 5) {
            if (board[1][1] == 5) {
                board[1][1] = 11;
            }
            else {
                otherRando();
            }
        }
        else if (n == 6) {
            if (board[1][2] == 6) {
                board[1][2] = 11;
            }
            else {
                otherRando();
            }
        }
        else if (n == 7) {
            if (board[2][0] == 7) {
                board[2][0] = 11;
            }
            else {
                otherRando();
            }
        }
        else if (n == 8) {
            if (board[2][1] == 8) {
                board[2][1] = 11;
            }
            else {
                otherRando();
            }
        }
        else if (n == 9) {
            if (board[2][2] == 9) {
                board[2][2] = 11;
            }
            else {
                otherRando();
            }
        }

    }
    public static void otherRando(){
        Random rand = new Random();
        int n = rand.nextInt(10);
        random();
    }

    public static void winner(){
        String youWin = "You Win! Congratulations!";
        String computerWin = "You Lost! Get good.";
        if (board[0][0] == 0 && board[0][1] == 0 && board[0][2] == 0) {
            System.out.println(youWin);
            System.exit(0);
        }
        if (board[1][0] == 0 && board[1][1] == 0 && board[1][2] == 0) {
            System.out.println(youWin);
            System.exit(0);
        }
        if (board[2][0] == 0 && board[2][1] == 0 && board[2][2] == 0) {
            System.out.println(youWin);
            System.exit(0);
        }
        if (board[0][0] == 0 && board[1][0] == 0 && board[2][0] == 0) {
            System.out.println(youWin);
            System.exit(0);
        }
        if (board[0][1] == 0 && board[1][1] == 0 && board[2][1] == 0) {
            System.out.println(youWin);
            System.exit(0);
        }
        if (board[0][2] == 0 && board[1][2] == 0 && board[2][2] == 0) {
            System.out.println(youWin);
            System.exit(0);
        }
        if (board[0][0] == 0 && board[1][1] == 0 && board[2][2] == 0) {
            System.out.println(youWin);
            System.exit(0);
        }
        if (board[0][2] == 0 && board[1][1] == 0 && board[2][0] == 0) {
            System.out.println(youWin);
            System.exit(0);
        }

        // COMPUTER

        if (board[0][0] == 11 && board[0][1] == 11 && board[0][2] == 11) {
            System.out.println(computerWin);
            System.exit(0);
        }
        if (board[1][0] == 11 && board[1][1] == 11 && board[1][2] == 11) {
            System.out.println(computerWin);
            System.exit(0);
        }
        if (board[2][0] == 11 && board[2][1] == 11 && board[2][2] == 11) {
            System.out.println(computerWin);
            System.exit(0);
        }
        if (board[0][0] == 11 && board[1][0] == 11 && board[2][0] == 11) {
            System.out.println(computerWin);
            System.exit(0);
        }
        if (board[0][1] == 11 && board[1][1] == 11 && board[2][1] == 11) {
            System.out.println(computerWin);
            System.exit(0);
        }
        if (board[0][2] == 11 && board[1][2] == 11 && board[2][2] == 11) {
            System.out.println(computerWin);
            System.exit(0);
        }
        if (board[0][0] == 11 && board[1][1] == 11 && board[2][2] == 11) {
            System.out.println(computerWin);
            System.exit(0);
        }
        if (board[0][2] == 11 && board[1][1] == 11 && board[2][0] == 11) {
            System.out.println(computerWin);
            System.exit(0);
        }
    }
}
