import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _02_SoftUniDefenseSystem {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double total = 0;

        String patternString = "([A-Z][a-z]+).*?([A-Z][a-zA-Z]*[A-Z]).*?(\\d+)L";
        Pattern pattern = Pattern.compile(patternString);

        String input;

        while (!(input = scanner.nextLine()).equals("OK KoftiShans")) {
            Matcher matcher = pattern.matcher(input);
            while (matcher.find()) {
                String guest = matcher.group(1);
                String drink = matcher.group(2).toLowerCase();
                int quantity = Integer.parseInt(matcher.group(3));

                total += 0.001 * quantity;

                System.out.printf("%s brought %d liters of %s!\n", guest, quantity, drink);
            }
        }

        System.out.printf("%.3f softuni liters", total);
    }
}