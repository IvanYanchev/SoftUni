import java.util.ArrayList;
import java.util.Scanner;

public class _03_LongestOddEvenSequence {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] elements = scanner.nextLine().split("[() ]+");
        ArrayList<Integer> numbers = new ArrayList<>();

        for (int i = 0; i < elements.length; i++) {
            if (!elements[i].equals("")) {
                numbers.add(Integer.parseInt(elements[i]));
            }
            ;
        }

        int count = 1;
        int maxCount = 1;

        for (int i = 0; i < numbers.size() - 1; i++) {
            int previousElement = 0;
            if (i >= 1) {
                previousElement = numbers.get(i - 1);
            }
            int currentElement = numbers.get(i);
            int nextElement = numbers.get(i + 1);

            if (nextElement == 0 ||
                    (currentElement == 0 && Math.abs(nextElement + previousElement) % 2 == 0) ||
                    (Math.abs(currentElement + nextElement) % 2 == 1)) {
                count++;
                if (count > maxCount) {
                    maxCount = count;
                }
            } else {
                count = 1;
            }
        }

        System.out.println(maxCount);
    }
}