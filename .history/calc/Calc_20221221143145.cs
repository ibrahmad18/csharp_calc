
namespace Main.Calc{
class Calc{

    static int calcType;
    static String userName = "";
    static bool boucle = false;

    public static void start(){
        Console.WriteLine(" *********** Bonjour bienvenue sur la calculatrice Majic de Ahmad ************ \n ");
        
        Console.WriteLine("Enter votre nom :"); 
        userName = Console.ReadLine();

        Console.WriteLine("bonjour "+ userName);

        Console.WriteLine("Veillez Choisir le type d'opération à faire \n");
        Console.WriteLine(" 1: Addition \n2: Soustraction\n 3:Multiplication \n Division , 0: QUitter le program");
        
        boucle = true;
        while(boucle == true){

        }

    }

}
}