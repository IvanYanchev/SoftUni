package _02_1LvShop.Products;

import _02_1LvShop.Enums.AgeRestriction;

public class Appliance extends ElectonicsProduct {

    public Appliance(String name, double price, int quantity, AgeRestriction ageAgeRestriction) {
        super(name, price, quantity, ageAgeRestriction, 6);
    }

    @Override
    public double getPrice() {
        if (this.getQuantity() < 50) {
            return this.getPrice() * 1.05;
        } else {
            return this.getPrice();
        }
    }
}