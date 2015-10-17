import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _04_OfficeStuff {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        TreeMap<String, LinkedHashMap<String, Integer>> orders = new TreeMap<>();

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            String str = scanner.nextLine();
            String patternString = "\\|(\\w+) - (\\d+) - (\\w+)\\|";
            Pattern pattern = Pattern.compile(patternString);
            Matcher matcher = pattern.matcher(str);

            if (matcher.find()) {
                String company = matcher.group(1);
                int amount = Integer.parseInt(matcher.group(2));
                String product = matcher.group(3);

                if (!orders.containsKey(company)) {
                    orders.put(company, new LinkedHashMap<>());
                    orders.get(company).put(product, amount);
                } else if (!orders.get(company).containsKey(product)) {
                    orders.get(company).put(product, amount);
                } else {
                    orders.get(company).put(product, orders.get(company).get(product) + amount);
                }
            }
        }

        for (String company : orders.keySet()) {
            System.out.printf("%s: ", company);
            int index = 0;
            for (String product : orders.get(company).keySet()) {
                System.out.printf("%s-%s", product, orders.get(company).get(product));
                if (index < orders.get(company).size() - 1) {
                    System.out.print(", ");
                }
                index++;
            }
            System.out.println();
        }
    }
}