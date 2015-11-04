package _01_Geometry.Shapes.Space;

import _01_Geometry.Shapes.Space.SpaceShape;
import _01_Geometry.Vertex.Vertex3D;

public class SquarePyramid extends SpaceShape {
    private double baseWidth;
    private double pyramidHeight;


    public SquarePyramid(Vertex3D baseC, double baseWidth, double pyramidHeight) {
        super(baseC);
        this.baseWidth = baseWidth;
        this.pyramidHeight = pyramidHeight;

    }

    public double getBaseWidth() {
        return baseWidth;
    }

    public void setBaseWidth(double baseWidth) {
        this.baseWidth = baseWidth;
    }

    public double getPyramidHeight() {
        return pyramidHeight;
    }

    public void setPyramidHeight(double pyramidHeight) {
        this.pyramidHeight = pyramidHeight;
    }

    @Override
    public double getArea() {
        return this.baseWidth * this.baseWidth + 2 * this.baseWidth * Math.sqrt((this.baseWidth * this.baseWidth / 4) + this.pyramidHeight * this.pyramidHeight);
    }

    @Override
    public double getVolume() {
        return this.baseWidth * this.baseWidth * (this.pyramidHeight / 3);
    }
}