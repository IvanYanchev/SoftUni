import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;

public class _02_SumCards {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String hand = scanner.nextLine();
        String[] cards = hand.split(" ");
        String[] cardsFaces = new String[cards.length];

        for (int i = 0; i < cards.length; i++) {
            String cardFace = cards[i].substring(0, cards[i].length() - 1);
            cardsFaces[i] = cardFace;
        }
        int sum = 0;
        for (int i = 0; i < cardsFaces.length; i++) {
            int multiplyer = 1;
            if ((i - 1 >= 0 && cardsFaces[i - 1].equals(cardsFaces[i])) ||
                    (i + 1 < cardsFaces.length && cardsFaces[i + 1].equals(cardsFaces[i]))) {
                multiplyer = 2;
            }
            sum += valueOfCard(cardsFaces[i]) * multiplyer;
        }

        System.out.println(sum);
    }

    private static int valueOfCard(String cardsFace) {
        String[] colode = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "J", "Q", "K", "A"};
        for (int i = 0; i < colode.length; i++) {
            if (cardsFace.equals(colode[i])) {
                return i;
            }
        }

        return -1;
    }
}