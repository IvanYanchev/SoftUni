import java.util.LinkedHashMap;
import java.util.Scanner;

public class _12_CardsFrequencies {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        LinkedHashMap<String, Integer> lhm = new LinkedHashMap<>();

        String[] cards = scanner.nextLine().split(" ");

        for (int i = 0; i < cards.length; i++) {
            String cardFace = cards[i].substring(0, cards[i].length() - 1);

            if (!lhm.containsKey(cardFace)) {
                lhm.put(cardFace, 1);
            } else {
                lhm.put(cardFace, lhm.get(cardFace) + 1);
            }
        }

        for (String cardFace : lhm.keySet()) {
            double percent =  100 * (double) lhm.get(cardFace) / (double) cards.length;
            System.out.format("%s -> %.2f%s", cardFace, percent, "%");
            System.out.format("%n");
        }
    }
}