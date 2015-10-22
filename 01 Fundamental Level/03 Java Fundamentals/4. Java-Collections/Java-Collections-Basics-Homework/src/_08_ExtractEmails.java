import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _08_ExtractEmails {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();

        String stringPattern = "[\\w\\.-]+@[a-zA-Z\\.-]+\\.[a-zA-z]+";
        Pattern pattern = Pattern.compile(stringPattern);

        Matcher matcher = pattern.matcher(text);

        while (matcher.find()) {
            System.out.println(matcher.group());
        }
    }
}