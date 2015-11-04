package _01_Geometry.Shapes.Space;

import _01_Geometry.Vertex.Vertex3D;

public class Cuboid extends SpaceShape {
    private double width;
    private double height;
    private double depth;

    public Cuboid(Vertex3D vertex, double width, double height, double depth) {
        super(vertex);
        this.width = width;
        this.height = height;
        this.depth = depth;
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

    public double getDepth() {
        return depth;
    }

    public void setDepth(double depth) {
        this.depth = depth;
    }

    @Override
    public double getArea() {
        return this.width * this.height * 2 + this.width * this.depth * 2 + this.height * this.depth * 2;
    }

    @Override
    public double getVolume() {
        return this.width * this.depth * this.height;
    }
}