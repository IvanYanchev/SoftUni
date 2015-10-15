import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _11StartsAndEndsWithCapitalLetter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String patternString = "[A-Z][a-zA-Z]{0,}[A-Z]";
        Pattern pattern = Pattern.compile(patternString);

        String[] array = scanner.nextLine().split(" ");

        for (int i = 0; i < array.length; i++) {
            Matcher matcher = pattern.matcher(array[i]);

            if (matcher.matches()) {
                System.out.print(matcher.group() + " ");
            }
        }
    }
}
