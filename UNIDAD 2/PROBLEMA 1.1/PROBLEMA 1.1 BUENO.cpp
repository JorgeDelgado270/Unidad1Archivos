#include "iostream"

using namespace std;

int main()
{    
  //problema 1.1
// Construya un programa que dado el costo de un articulo vendido y la catidad
 //de dinero entrgada por el cliente, calcule e  imprima el cambio que debe de entregar
     
      
 //Declaracion de variables
 float PRECIOPRODUCTO, DEVOLUCION;
 float PAGO;
      
//Entrada de datos

cout<< "Escribe el costo del articulo "<<"\n";
cin >> PRECIOPRODUCTO;
    
cout<< "Escribe cuanto fue el pago el articulo " <<"\n";
cin>>PAGO;
    
//CALCULO DE DEVOLUCION
    
DEVOLUCION= PAGO-PRECIOPRODUCTO;
    
//SE IMPREME RESULTADOS
    cout<<" El cambio del cliente es "<<DEVOLUCION;
    return 0;
}
