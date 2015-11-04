package _02_1LvShop.Products;


import _02_1LvShop.Enums.AgeRestriction;

public abstract class ElectonicsProduct extends Product {
    private int guaranteePeriod;

    public ElectonicsProduct(String name, double price, int quantity, AgeRestriction ageAgeRestriction, int guaranteePeriod) {
        super(name, price, quantity, ageAgeRestriction);
        this.setGuaranteePeriod(guaranteePeriod);
    }

    public int getGuaranteePeriod() {
        return guaranteePeriod;
    }

    public void setGuaranteePeriod(int guaranteePeriod) {
        if (guaranteePeriod < 0) {
            throw new IllegalArgumentException("The guarantee period can not be negative number");
        } else {
            this.guaranteePeriod = guaranteePeriod;
        }
    }
}