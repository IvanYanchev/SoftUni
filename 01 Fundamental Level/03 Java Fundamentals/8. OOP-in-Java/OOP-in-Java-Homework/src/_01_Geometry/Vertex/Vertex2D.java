package _01_Geometry.Vertex;

public class Vertex2D extends Vertex {
    private double y;

    public Vertex2D(double x, double y) {
        super(x);
        this.y = y;
    }

    public double getY() {
        return y;
    }

    public void setY(double y) {
        this.y = y;
    }
}