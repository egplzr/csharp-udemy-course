// using Section009Codes.ExercicioFixacao.entities;

// Console.Write("Enter the number of products: ");
// int nProducts = int.Parse(Console.ReadLine());
// List<Product> products = [];

// for (int i = 1; i <= nProducts; i++)
// {
//     Console.WriteLine($"Product #{i} data:");
//     Console.Write("Common, used or imported? [c/u/i]");
//     string productType = Console.ReadLine();

//     Console.Write("Name: ");
//     string productName = Console.ReadLine();

//     Console.Write("Price: ");
//     double productPrice = double.Parse(Console.ReadLine());

//     switch (productType)
//     {
//         case "c":
//             products.Add(new(productName, productPrice));
//             break;
//         case "u":
//             Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
//             DateTime productDate = DateTime.Parse(Console.ReadLine());
//             products.Add(new UsedProduct(productName, productPrice, productDate));
//             break;
//         case "i":
//             Console.Write("Customs fee: ");
//             double productFee = double.Parse(Console.ReadLine());
//             products.Add(new ImportedProduct(productName, productPrice, productFee));
//             break;
//         default:
//             Console.Write("Argumento inválido, digite apenas uma das letras especificadas.");
//             break;
//     }
// }

// Console.WriteLine("PRICE TAGS: ");
// foreach (Product product in products)
// {
//     Console.WriteLine(product.PriceTag());
// }