import java.lang.reflect.Array;
import java.util.*;
import java.util.stream.IntStream;

public class _04_CouplesFrequency {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        String[] numbers = scanner.nextLine().split(" ");
        HashMap<String, Integer> couples = new LinkedHashMap<>();

        for (int i = 0; i < numbers.length - 1; i++) {
            String couple = String.format("%s %s", numbers[i], numbers[i+1]);
            int count = 1;
            if (couples.containsKey(couple)) {
                count = couples.get(couple) + 1;
            }
            couples.put(couple, count);
        }

        int total = 0;
        for (String str : couples.keySet()) {
            total += couples.get(str);
        }

        for (String str : couples.keySet()) {
            int count = couples.get(str);
            double occurence = (double)count / (double)total;
            System.out.printf("%s -> %.2f%c", str, occurence * 100, '%');
            System.out.println();
        }
    }
}