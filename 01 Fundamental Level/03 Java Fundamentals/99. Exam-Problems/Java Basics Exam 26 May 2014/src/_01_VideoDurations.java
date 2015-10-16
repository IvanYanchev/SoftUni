import java.util.Scanner;

public class _01_VideoDurations {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int totalMinutes = 0;

        while (true) {
            String input = scanner.nextLine();
            if (input.equals("End")) {
                break;
            }

            String[] duration = input.split(":");

            int hours = Integer.parseInt(duration[0]);
            int minutes = Integer.parseInt(duration[1]);
            totalMinutes += hours * 60 + minutes;
        }

        int resultHours = totalMinutes / 60;
        int resultMinutes = totalMinutes % 60;

        System.out.format("%d:%02d", resultHours, resultMinutes);
    }
}