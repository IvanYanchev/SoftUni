import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class _13_FilterArray {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] words = scanner.nextLine().split(" ");

        Arrays.stream(words).filter(s -> s.length() > 3).forEach(System.out::println);

        //List<String> filteredWords = Arrays.stream(words).filter(s -> s.length() > 3).collect(Collectors.toList());

    }
}