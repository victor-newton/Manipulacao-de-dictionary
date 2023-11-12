
Console.Clear();

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

Console.WriteLine("");

string carroSelecionado = Console.ReadLine()!;

if (vendasCarros.ContainsKey(carroSelecionado)){

    double mediaVendas = Queryable.Average(vendasCarros[carroSelecionado].AsQueryable());
    Console.WriteLine($"A medias de vendas do carro selecionado {carroSelecionado} foi de {mediaVendas}");

}
else{
    Console.WriteLine($"Carro selecionado nao existe em nossa base de dados");
}