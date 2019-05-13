package main;

import java.util.Scanner;

import static main.Wallet.wallet;

public class Gift_Shop {
    public static void shop() {
        Scanner in = new Scanner(System.in);
        System.out.println("\nYou make your way to the gift shop.");
        System.out.println("What would you like to buy? You have $" + wallet + ".\nTeddy Bear - $10\nGummy Snake - $5\nFan - $5\nSunglasses = $10\nSunscreen - $8\nGiant Stick - $9\nT-Shirt - $15\nSweater - $20\nBackpack - $15\nXbox 720 - $720");
        String text = "";
        String msg = "";
        int teddy = 10;
        int gummy = 5;
        int fan = 5;
        int sunglasses = 10;
        int sunscreen = 8;
        int stick = 9;
        int shirt = 15;
        int sweater = 20;
        int backpack = 15;
        int xbox = 720;

        while(!text.equals("leave"))
        {
            text = in.nextLine();
            switch(text)
            {
                case "teddy bear" :
                    if (teddy > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                }
                else {
                        wallet = wallet - teddy;
                        msg = "You buy the teddy bear and have $" + wallet + " left";
                    }
                    break;
                case "gummy snake" :
                    if (gummy > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - gummy;
                        msg = "You buy the gummy snake and have $" + wallet + " left";
                    }
                    break;
                case "fan" :
                    if (fan > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - fan;
                        msg = "You buy the fan and have $" + wallet + " left";
                    }
                    break;
                case "sunglasses" :
                    if (sunglasses > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - sunglasses;
                        msg = "You buy the sunglasses and have $" + wallet + " left";
                    }
                    break;
                case "sunscreen":
                    if (sunscreen > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - sunscreen;
                        msg = "You buy the sunscreen and have $" + wallet + " left";
                    }
                    break;
                case "giant stick":
                    if (stick > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - stick;
                        msg = "You buy the giant stick and have $" + wallet + " left";
                    }
                    break;
                case "t-shirt":
                    if (shirt > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - shirt;
                        msg = "You buy the t-shirt and have $" + wallet + " left";
                    }
                    break;
                case "sweater":
                    if (sweater > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - sweater;
                        msg = "You buy the sweater and have $" + wallet + " left";
                    }
                    break;
                case "backpack":
                    if (backpack > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - backpack;
                        msg = "You buy the backpack and have $" + wallet + " left";
                    }
                    break;
                case "xbox 720":
                    if (backpack > wallet) {
                        System.out.println("You cannot afford it; you only have $" + wallet);
                    }
                    else {
                        wallet = wallet - backpack;
                        msg = "You buy the Xbox, becoming the single most powerful person in the universe. All bow to your power.";
                    }
                    break;
                case "rob":
                    wallet = wallet + 536;
                        System.out.println("'PUT THE MONEY IN THE BAG'\nYou steal $536 and now have $" + wallet + ".");
                    break;
                case "a human child":
                    msg = "You attempt to buy a child from her mother.\nThe poilce arrive and you are arrested.";
                    System.exit(0);
                    break;
                default : msg = "You flail helplessly with indecision.";
            }
            System.out.println(msg);
        }
    }


}
