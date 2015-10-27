import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _02_WeirdScript {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        int keyNumber = n % 52;
        if (keyNumber == 0) {
            keyNumber = 52;
        }
        char keyLetter;

        if (keyNumber <= 26) {
            keyLetter = (char)(keyNumber + 96);
        } else {
            keyLetter = (char)(keyNumber + 38);
        }

        String key = "" + keyLetter + keyLetter;

        String patternString = key + "(.*?)" + key;
        Pattern pattern = Pattern.compile(patternString);

        StringBuilder sb= new StringBuilder();
        while (true) {
            String input = scanner.nextLine();
            if (input.equals("End")) {
                break;
            }

            sb.append(input);
        }

        Matcher matcher = pattern.matcher(sb);

        while (matcher.find()) {
            System.out.println(matcher.group(1));
        }
    }
}