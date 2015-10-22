import java.util.Scanner;

public class _06_CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split("[^a-zA-Z]");

        String specifiedWord = scanner.nextLine();

        int wordsCount = 0;

        for (int i = 0; i < input.length; i++) {

            String s = input[i];

            if (s.equalsIgnoreCase(specifiedWord)) {
                wordsCount++;
            }
        }
        System.out.println(wordsCount);
    }
}