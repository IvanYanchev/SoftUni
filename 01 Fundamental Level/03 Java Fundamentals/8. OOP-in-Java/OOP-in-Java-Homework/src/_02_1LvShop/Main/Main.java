package _02_1LvShop.Main;


import _02_1LvShop.Customer.Customer;
import _02_1LvShop.Enums.AgeRestriction;
import _02_1LvShop.Exceptions.AgeRestrictionException;
import _02_1LvShop.Exceptions.NotEnoughMoneyException;
import _02_1LvShop.Exceptions.OutOfStockException;
import _02_1LvShop.Exceptions.ProductExpiredException;
import _02_1LvShop.Manager.PurchaseManager;
import _02_1LvShop.Products.Appliance;
import _02_1LvShop.Products.Computer;
import _02_1LvShop.Products.FoodProduct;
import _02_1LvShop.Products.Product;

import java.util.ArrayList;
import java.util.Date;

public class Main {
    public static void main(String[] args) {
        ArrayList<Product> products = new ArrayList<>();

        FoodProduct cigars = new FoodProduct("420 Blaze it fgt", 6.90, 1400, AgeRestriction.Adult, new Date(2016, 11, 04));

        Customer pecata = new Customer("Pecata", 17, 30.00);

        try {
            PurchaseManager.processPurchase(pecata, cigars);
        } catch (OutOfStockException | ProductExpiredException | NotEnoughMoneyException | AgeRestrictionException ex) {
            System.out.println(ex.getMessage());
        }

        Customer gopeto = new Customer("Gopeto", 18, 0.44);

        try {
            PurchaseManager.processPurchase(gopeto, cigars);
        } catch (OutOfStockException | ProductExpiredException | NotEnoughMoneyException | AgeRestrictionException ex) {
            System.out.println(ex.getMessage());
        }

        products.add(cigars);
        products.add(new FoodProduct("Вафли Боровец", 0.30, 100, AgeRestriction.None, new Date(2016, 02, 10)));
        products.add(new FoodProduct("Кока-Кола", 1.20, 20, AgeRestriction.Teenager, new Date(2016, 12, 01)));
        products.add(new FoodProduct("Джим Бийм", 12.50, 2, AgeRestriction.Adult, new Date(2017, 11, 04)));
        products.add(new Appliance("Готварска печка Gorenje", 800, 1, AgeRestriction.Teenager));
        products.add(new Computer("Acer Aspire E1-572G NX.M8JEX.028", 1249.00, 2, AgeRestriction.None));


        System.out.print("\nThe product with the soonest date of expiration: ");
        products.stream()
                .filter(x -> x instanceof FoodProduct)
                .map(x -> (FoodProduct) x)
                .sorted((x, y) -> x.getExpirationDate().compareTo(y.getExpirationDate()))
                .limit(1)
                .map(x -> x.getName())
                .forEach(System.out::println);

        System.out.println("\nAll products with adult age restriction sorted by price in ascending order: ");
        products.stream()
                .filter(x -> x.getAgeRestriction() == AgeRestriction.Adult)
                .sorted((x, y) -> Double.compare(x.getPrice(), y.getPrice()))
                .map(x -> new String(String.format("%s %s лв.", x.getName(), x.getPrice())))
                .forEach(System.out::println);
    }
}