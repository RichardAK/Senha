const string senhacorreta = "MbnaMedia";
string senha,acessopermitido;

Console.Write("Digiote sua senha:"); 
senha = Console.ReadLine()!; 

acessopermitido = senha == senhacorreta? "permitido" : "Negado";

Console.WriteLine($"Acesso {acessopermitido}"); 


