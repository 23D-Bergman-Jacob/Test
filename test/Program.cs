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
int k = 0;
string tal;
int talnr;
while (k<5){
    tal = Console.ReadLine();
    int.TryParse(tal, out talnr);
    if (talnr>5){
        System.Console.WriteLine("högre än 5");
    }
}