package _01_Geometry.Shapes;

import _01_Geometry.Vertex.Vertex;

import java.util.ArrayList;

public abstract class Shape {

    private ArrayList<Vertex> vertexes;

    public Shape(Vertex... vertex) {
        this.vertexes = new ArrayList<>();
        this.setVertexes(vertex);
    }

    public ArrayList<Vertex> getVertexes() {
        return vertexes;
    }

    public void setVertexes(Vertex... vertexes) {
        for (Vertex vertex: vertexes) {
            this.vertexes.add(vertex);
        }
    }
}