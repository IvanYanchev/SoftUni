import java.util.Scanner;

public class _01_CountBeers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input;
        int totalBeers = 0;

        while (!(input = scanner.nextLine()).equals("End")) {

            String[] arguments = input.split(" ");
            int count = Integer.parseInt(arguments[0]);
            String measure = arguments[1];

            if (measure.equals("beers")) {
                totalBeers += count;
            } else {
                totalBeers += count * 20;
            }
        }

        System.out.printf("%d stacks + %d beers", totalBeers / 20, totalBeers % 20);
    }
}