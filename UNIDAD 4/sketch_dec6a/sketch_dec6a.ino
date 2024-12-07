#include <DHT.h>
#define DHTTYPE DHT11
#define DHTPIN 9

DHT dht (DHTPIN, DHTTYPE);
void setup() {
  //Paso 1
    Serial.begin(9600);
    dht.begin();
}


void loop() {
  //Paso 2
    delay (2000);
    float humidity = dht.readHumidity();
    float temperature = dht.readTemperature();

    if(isnan(humidity) || isnan ( temperature)){
      Serial.println("ERROR EN EL SENSOR");
      return;
    }
    Serial.print("Humidity: ");
    Serial.print (humidity);
    Serial.print(" Temperature:");
    Serial.print(temperature) ;
    Serial.println ("°C");
}


