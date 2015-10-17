import java.util.Scanner;
import java.util.TreeMap;

public class _04_LogsAggregator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        TreeMap<String, TreeMap<String, Integer>> logs = new TreeMap<>();

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            String[] input = scanner.nextLine().split(" ");
            String ip = input[0];
            String user = input[1];
            int duration = Integer.parseInt(input[2]);

            if (!logs.containsKey(user)) {
                logs.put(user, new TreeMap<>());
                logs.get(user).put(ip, duration);
            } else if (!logs.get(user).containsKey(ip)) {
                logs.get(user).put(ip, duration);
            } else {
                logs.get(user).put(ip, logs.get(user).get(ip) + duration);
            }
        }

        for (String user : logs.keySet()) {
            int totalDuration = 0;
            for (String ip : logs.get(user).keySet()) {
                totalDuration += logs.get(user).get(ip);
            }
            System.out.printf("%s: %d ", user, totalDuration);
            System.out.println(logs.get(user).keySet());
        }
    }
}