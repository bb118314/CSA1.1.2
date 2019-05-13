package main;

import java.util.Scanner;

import static main.Wallet.wallet;

public class Concessions {
    public static void food() {
        Scanner in = new Scanner(System.in);
        System.out.println("\nYou make your way to the concessions stand.");
        System.out.println("What would you like to eat or drink? You have $" + wallet + ".\nBurger - $%\nTaco - $4\nCaviar - $150\nSushi - $9\nCandy = $3\nWater - $1");
        String text = "";
        String msg = "";
        int taco = 4;
        int candy = 3;
        int burger = 5;
        int water = 1;
        int caviar = 150;
        int sushi = 9;

        while(!text.equals("leave"))
        {
            text = in.nextLine();
            switch(text)
            {
                case "taco" :
                    if (taco > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - taco;
                        msg = "You buy the taco and have $" + wallet + " left";
                    }
                    break;
                case "candy" :
                    if (candy > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - candy;
                        msg = "You buy the candy and have $" + wallet + " left";
                    }
                    break;
                case "burger" :
                    if (burger > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - burger;
                        msg = "You buy the burger and have $" + wallet + " left";
                    }
                    break;
                case "water" :
                    if (water > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - water;
                        msg = "You buy the water and have $" + wallet + " left";
                    }
                    break;
                case "caviar":
                    if (caviar > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - caviar;
                        msg = "You buy the caviar and have $" + wallet + " left";
                    }
                    break;
                case "sushi":
                    if (sushi > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - sushi;
                        msg = "You buy the sushi and have $" + wallet + " left";
                    }
                    break;
                case "rob":
                    wallet = wallet + 245;
                    System.out.println("'PUT THE MONEY IN THE BAG'\nYou steal $245 and now have $" + wallet + ".");
                    break;
                default : msg = "You flail helplessly with indecision.";
            }
            System.out.println(msg);
        }
    }


}
