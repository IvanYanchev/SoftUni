import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _03_LargestThreeRectangles {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Integer> rectangleArea = new ArrayList<>();

        String input = scanner.nextLine();

        String patternString = "\\[\\s*(\\d+)\\s*x\\s*(\\d+)\\s*\\]";
        Pattern pattern = Pattern.compile(patternString);
        Matcher matcher = pattern.matcher(input);

        while (matcher.find()) {
            int sizeA = Integer.parseInt(matcher.group(1));
            int sizeB = Integer.parseInt(matcher.group(2));
            int area = sizeA * sizeB;
            rectangleArea.add(area);
        }

        int maxSum = 0;
        for (int i = 0; i < rectangleArea.size() - 2; i++) {
            int sum = rectangleArea.get(i) + rectangleArea.get(i+1) + rectangleArea.get(i+2);

            if (sum >= maxSum) {
                maxSum = sum;
            }
        }

        System.out.println(maxSum);
    }
}