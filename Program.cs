double adultoSA, adulto, crianca;

Console.WriteLine("                  --- Churrasco ---");
Console.WriteLine("um programa que calcula a quantidade de itens necessários para um churrasco\n");

Console.WriteLine("Digite o numero de:");
Console.Write("Adultos (que consomem bebidas alcoólicas).......: ");
adulto = Convert.ToDouble(Console.ReadLine());
Console.Write("\nAdultos (que não consomem bebidas alcoólicas)...: ");
adultoSA = Convert.ToDouble(Console.ReadLine());
Console.Write("\nCrianças........................................: ");
crianca = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n\n\nPara um bom churrasco você vai precisar de:");
double carne = (adulto + adultoSA) * (400)+(crianca*200);
double acompanhamentos = (adulto+adultoSA+crianca)*200;
double cerveja = adulto*2;
double refrigerante = (adulto+adultoSA+crianca)*(500);
double agua = (adulto+adultoSA+crianca)*400;
Console.WriteLine($"Carne.............:{carne/1000}Kg");
Console.WriteLine($"Acompanhamentos...:{acompanhamentos/1000}Kg");
Console.WriteLine($"Cerveja...........:{cerveja}L");
Console.WriteLine($"Refrigerante......:{refrigerante /1000}L");
Console.WriteLine($"Água..............:{agua/1000}L");