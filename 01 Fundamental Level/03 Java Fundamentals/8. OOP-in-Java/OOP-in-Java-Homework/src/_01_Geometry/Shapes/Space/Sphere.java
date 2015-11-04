package _01_Geometry.Shapes.Space;

import _01_Geometry.Vertex.Vertex3D;

public class Sphere extends SpaceShape {
    private double radius;

    public Sphere(Vertex3D c, double radius) {
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
        return 4.0 * Math.PI * this.radius * this.radius;
    }

    @Override
    public double getVolume() {
        return (4.0 / 3.0) * Math.PI * this.radius * this.radius * this.radius;
    }
}