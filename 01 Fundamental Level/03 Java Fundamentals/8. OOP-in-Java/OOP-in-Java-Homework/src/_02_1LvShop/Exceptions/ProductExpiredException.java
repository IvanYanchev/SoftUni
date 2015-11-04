package _02_1LvShop.Exceptions;

public class ProductExpiredException extends Exception {
    public ProductExpiredException(String message) {
        super(message);
    }
}