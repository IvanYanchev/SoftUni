import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.*;

public class _02DragonAccounting {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scanner = new Scanner(System.in);

        ArrayList<BigDecimal[]> employees = new ArrayList<>();

        BigDecimal initialCapital = new BigDecimal(scanner.nextLine());

        int day = 1;
        int indexOldestEmployees = 0;

        while (true) {
            String inputLine = scanner.nextLine();

            if (inputLine.equals("END")) {
                break;
            }

            String[] arguments = inputLine.split(";");
            BigDecimal hired = new BigDecimal(arguments[0]);
            long fired = Long.parseLong(arguments[1]);
            BigDecimal salary = new BigDecimal(arguments[2]);

            //hire employees

            employees.add(new BigDecimal[]{hired, salary});


            for (int k = 0; k < employees.size(); k++) {

                BigDecimal countCurrentEmpl = employees.get(k)[0];
                BigDecimal salaryCurrentEmpl = employees.get(k)[1];

                if (countCurrentEmpl.compareTo(new BigDecimal(0)) > 0) {
                    int startDay = k;
                    int totalWorkDays = day - startDay;

                    //check for raise

                    if (totalWorkDays % 365 == 0) {

                        BigDecimal increase = new BigDecimal("1.006");
                        salaryCurrentEmpl = salaryCurrentEmpl.multiply(increase);
                        employees.set(k, new BigDecimal[]{countCurrentEmpl, salaryCurrentEmpl});
                    }

                    //give salaries

                    if (day % 30 == 0) {

                        int workDaysThisMonth = 30;

                        if (totalWorkDays / 30 == 0) {
                            workDaysThisMonth = totalWorkDays % 30;
                        }

                        BigDecimal salaryPerDay = salaryCurrentEmpl.divide(new BigDecimal(30), 9, RoundingMode.UP).setScale(7, BigDecimal.ROUND_DOWN);
                        BigDecimal monthlyPaymentForSalaries = new BigDecimal(workDaysThisMonth).multiply(countCurrentEmpl.multiply(salaryPerDay));
                        initialCapital = initialCapital.subtract(monthlyPaymentForSalaries);
                    }
                }
            }

            //fire employees

            while (fired > 0) {
                long countOldestEmployees = employees.get(indexOldestEmployees)[0].longValue();
                BigDecimal salaryOldestEmployees = employees.get(indexOldestEmployees)[1];

                if (countOldestEmployees > fired) {
                    countOldestEmployees = countOldestEmployees - fired;
                    employees.set(indexOldestEmployees, new BigDecimal[]{new BigDecimal(countOldestEmployees), salaryOldestEmployees});
                    fired = 0;
                } else if (countOldestEmployees == fired) {
                    countOldestEmployees = countOldestEmployees - fired;
                    employees.set(indexOldestEmployees, new BigDecimal[]{new BigDecimal(countOldestEmployees), salaryOldestEmployees});
                    fired = 0;
                    indexOldestEmployees++;
                } else {
                    fired = fired - countOldestEmployees;
                    countOldestEmployees = 0;
                    employees.set(indexOldestEmployees, new BigDecimal[]{new BigDecimal(countOldestEmployees), salaryOldestEmployees});
                    indexOldestEmployees++;
                }
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

        long employeesLeft = 0;
        for (int k = 0; k < employees.size(); k++) {
            BigDecimal[] employee = employees.get(k);
            long countEmployees = employee[0].longValue();
            employeesLeft += countEmployees;
        }

        System.out.printf("%d %s", employeesLeft, BigDecimalForOutput(initialCapital));
    }

    public static String BigDecimalForOutput(BigDecimal capital) {
        String currentCapital = capital.abs().toString();
        int dotIndex = currentCapital.indexOf('.');
        String capitalForOutput = currentCapital.substring(0, dotIndex + 5);

        return capitalForOutput;
    }
}