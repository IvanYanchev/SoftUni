package _02_1LvShop.Products;

import _02_1LvShop.Enums.AgeRestriction;
import _02_1LvShop.Interfaces.Expirable;

import java.util.Date;

public class FoodProduct extends Product implements Expirable {
    private Date expirationDate;

    public FoodProduct(String name, double price, int quantity, AgeRestriction ageAgeRestriction, Date expirationDate) {
        super(name, price, quantity, ageAgeRestriction);
        this.setExpirationDate(expirationDate);
    }

    @Override
    public Date getExpirationDate() {
        return this.expirationDate;
    }

    public void setExpirationDate(Date expirationDate) {
        this.expirationDate = expirationDate;
    }

    @Override
    public double getPrice() {
        Date now = new Date();

        if (this.getExpirationDate().getDate() - now.getDate() < 15) {
            return super.getPrice() * 0.7;
        } else {
            return super.getPrice();
        }
    }
}