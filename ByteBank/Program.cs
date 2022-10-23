using ByteBank;

ContaCorrente andre = new ContaCorrente();

andre.titular = "André Silva";
andre.conta = "1010-X";
andre.numeroAgencia = 15;
andre.saldo = 100.00;

Console.WriteLine("Saldo da conta do André = " + andre.saldo);