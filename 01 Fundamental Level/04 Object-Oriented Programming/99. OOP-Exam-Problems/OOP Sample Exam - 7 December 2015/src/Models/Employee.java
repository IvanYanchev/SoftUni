package Models;

import Contracts.Payable;

import java.util.Scanner;

public abstract class Employee implements Payable {
    private String firstName;
    private String lastName;
    private Company company;
    private Department department;
    private double savings;

    public Employee(String firstName, String lastName) {
        this.setFirstName(firstName);
        this.setLastName(lastName);
    }

    public String getFirstName() {
        return this.firstName;
    }

    private void setFirstName(String firstName) {
        if (firstName.isEmpty()) {
            throw new IllegalArgumentException("The first name cannot be empty string");
        }
        this.firstName = firstName;
    }

    public String getLastName() {
        return this.lastName;
    }

    private void setLastName(String lastName) {
        if (firstName.isEmpty()) {
            throw new IllegalArgumentException("The last name cannot be empty string");
        }
        this.lastName = lastName;
    }
}