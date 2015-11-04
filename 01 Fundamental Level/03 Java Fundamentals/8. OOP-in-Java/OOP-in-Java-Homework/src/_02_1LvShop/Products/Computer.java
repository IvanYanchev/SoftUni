package _02_1LvShop.Products;

import _02_1LvShop.Enums.AgeRestriction;

public class Computer extends ElectonicsProduct {

    public Computer(String name, double price, int quantity, AgeRestriction ageAgeRestriction) {
        super(name, price, quantity, ageAgeRestriction, 24);
    }

    @Override
    public double getPrice() {
        if (this.getQuantity() > 1000) {
            return this.getPrice() * 0.95;
        } else {
            return this.getPrice();
        }
    }
}