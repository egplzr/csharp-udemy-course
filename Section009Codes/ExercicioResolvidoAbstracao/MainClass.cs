// using Section009Codes.ExercicioResolvidoAbstracao.entities;
// using Section009Codes.ExercicioResolvidoAbstracao.entities.enums;

// Console.Write("Enter the number of shapes: ");
// int nShapes = int.Parse(Console.ReadLine());
// List<Shape> shapes = [];

// for (int i = 1; i <= nShapes; i++)
// {
//     Console.WriteLine($"Shape #{i} data:");
//     Console.Write("Rectangle or Circle? [r/c] ");
//     string shapeType = Console.ReadLine();

//     Console.Write("Color [Black/Blue/Red]: ");
//     Color shapeColor = Enum.Parse<Color>(Console.ReadLine());

//     if (shapeType.Equals("r"))
//     {
//         Console.Write("Width: ");
//         double shapeWidth = double.Parse(Console.ReadLine());

//         Console.Write("Height: ");
//         double shapeHeight = double.Parse(Console.ReadLine());

//         shapes.Add(new Rectangle(shapeColor, shapeWidth, shapeHeight));
//     }
//     else if (shapeType.Equals("c"))
//     {
//         Console.Write("Radius: ");
//         double shapeRadius = double.Parse(Console.ReadLine());

//         shapes.Add(new Circle(shapeColor, shapeRadius));
//     }
//     else
//     {
//         Console.Write("Invalid argument. Please type the correct letter.");
//     }
// }

// Console.WriteLine("SHAPE AREAS: ");
// foreach (Shape shape in shapes)
// {
//     Console.WriteLine(shape.Area());
// }