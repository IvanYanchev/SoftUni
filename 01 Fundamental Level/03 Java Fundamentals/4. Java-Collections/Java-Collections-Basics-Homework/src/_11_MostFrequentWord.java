import java.util.ArrayList;
import java.util.Scanner;
import java.util.TreeMap;

public class _11_MostFrequentWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        TreeMap<String, Integer> dict = new TreeMap<>();

        String text = scanner.nextLine();
        String[] allWords = text.split("[^a-zA-Z]");

        for (int i = 0; i < allWords.length; i++) {
            String word = allWords[i].toLowerCase();

            if (!word.isEmpty()){
                if (!dict.containsKey(word)) {
                    dict.put(word, 1);
                } else {
                    dict.put(word, dict.get(word) + 1);
                }
            }
        }

        int maxCount = 0;
        ArrayList<String> wordsList = new ArrayList<>();

        for (String word : dict.keySet()) {
            if (dict.get(word) > maxCount) {
                maxCount = dict.get(word);
                wordsList.clear();
                wordsList.add(word);
            } else if (dict.get(word) == maxCount) {
                wordsList.add(word);
            }
        }

        for (int i = 0; i < wordsList.size(); i++) {
            System.out.printf("%s -> %d times%n", wordsList.get(i), maxCount);
        }
    }
}