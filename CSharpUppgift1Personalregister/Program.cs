using System;

namespace CSharpUppgift1Personalregister
{


    //Har glömt hur man skapade klasser att hämta atribut i från i java så c# känns ju lite svårare så här med en gång...
    //Det här är vad jag han göra på denna tid dock.
    //
    //Uppgift 1:Vilka ​klasser ​bör ingå i programmet?
    //Svar: klass där Namn på anstälda samt lön sparas, klass där man kan lägga till info bör skapas anser jag.
    //Uppgift 2: Vilka ​attribut ​och ​metoder ​bör ingå i dessa klasser?
    //Svar: metoder för att spara införandet av anstäldas namn och löner samt metoder för att föra fram anstälda med löner
    class Program
    {
        public string namelist[];
        public int salarylist[];
        public boolean yesOrNo = true;
        static void Main(string[] args)
        {
            while (yesOrNo)
            {
                int x =+1;
                ewEmploye();
            }
            Console.WriteLine("Your employes have been registered");
        }
        public boolean newEmploye(int x)
        {
            
            Console.WriteLine("Employer name?");
            String name = Console.ReadLine();
            namelist[x] = new String[x];
            Console.WriteLine("what is " + name + "s salary?");
            int salary = int.Parse(Console.ReadLine());
            salarylist[x] = new int[x];


            Console.WriteLine("Registred employe!");
            Console.WriteLine("want to register another Employer?" + "If yes: press 1 otherwise press 0");

            yesOrNo = int.Parse(Console.ReadLine());
            return yesOrNo;
        }
    }
}
