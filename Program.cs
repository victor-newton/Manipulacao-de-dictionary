
Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

Console.WriteLine($"Selecione um dos carros abaixo para ver a media de vendas nos ultimos 5 anos");

foreach (string carros in vendasCarros.Keys){
    Console.WriteLine(carros);
}

string carroSelecionado = Console.ReadLine()!;
int somaCarro = 0;
int a = 0;
if (vendasCarros.ContainsKey(carroSelecionado)){
    for(int i=0; i < vendasCarros[carroSelecionado].Count; i++){

        vendasCarros[carroSelecionado].Contains(a);

        somaCarro = somaCarro + a;
    }
}
else{
    Console.WriteLine($"Carro selecionado nao existe em nossa base de dados");
}


Console.WriteLine(somaCarro);