package _01_Geometry.Shapes.Space;

import _01_Geometry.Interfaces.AreaMeasurable;
import _01_Geometry.Interfaces.VolumeMeasurable;
import _01_Geometry.Shapes.Shape;
import _01_Geometry.Vertex.Vertex;
import _01_Geometry.Vertex.Vertex3D;

import java.util.ArrayList;

public abstract class SpaceShape extends Shape implements AreaMeasurable, VolumeMeasurable {

    public SpaceShape(Vertex3D... vertexes) {
        super(vertexes);
    }

    @Override
    public abstract double getArea();

    @Override
    public abstract double getVolume();

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append(String.format("Shape type: %s\n", this.getClass().getSimpleName()));
        sb.append("Vertex3D coordinates: ");

        for (Vertex vertex : this.getVertexes()) {
            sb.append(String.format("[%.2f, %.2f, %.2f] ", ((Vertex3D)vertex).getX(), ((Vertex3D)vertex).getY(), ((Vertex3D)vertex).getZ()));
        }

        sb.append("\n");
        sb.append(String.format("Area: %.2f\n", this.getArea()));
        sb.append(String.format("Volume: %.2f\n", this.getVolume()));

        return sb.toString();
    }
}