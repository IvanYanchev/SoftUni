import java.util.Scanner;

public class _07_CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();
        String substring = scanner.nextLine();

        int substringCount = 0;

        for (int i = 0; i < text.length() - substring.length() + 1; i++) {
            String s = text.substring(i, i + substring.length());
            if (substring.equalsIgnoreCase(s)) {
                substringCount++;
            }
        }

        System.out.println(substringCount);
    }
}