// using Section009Codes.ExemploAula.Entities;

// Account account = new(1001, "Alex", 0);
// BusinessAccount businessAccount = new(1002, "Maria", 0, 500);

// // Exemplo Upcasting
// Account account1 = businessAccount;
// Account account2 = new (1003, "Bob", 0);
// Account account3 = new SavingsAccount(1004, "Anna", 0, 0.01);

// // Exemplo Downcasting (é necessário fazer um casting)
// // é uma operação não segura e não recomendável
// BusinessAccount account4 = (BusinessAccount)account2;
// account4.Loan(100);
// account2.Loan(100);

// // Nesse exemplo o compilador não detecta o erro, mas não é possível fazer
// // o casting de uma subclasse para outra subclasse
// // BusinessAccount account5 = (BusinessAccount)account3;

// // Solução para evitar o erro comentado acima:
// if (account3 is BusinessAccount)
// {
//     //Duas formas de fazer um casting:
//     BusinessAccount account5 = (BusinessAccount)account3;
//     //BusinessAccount account5 = account3 as BusinessAccount;
//     account5.Loan(200);
// }

// if (account3 is SavingsAccount)
// {
//     //SavingsAccount account5 = (SavingsAccount)account3;
//     SavingsAccount account5 = account3 as SavingsAccount;
//     account5.UpdateBalance();
// }