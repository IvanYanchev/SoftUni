package _01_Geometry.Shapes.Plane;

import _01_Geometry.Vertex.Vertex2D;

public class Circle extends PlaneShape {
    private double radius;

    public Circle(Vertex2D c, double radius) {
        super(c);
        this.radius = radius;
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }

    @Override
    public double getArea() {
        return Math.PI * this.radius * this.radius;
    }

    @Override
    public double getPerimeter() {
        return 2 * Math.PI * this.radius;
    }
}