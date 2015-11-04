package _02_1LvShop.Manager;

import _02_1LvShop.Customer.Customer;
import _02_1LvShop.Enums.AgeRestriction;
import _02_1LvShop.Exceptions.AgeRestrictionException;
import _02_1LvShop.Exceptions.NotEnoughMoneyException;
import _02_1LvShop.Exceptions.OutOfStockException;
import _02_1LvShop.Exceptions.ProductExpiredException;
import _02_1LvShop.Products.FoodProduct;
import _02_1LvShop.Products.Product;

import java.util.Date;

public class PurchaseManager {
    public static void processPurchase(Customer customer, Product product) throws OutOfStockException, ProductExpiredException, NotEnoughMoneyException, AgeRestrictionException {

//        •	If the product is out of stock (i.e. no quantity)
        if (product.getQuantity() < 1) {
            throw new OutOfStockException("This product is out of stock");
        }

//        •	If the product has expired
        if (product instanceof FoodProduct) {
            if ((new Date()).after(((FoodProduct) product).getExpirationDate())) {
                throw new ProductExpiredException("This product has expired");
            }
        }

//        •	If the buyer does not have enough money
        if (customer.getBalance() < product.getPrice()) {
            throw new NotEnoughMoneyException("You do not have enough money to buy this product!");
        }

//        •	If the buyer does not have permission to purchase the given product
        if (product.getAgeRestriction() != AgeRestriction.None) {
            if (product.getAgeRestriction() == AgeRestriction.Teenager && customer.getAge() < 13) {
                throw new AgeRestrictionException("You are too young to buy this product!");
            } else if (product.getAgeRestriction() == AgeRestriction.Adult && customer.getAge() < 18) {
                throw new AgeRestrictionException("You are too young to buy this product!");
            }
        }

        product.setQuantity(product.getQuantity() - 1);
        customer.setBalance(customer.getBalance() - product.getPrice());
    }
}
