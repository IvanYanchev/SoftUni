package _01_Geometry.Main;

import _01_Geometry.Interfaces.PerimeterMeasurable;
import _01_Geometry.Interfaces.VolumeMeasurable;
import _01_Geometry.Shapes.Plane.Circle;
import _01_Geometry.Shapes.Plane.PlaneShape;
import _01_Geometry.Shapes.Plane.Rectangle;
import _01_Geometry.Shapes.Plane.Triangle;
import _01_Geometry.Shapes.Shape;
import _01_Geometry.Shapes.Space.Cuboid;
import _01_Geometry.Shapes.Space.SpaceShape;
import _01_Geometry.Shapes.Space.Sphere;
import _01_Geometry.Shapes.Space.SquarePyramid;
import _01_Geometry.Vertex.Vertex2D;
import _01_Geometry.Vertex.Vertex3D;

import java.util.ArrayList;
import java.util.Locale;

public class Main {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);

        ArrayList<Shape> list = new ArrayList<>();

        list.add(new Triangle(new Vertex2D(2, 6), new Vertex2D(3.5, 18), new Vertex2D(0.2, -7.5)));
        list.add(new Rectangle(new Vertex2D(3.4, 5.8), 12.3, 18.1));
        list.add(new Circle(new Vertex2D(4, 5), 3.9));
        list.add(new SquarePyramid(new Vertex3D(2, 5, 4.7), 0.4, 1.2));
        list.add(new Cuboid(new Vertex3D(2, 3, 3), 5.2, 8.5, 11.4));
        list.add(new Sphere(new Vertex3D(4, 5, 9), 7.3));

/*        for (Shape shape: list) {
            System.out.println(shape);
        }*/
        System.out.println("VolumeMeasurable shapes whose volume is over 40.00: \n");
        list.stream()
                .filter(x -> x instanceof VolumeMeasurable)
                .map(x -> (SpaceShape)x)
                .filter(x -> x.getVolume() > 40.00)
                .forEach(System.out::println);

        System.out.println("Plane shapes sorted by their perimeter in ascending order: \n");
        list.stream()
                .filter(x -> x instanceof PerimeterMeasurable)
                .map(x -> (PlaneShape)x)
                .sorted((x, y) -> Double.compare(x.getPerimeter(), y.getPerimeter()))
                .forEach(System.out::println);


    }
}