package Models;

import Contracts.Payable;

import java.util.ArrayList;
import java.util.List;

public class Company {
    private String name;
    private CEO ceo;
    private List<Payable> employees;
    private List<Department> departments;

    public Company(String name, CEO ceo) {
        this.setName(name);
        this.setCeo(ceo);
        this.employees = new ArrayList<>();
        this.departments = new ArrayList<>();
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public CEO getCeo() {
        return ceo;
    }

    private void setCeo(CEO ceo) {
        this.ceo = ceo;
    }

    public List<Payable> getEmployees() {
        return employees;
    }

    public void setEmployees(List<Payable> employees) {
        this.employees = employees;
    }

    public List<Department> getDepartments() {
        return departments;
    }

    public void setDepartments(List<Department> departments) {
        this.departments = departments;
    }

    public Employee findEmployeeByName(String firstName, String lastName) {

        for (Payable payable :
             this.getEmployees()) {
            Employee employee = (Employee)payable;
            if (employee.getFirstName().equals(firstName) && employee.getLastName().equals(lastName)) {
                return employee;
            }
        }

        return null;
    }
}