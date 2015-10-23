import java.util.*;
import java.util.stream.Collectors;

public class _14_SortArrayWithStreamAPI {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] elementsAsString = scanner.nextLine().split(" ");

        String order = scanner.nextLine();

        List<Integer> list = new ArrayList<Integer>();

        for (int i = 0; i < elementsAsString.length; i++) {
            list.add(Integer.parseInt(elementsAsString[i]));
        }

        switch (order) {
            case "Ascending":
                Collections.sort(list);
                break;
            case "Descending":
                Collections.sort(list);
                Collections.reverse(list);
                break;
        }

        System.out.println(list);
    }
}