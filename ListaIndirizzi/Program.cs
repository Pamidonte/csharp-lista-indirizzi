// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;
namespace ListaIndirizzi { 
class Program{
        public static void Main(string[] args) {
            string pathFile = "C:\\Users\\franc\\source\\repos\\ListaIndirizziFile.txt";
            string[] lines = File.ReadAllLines(pathFile);
            List<Indirizzo> result = new List<Indirizzo>();
            foreach (string line in lines)
            {
                string[] data = line.Split(",");
                if(data.Length != 6 || data.Any(" ".Contains)) {
                  Console.WriteLine("attenzione ci sono degli errori in: " + line);

                }
                else
                {
                    Indirizzo indirizzo = new Indirizzo(data[0], data[1], data[2], data[3], data[4], data[5]);
                    result.Add(indirizzo);
                }
              
            }
            foreach (Indirizzo item in result)
            {
                item.stampaIndirizzo();

            }





        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }


}    