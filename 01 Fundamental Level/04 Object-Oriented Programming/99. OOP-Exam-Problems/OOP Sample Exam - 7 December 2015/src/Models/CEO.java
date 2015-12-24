package Models;

import java.util.Scanner;

public class CEO extends Employee{
    private double salary;


    public CEO(String firstName, String lastName, double salary) {
        super(firstName, lastName);
        this.setSalary(salary);
    }

    public double getSalary() {
        return salary;
    }

    public void setSalary(double salary) {
        if (salary <= 0) {
            throw new IllegalArgumentException("The salary cannot be zero or negative number");
        }
        this.salary = salary;
    }

    @Override
    public void ReceivePayment(double salary) {

    }
}