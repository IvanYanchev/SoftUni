package _01_Geometry.Shapes.Plane;

import _01_Geometry.Vertex.Vertex2D;

public class Rectangle extends PlaneShape {

    private double width;
    private double height;

    public Rectangle(Vertex2D a, double width, double height) {
        super(a);
        this.width = width;
        this.height = height;
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    @Override
    public double getArea() {
        return this.width * this.height;
    }

    @Override
    public double getPerimeter() {
        return 2 * this.width + 2 * this.height;
    }
}