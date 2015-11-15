import java.util.Scanner;

public class _01_SoftUniPalatkaConf {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int numberOfPeople = Integer.parseInt(scanner.nextLine());

        int n = Integer.parseInt(scanner.nextLine());

        int beds = 0;
        int meals = 0;

        for (int i = 0; i < n; i++) {
            String[] inputArgs = scanner.nextLine().split(" ");
            int quantity = Integer.parseInt(inputArgs[1]);
            String type = inputArgs[2];

            switch (inputArgs[0]) {
                case "tents":
                    if (type.equals("normal")) {
                        beds += quantity * 2;
                    } else {
                        beds += quantity * 3;
                    }
                    break;
                case "rooms":
                    if (type.equals("single")) {
                        beds += quantity * 1;
                    } else if (type.equals("double")) {
                        beds += quantity * 2;
                    } else {
                        beds += quantity * 3;
                    }
                    break;
                case "food":
                    if (type.equals("musaka")) {
                        meals += quantity * 2;
                    }
                    break;
            }
        }

        if (beds >= numberOfPeople) {
            System.out.printf("Everyone is happy and sleeping well. Beds left: %d\n", beds - numberOfPeople);
        } else {
            System.out.printf("Some people are freezing cold. Beds needed: %d\n", numberOfPeople - beds);
        }

        if (meals >= numberOfPeople) {
            System.out.printf("Nobody left hungry. Meals left: %d\n", meals - numberOfPeople);
        } else {
            System.out.printf("People are starving. Meals needed: %d\n", numberOfPeople - meals);
        }
    }
}