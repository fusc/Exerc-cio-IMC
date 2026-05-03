﻿Console.WriteLine("Me informe seu peso");
string pesoPessoa = Console.ReadLine()!;

Console.WriteLine("Me informe sua altura");
string alturaPessoa = Console.ReadLine()!;

double altura = Convert.ToDouble(alturaPessoa);

double peso = Convert.ToDouble(pesoPessoa); 

int resultado = Convert.ToInt32(peso / (altura * altura));

 Console.WriteLine($"este é seu IMC: {resultado} KG/m²");