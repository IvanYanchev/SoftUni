import java.util.HashSet;
import java.util.Scanner;
import java.util.SortedSet;
import java.util.TreeSet;
import java.util.stream.Collector;
import java.util.stream.Collectors;

public class _10_ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        TreeSet<String> dict = new TreeSet<>();

        String[] words = scanner.nextLine().split("[^a-zA-Z]");

        for (int i = 0; i < words.length; i++) {

            String word = words[i];
            if (!word.isEmpty()) {
                dict.add(word.toLowerCase());
            }
        }

        String wordsInAlphabeticalOrder = dict.stream()
                .collect(Collectors.joining(" "));

        System.out.println(wordsInAlphabeticalOrder);
    }
}