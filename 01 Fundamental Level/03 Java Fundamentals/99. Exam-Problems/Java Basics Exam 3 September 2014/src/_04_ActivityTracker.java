import java.util.*;

public class _04_ActivityTracker {

    public static void main(String[] args) {
        TreeMap<Integer, TreeMap<String, Integer>> map = new TreeMap<>();

        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < n; i++) {
            String[] input = scanner.nextLine().split(" ");
            String[] date = input[0].split("/");
            int month = Integer.parseInt(date[1]);

            String user = input[1];

            int distance = Integer.parseInt(input[2]);

            if (!map.containsKey(month)) {
                map.put(month, new TreeMap<>());
                map.get(month).put(user, distance);
            } else if (!map.get(month).containsKey(user)) {
                map.get(month).put(user, distance);
            } else {
                map.get(month).put(user, map.get(month).get(user) + distance);
            }
        }

        for (int month : map.keySet()) {
            System.out.printf("%d: ", month);
            int count = map.get(month).size();
            for (String user : map.get(month).keySet()) {
                System.out.printf("%s(%d)", user, map.get(month).get(user));
                if (count > 1) {
                    System.out.printf(", ");
                }
                count--;
            }
            System.out.println();
        }
    }
}