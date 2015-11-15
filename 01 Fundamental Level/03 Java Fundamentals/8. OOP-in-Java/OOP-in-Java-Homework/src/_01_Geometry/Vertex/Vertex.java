package _01_Geometry.Vertex;

public abstract class Vertex {
    private double x;

    public Vertex(double x) {
        this.x = x;
    }

    public double getX() {
        return x;
    }

    public void setX(double x) {
        this.x = x;
    }
}