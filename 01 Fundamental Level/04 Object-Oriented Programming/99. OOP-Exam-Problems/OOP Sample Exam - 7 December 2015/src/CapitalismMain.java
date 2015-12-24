import Contracts.InputReadable;
import Contracts.OutputWriteable;
import IO.ConsoleReader;
import IO.ConsoleWriter;
import Models.Company;
import Models.Department;
import Models.Employee;

import java.util.ArrayList;
import java.util.List;

public class CapitalismMain {

    private static List<Company> companies = new ArrayList<>();

    public static void main(String[] args) {

        InputReadable reader = new ConsoleReader();
        OutputWriteable writer = new ConsoleWriter();

        while (true) {
            String input = reader.read();

            if (input.equals("end")) {
                return;
            }

            String[] commandArguments = input.split(" ");

            switch (commandArguments[0]) {
                case "create-company" :
                    try {
                        createCompany(commandArguments);
                    } catch (Exception e) {
                        writer.write(e.getMessage());
                    }
                    break;
                case "create-department" :
                    break;
                case "create-employee" :
                    break;
                case "pay-salaries":
                    break;
                case "show-employees" :
                    break;
            }
        }
    }

    private static void createCompany(String[] commandArguments) throws Exception {
        String companyName = commandArguments[1];
        String ceoFirstName = commandArguments[2];
        String ceoLastName = commandArguments[3];
        double salary = Double.parseDouble(commandArguments[4]);

        Company company = findCompanyByName(companyName);

        if (company != null) {
            throw new Exception(String.format("Company %s already exists", companyName));
        }

        Department department = null;

        Employee employee = company.findEmployeeByName(ceoFirstName, ceoLastName);

        if (employee == null) {
            createEmployee(ceoFirstName, ceoLastName, "CEO", company, department);
        }
    }

    private static void createEmployee(String[] commandArguments) {
        String firstName = commandArguments[1];
        String lastName = commandArguments[2];
        String position = commandArguments[3];
        String companyName = commandArguments[4];

        if (commandArguments.length > 5) {
            String departmentName = commandArguments[5];
        }
    }

    private static void createEmployee(String firstName, String lastName, String position, Company company, Department department) {

    }

    private static Company findCompanyByName(String name) {

        for (Company company:
             companies) {
            if (company.getName().equals(name)) {
                return company;
            }
        }

        return null;
    }

    private static Department findDepartmentByName(String name, Company company) {

        for (Department department : company.getDepartments()) {
            if (department.getName().equals(name)) {
                return department;
            }
        }

        return null;
    }
}