// if (6>3)
// {
// Console.WriteLine("Hello, World!");
// }
// System.Console.WriteLine("Användarnamn:");
// string namn = Console.ReadLine();
// System.Console.WriteLine("Lösenord");
// string Lösenord = Console.ReadLine();
// if (namn == "kalleanka")
// {
//     if (Lösenord == "12345")
//     {
//     System.Console.WriteLine("välkommen");
//     }
//     else{
//         System.Console.WriteLine("Fel användarnamn eller lösenord");
//     }
// }
// else{
//     System.Console.WriteLine("Fel användarnamn eller lösenord");
// }
// Console.ReadLine();
// int k = 0;
// while (k<32){
//     System.Console.WriteLine("hello world");
//     k++;
//     System.Console.WriteLine(k);
// }
// Console.ReadLine();
// while (true){

//     System.Console.WriteLine("Lösenord");
//     string Lösenord = Console.ReadLine();
//     if (Lösenord == "Hejsan"){
//         System.Console.WriteLine("Hejsan på dig");
//         break;
//     } 
// }
// Console.ReadLine();
// int k = 0;
// string tal;
// int talnr;
// while (k<5){
//     while (true){

//     tal = Console.ReadLine();
//    bool succes = int.TryParse(tal, out talnr);
//     if (succes == true){
//         break;
//     }
//     else{
//     System.Console.WriteLine("skriv ett tal");
//     }
//     }

//     if (talnr>5){
//         System.Console.WriteLine("högre än 5");
//     }
//     k++;
// }
// Console.ReadLine();
// Random rnd = new Random();
// int tal = rnd.Next(1,30);
// string talAnvändare;
// int talnr;
// while (true){
//     while (true){
//     System.Console.WriteLine("Skriv ett nummer");
//     talAnvändare = Console.ReadLine();
//     bool succes = int.TryParse(talAnvändare, out talnr);
//     if (succes == true){
//         break;
//     }
//     }
//     if (talnr == tal){
//         System.Console.WriteLine("rätt");
//         break;
//     }
//     if (talnr < tal){
//         System.Console.WriteLine("för lågt tal");
//     }
//     else{
//         System.Console.WriteLine("för högt tal");
//     }
// }
// Console.ReadLine();

// Nästa steg

// string[] leksaker = {"Fotboll", "Handboll", "PingisBoll", "Baseboll", "AmerkanskFotboll"};
// for(int k = 0; k < 5; k++) {
//     System.Console.WriteLine(leksaker[k]);
// }
// Console.ReadLine();
// string[] leksaker = {"Konstantinos", "Felix", "Sterky", "Jacob", "Filip"};
// int[] nummer = {1,3,4,2,10};
// int i = 4;
// for(int k = 0; k < 5; k++) {
//     if (k > 0)
//     {
//         i= k-1;
//     }
// Console.WriteLine($"{leksaker[k]} Tyckte att {leksaker[i]} va en {nummer[k]}");
// }
 
// Console.ReadLine();
// List<string> Städer = new List<string>();
// string Input;
// while (true)
// {
//     int antStäder = Städer.Count();
//     antStäder++;
//     Input = Console.ReadLine();
//     Console.Clear();
//     if (Input.ToLower() == "exit")
//     {
//         break;
//     }
//     else
//     {
//         Städer.Add(Input);
//     }
//     for(int k = 0; k<antStäder; k++)
//     {
//         System.Console.WriteLine(Städer[k]);
//     }
//     System.Console.WriteLine(antStäder);
// }

// upg 3
// Hello32();


// void Hello32(){
// for(int k = 0; k<32; k++)
// {
//     System.Console.WriteLine("hello world");
// }
// Console.ReadLine();
// }
Square(9);

static void Square(int n)
{
    int square = n*n;
    System.Console.WriteLine(square);
}
Console.ReadLine();