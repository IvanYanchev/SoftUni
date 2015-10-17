import java.util.Arrays;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _02_TerroristsWin {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String string = scanner.nextLine();
        String resultString = new String(string);

        String patternString = "\\|(.*?)\\|";
        Pattern pattern = Pattern.compile(patternString);
        Matcher matcher = pattern.matcher(resultString);

        while (matcher.find()) {
            String bomb = matcher.group(0);
            String bombBody = matcher.group(1);
            int bombPower = 0;
            for (int i = 0; i < bombBody.length(); i++) {
                bombPower += bombBody.charAt(i);
            }
            bombPower %= 10;
            int startIndex = string.indexOf(bomb);
            int endIndex = startIndex + bomb.length() - 1;
            int destroyedLeft = Math.min(bombPower, startIndex - 0);
            int destroyedRight = Math.min(bombPower, string.length() - 1 - endIndex);
            startIndex -= bombPower;
            endIndex += bombPower;

            char[] repeat = new char[bomb.length() + 2 + destroyedLeft + destroyedRight];
            Arrays.fill(repeat, '.');
            String destroyedString = new String(repeat);

            String survivedStringLeft = resultString.substring(0, Math.max(0, startIndex));

            String survivedStringRight = "";
            if (endIndex < string.length()) {
                survivedStringRight = resultString.substring(endIndex + 1);
            }

            resultString = survivedStringLeft + destroyedString + survivedStringRight;
        }
        System.out.println(resultString);
    }
}