// See https://aka.ms/new-console-template for more information

Console.WriteLine("Por favor, digite o CEP e pressione ENTER:");
var cep = Console.ReadLine();

string url = "https://viacep.com.br/ws/" + cep + "/json/";

string result = new HttpClient().GetStringAsync(url).Result;

Console.WriteLine(result);

