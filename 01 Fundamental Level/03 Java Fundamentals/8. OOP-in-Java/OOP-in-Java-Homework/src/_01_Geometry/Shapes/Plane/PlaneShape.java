package _01_Geometry.Shapes.Plane;

import _01_Geometry.Interfaces.AreaMeasurable;
import _01_Geometry.Interfaces.PerimeterMeasurable;
import _01_Geometry.Shapes.Shape;
import _01_Geometry.Vertex.Vertex;
import _01_Geometry.Vertex.Vertex2D;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable, AreaMeasurable {

    public PlaneShape(Vertex2D... vertexes) {
        super(vertexes);
    }

    @Override
    public abstract double getArea();

    @Override
    public abstract double getPerimeter();

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append(String.format("Shape type: %s\n", this.getClass().getSimpleName()));
        sb.append("Vertex2D coordinates: ");

        for (Vertex vertex : this.getVertexes()) {
            sb.append(String.format("[%.2f, %.2f] ", ((Vertex2D)vertex).getX(), ((Vertex2D)vertex).getY()));
        }

        sb.append("\n");
        sb.append(String.format("Perimeter: %.2f\n", this.getPerimeter()));
        sb.append(String.format("Area: %.2f\n", this.getArea()));

        return sb.toString();
    }
}