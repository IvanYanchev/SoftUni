package _01_Geometry.Shapes.Plane;

import _01_Geometry.Shapes.Plane.PlaneShape;
import _01_Geometry.Vertex.Vertex2D;

public class Triangle extends PlaneShape {

    public Triangle(Vertex2D a, Vertex2D b, Vertex2D c) {
        super(a, b, c);
    }

    @Override
    public double getArea() {
        double aX = ((Vertex2D)this.getVertexes().get(0)).getX();
        double aY = ((Vertex2D)this.getVertexes().get(0)).getY();
        double bX = ((Vertex2D)this.getVertexes().get(1)).getX();
        double bY = ((Vertex2D)this.getVertexes().get(1)).getY();
        double cX = ((Vertex2D)this.getVertexes().get(2)).getX();
        double cY = ((Vertex2D)this.getVertexes().get(2)).getY();

        double area = 0;
        area = Math.abs(aX * (bY - cY) + bX * (cY - aY) + cX * (aY - bY)) / 2;

        return  area;
    }

    @Override
    public double getPerimeter() {
        double aX = ((Vertex2D)this.getVertexes().get(0)).getX();
        double aY = ((Vertex2D)this.getVertexes().get(0)).getY();
        double bX = ((Vertex2D)this.getVertexes().get(1)).getX();
        double bY = ((Vertex2D)this.getVertexes().get(1)).getY();
        double cX = ((Vertex2D)this.getVertexes().get(2)).getX();
        double cY = ((Vertex2D)this.getVertexes().get(2)).getY();

        double perimeter = 0;
        perimeter = Math.sqrt(Math.pow(aX - bX, 2) + Math.pow(aY - bY, 2)) +
                Math.sqrt(Math.pow(bX - cX, 2) + Math.pow(bY - cY, 2)) +
                Math.sqrt(Math.pow(aX - cX, 2) + Math.pow(aY - cY, 2));

        return perimeter;
    }
}