import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class _04_Orders {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        LinkedHashMap<String, TreeMap<String, Integer>> orders = new LinkedHashMap<String, TreeMap<String, Integer>>();

        for (int i = 0; i < n; i++) {
            String[] input = scanner.nextLine().split(" ");

            String customer = input[0];
            int amount = Integer.parseInt(input[1]);
            String product = input[2];

            if (!orders.containsKey(product)) {
                orders.put(product, new TreeMap<>());
            }
            if (!orders.get(product).containsKey(customer)) {
                orders.get(product).put(customer, amount);
            } else {
                orders.get(product).put(customer, orders.get(product).get(customer) + amount);
            }
        }

        for (String product : orders.keySet()) {
            System.out.printf("%s: ", product);

            int index = 0;

            for (String customer : orders.get(product).keySet()) {
                System.out.printf("%s %d", customer, orders.get(product).get((customer)));
                if (index < orders.get(product).size() - 1){
                    System.out.printf(", ");
                }
                index++;
            }
            System.out.println();
        }
    }
}