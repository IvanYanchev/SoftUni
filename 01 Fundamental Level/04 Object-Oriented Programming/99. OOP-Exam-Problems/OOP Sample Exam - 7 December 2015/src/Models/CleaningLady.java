package Models;

import Contracts.Payable;

public class CleaningLady extends Employee {

    public CleaningLady(String firstName, String lastName) {
        super(firstName, lastName);
    }

    @Override
    public void ReceivePayment(double salary) {

    }
}