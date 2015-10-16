import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.*;

public class _02DragonAccounting {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scanner = new Scanner(System.in);

        ArrayList<BigDecimal[]> employees = new ArrayList<BigDecimal[]>();

        BigDecimal initialCapital = new BigDecimal(scanner.nextLine());

        int day = 1;

        while (true) {
            String inputLine = scanner.nextLine();

            if (inputLine.equals("END")) {
                break;
            }

            String[] arguments = inputLine.split(";");
            BigDecimal hired = new BigDecimal(arguments[0]);
            long fired = new BigDecimal(arguments[1]).longValue();
            BigDecimal salary = new BigDecimal(arguments[2]);

            //hire employees

            employees.add(new BigDecimal[] {hired, salary});

            //check for raise

            //give salaries

            if (day % 30 == 0) {
                for (int k = 0; k < employees.size(); k++) {
                    BigDecimal[] employee = employees.get(k);
                    int startDay = k;
                    int totalWorkDays = day - startDay;
                    int totalWorkYears = totalWorkDays / 365;

                    int workDaysThisMonth = 30;
                    if (totalWorkDays / 30 == 0) {
                        workDaysThisMonth = totalWorkDays % 30;
                    }
                    BigDecimal countEmployees = employee[0];
                    BigDecimal baseSalaryPerDay = employee[1].divide(new BigDecimal("30"), 20, RoundingMode.HALF_UP);
                    BigDecimal increase = new BigDecimal(1).add(new BigDecimal("0.006").multiply(new BigDecimal(totalWorkYears)));
                    BigDecimal salaryPerDay = baseSalaryPerDay.multiply(increase);
                    BigDecimal monthlyPaymentForSalaries = new BigDecimal(workDaysThisMonth).multiply(countEmployees.multiply(salaryPerDay)).setScale(20, RoundingMode.HALF_UP);
                    initialCapital = initialCapital.subtract(monthlyPaymentForSalaries);
                }
            }

            //fire employees

            int index = 0;
            while (fired > 0 && index < employees.size()) {
                int countOldestEmployees = employees.get(index)[0].intValue();
                BigDecimal salaryOldestEmployees = employees.get(index)[1];

                if (countOldestEmployees >= fired) {
                    countOldestEmployees -= fired;
                    fired = 0;
                } else {
                    fired -= countOldestEmployees;
                    countOldestEmployees = 0;
                }
                employees.set(index, new BigDecimal[]{new BigDecimal(countOldestEmployees), salaryOldestEmployees});
                index++;
            }

            //check for additional income/expense

            for (int i = 3; i < arguments.length; i++) {
                String[] additional = arguments[i].split(":");
                BigDecimal money = new BigDecimal(additional[1]);

                switch (additional[0]) {
                    case "Previous years deficit":
                    case "Machines":
                    case "Taxes":
                        initialCapital = initialCapital.subtract(money);
                        break;
                    case "Product development":
                    case "Unconditional funding":
                        initialCapital = initialCapital.add(money);
                        break;
                }
            }

            //check for bankruptcy

            if (initialCapital.compareTo(new BigDecimal("0")) < 0) {
                System.out.printf("BANKRUPTCY: %s", BigDecimalForOutput(initialCapital));
                return;
            }

            day++;
        }

        int employeesLeft = 0;
        for (int k = 0; k < employees.size(); k++) {
            BigDecimal[] employee = employees.get(k);
            int countEmployees = employee[0].intValue();
            employeesLeft += countEmployees;
        }

        System.out.printf("%d %s", employeesLeft, BigDecimalForOutput(initialCapital));
    }

    public static String BigDecimalForOutput (BigDecimal capital) {
        String currentCapital = capital.abs().toString();
        int dotIndex = currentCapital.indexOf('.');
        String capitalForOutput = currentCapital.substring(0, dotIndex + 5);

        return  capitalForOutput;
    }
}