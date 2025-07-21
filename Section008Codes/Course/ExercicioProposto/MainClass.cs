using Section008Codes.Course.Entities.Enums;
using Section008Codes.Course.ExercicioProposto.Entities;

cwl("Enter Client Data:");
cw("Name: ");
string? cName = cr();
cw("Email: ");
string? cEmail = cr();
cw("Birth Date (DD/MM/YYYY): ");
DateTime.TryParse(cr(), out var cBirth);

Client client = new(cName, cEmail, cBirth);

cwl("Enter Order Data:");
cw("Status: ");
Enum.TryParse<OrderStatus>(cr(), out var orderStatus);
cw("How many items to this order? ");
int.TryParse(cr(), out var nItems);

Order order = new(orderStatus, client);

int i = 1;
while (nItems > 0)
{
    cwl($"Enter the #{i} item data:");
    cw("Product Name: ");
    string pName = cr();

    cw("Product Price: ");
    double pPrice = Double.Parse(cr());

    Product product = new(pName, pPrice);

    cw("Quantity: ");
    int pQuantity = int.Parse(cr());

    order.AddItem(new(pQuantity, product));
    i++;
    nItems--;
}

cwl(order.ToString());


static void cw(string txt)
{
    Console.Write(txt);
}

static void cwl(string txt)
{
    Console.WriteLine(txt);
}

static string? cr()
{
    return Console.ReadLine();
}