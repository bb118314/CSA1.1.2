import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class CheckerBoard {


    public static void main(String[] args) {

        String [] [] board = new String[8][8];

        Scanner sc = new Scanner(System.in);
        Boolean gameRun = true;
        ArrayList<Integer> numbers = new ArrayList<>();

// Forgive me programming jesus for i have sinned to the highest degree
        for (int i = 0; i < 8; i = i + 1) {
                board[0][i] = "W";
            for (int j = 1; j < 8; j = j + 2) {
                board[0][j] = "C";
            }
        }
        for (int i = 0; i < 8; i = i + 1) {
            board[1][i] = "W";
            for (int j = 0; j < 8; j = j + 2) {
                board[1][j] = "C";
            }
        }
        for (int i = 0; i < 8; i = i + 1) {
            board[2][i] = "W";
            for (int j = 1; j < 8; j = j + 2) {
                board[2][j] = "C";
            }
        }
        for (int i = 0; i < 8; i = i + 1) {
            board[3][i] = "W";
            for (int j = 0; j < 8; j = j + 2) {
                board[3][j] = "B";
            }
        }
        for (int i = 0; i < 8; i = i + 1) {
            board[4][i] = "W";
            for (int j = 1; j < 8; j = j + 2) {
                board[4][j] = "B";
            }
        }
        for (int i = 0; i < 8; i = i + 1) {
            board[5][i] = "W";
            for (int j = 0; j < 8; j = j + 2) {
                board[5][j] = "C";
            }
        }
        for (int i = 0; i < 8; i = i + 1) {
            board[6][i] = "W";
            for (int j = 1; j < 8; j = j + 2) {
                board[6][j] = "C";
            }
        }
        for (int i = 0; i < 8; i = i + 1) {
            board[7][i] = "W";
            for (int j = 0; j < 8; j = j + 2) {
                board[7][j] = "C";
            }
        }



        for (String[] row : board) {
            for (String col : row) {
                System.out.print(col + " ");
            }
            System.out.print("\n");
        }



    }
}
