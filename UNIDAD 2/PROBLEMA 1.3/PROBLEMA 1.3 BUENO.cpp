#include "iostream"
#include "iostream"
using namespace std;

int main()
{   
 //problema 1.3 Escribe un programa tal que dado como datos el nombre del dinosaurio
// su peso y su Longitud, expresado estos ultimos en libras y pies respectivamente
    //escribe el nombre del dinosaurio, su peso expresado en kilogramos y la Longitud expresada en metros
    
    //Declaracion de variables
    string NOMBRE;
    float PESOENLIBRAS, LONGITUDENPIES;
    float PESOENKILOS, LONGITUDENMETROS;
    
//Entrada de datos
    
cout<< "Escribe el nombre de dinosaurio" "\n";
cin>> NOMBRE;
    
cout<< "Escribe el dinosaurio en libras " "\n";
cin>>PESOENLIBRAS;
    
cout<<"Escribe la Longitud del dinosaurio en pies " "\n";
cin>>LONGITUDENMETROS;
    
//CALCULO
PESOENKILOS=PESOENLIBRAS*1000;
LONGITUDENMETROS=LONGITUDENPIES*0.3047;
    
//SE IMPRIME RESULTADOS
    cout<<" El peso en kilos del dinosaurio "<< NOMBRE<< "es "<<PESOENKILOS<<" y la longitud en metros es "<< LONGITUDENMETROS<<"\n";
 return 0;
}
