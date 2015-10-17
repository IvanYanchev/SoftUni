import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;

public class _01_Pyramid {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        List<Integer> growingSequence = new LinkedList<>();
        int prevElement = Integer.MIN_VALUE;

        for (int i = 0; i < n; i++) {
            String pyramidLine = scanner.nextLine();
            String[] lineElements = pyramidLine.split("\\s+");
            int closestBiggerElement = Integer.MAX_VALUE;

            for (int j = 0; j < lineElements.length; j++) {
                if (isParsable(lineElements[j])) {
                    int element = Integer.parseInt(lineElements[j]);

                    if (element> prevElement && element < closestBiggerElement) {
                        closestBiggerElement = element;
                    }
                }

            }
            if (closestBiggerElement != Integer.MAX_VALUE) {
                growingSequence.add(closestBiggerElement);
                prevElement = closestBiggerElement;
            }
        }
        printList(growingSequence);
    }

    private static boolean isParsable(String str) {
        try {
            Integer.parseInt(str);
            return true;
        } catch (Exception exep) {
            return false;
        }
    }

    private static void printList(List<Integer> list) {
        for (int i = 0; i < list.size(); i++) {
            System.out.print(list.get(i));
            if (i < list.size() - 1) {
                System.out.print(", ");
            }
        }
    }
}