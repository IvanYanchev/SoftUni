import java.math.BigDecimal;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _03_SimpleExpression {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String expression = scanner.nextLine();

        BigDecimal result = new BigDecimal("0");

        String stringPatternNextOperand = "([+-])?\\s*((\\d+\\.)?\\d+)";
        Pattern patternNextOperand = Pattern.compile(stringPatternNextOperand);
        Matcher matcherNextOperand = patternNextOperand.matcher(expression);

        while (matcherNextOperand.find()) {

            BigDecimal nextOperand = new BigDecimal(matcherNextOperand.group(2));

            String operator = "+";
            if (matcherNextOperand.group(1) != null) {
                operator = matcherNextOperand.group(1);
            }

            switch (operator) {
                case "-":
                    result = result.subtract(nextOperand);
                    break;
                case "+":
                    result = result.add(nextOperand);
                    break;

            }
        }

        System.out.printf("%.9f", result);
    }
}