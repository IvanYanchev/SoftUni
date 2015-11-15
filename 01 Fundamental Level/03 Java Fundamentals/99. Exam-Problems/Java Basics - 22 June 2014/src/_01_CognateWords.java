import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _01_CognateWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        ArrayList<String> words = new ArrayList<>();
        ArrayList<String> setOfWords = new ArrayList<>();

        String input = scanner.nextLine();

        String stringPattern = "[a-zA-Z]+";

        Pattern pattern = Pattern.compile(stringPattern);
        Matcher matcher = pattern.matcher(input);

        while (matcher.find()) {
            words.add(matcher.group());
        }

        boolean isFound = false;

        for (int i = 0; i < words.size(); i++) {
            for (int j = 0; j < words.size(); j++) {
                for (int k = 0; k < words.size(); k++) {
                    if (i != j && i != k && j != k) {
                        String leftSide = words.get(i) + words.get(j);
                        String rightSide = words.get(k);

                        if (leftSide.equals(rightSide)) {
                            String set = String.format("%s|%s=%s", words.get(i), words.get(j), words.get(k));
                            if (!setOfWords.contains(set)) {
                                System.out.println(set);
                                setOfWords.add(set);
                                isFound = true;
                            }
                        }
                    }
                }
            }
        }

        if (!isFound) {
            System.out.println("No");
        }
    }
}