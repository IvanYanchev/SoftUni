import java.util.Scanner;

public class _05_CountAllWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split("[^a-zA-Z]");

        int wordsCount = 0;

        for (int i = 0; i < input.length; i++) {

            String s = input[i];

            if (!s.isEmpty()) {
                wordsCount++;
            }
        }
        System.out.println(wordsCount);
    }
}