import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _10ExtractWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String patternString = "[a-zA-Z]{2,}";
        Pattern pattern = Pattern.compile(patternString);

        Matcher matcher = pattern.matcher(scanner.nextLine());

        while (matcher.find()) {
            System.out.print(matcher.group() + " ");
        }
    }
}
