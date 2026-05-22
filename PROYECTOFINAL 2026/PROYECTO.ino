#include <LiquidCrystal.h>
#include <DHT.h>

// 1. CONFIGURACIÓN DE LA PANTALLA LCD (Pines: RS, E, D4, D5, D6, D7)
// Conectados exactamente a los pines digitales 12, 11, 5, 4, 3, 2 del Arduino
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);

// 2. CONFIGURACIÓN DEL SENSOR DHT11
#define DHTPIN 9     // El pin DATA del sensor va forzosamente al pin 9
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);

// 3. CONFIGURACIÓN DE LOS ACTUADORES (LEDS)
const int ledVerde = 6;
const int ledAmarillo = 7;
const int ledRojo = 8;

// Variable para controlar el envío de datos a C# sin trabar el programa
unsigned long tiempoAnterior = 0;

void setup() {
  // Inicializamos la comunicación serie a 9600 baudios
  Serial.begin(9600);
  
  // Inicializamos el sensor de temperatura y la pantalla LCD (16 columnas x 2 filas)
  dht.begin();
  lcd.begin(16, 2);
  
  // Configuramos los pines de los LEDs como salidas
  pinMode(ledVerde, OUTPUT);
  pinMode(ledAmarillo, OUTPUT);
  pinMode(ledRojo, OUTPUT);
  
  // Mensaje de bienvenida inicial en el LCD físico al arrancar
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("SISTEMA MONITOR");
  lcd.setCursor(0, 1);
  lcd.print("Iniciando... OK");
  
  delay(1500); // Pausa de seguridad para que el sensor se estabilice
}

void loop() {
  
  // --- PARTE 1: LEER SENSOR REAL Y ENVIAR DATOS A VISUAL STUDIO C# ---
  // Se ejecuta automáticamente cada 1.5 segundos de forma asíncrona
  if (millis() - tiempoAnterior >= 1500) {
    tiempoAnterior = millis();
    
    int t = dht.readTemperature(); // Lectura real de temperatura en °C
    int h = dht.readHumidity();    // Lectura real de humedad en %

    // Protección: Si el sensor llega a fallar o desconectarse, mandamos 0 en lugar de trabar la HMI
    if (isnan(t) || isnan(h)) { 
      t = 0; 
      h = 0; 
    }

    // Actualizamos la información de forma local en los renglones de tu pantalla LCD física
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Temp: "); 
    lcd.print(t); 
    lcd.print(" C");
    
    lcd.setCursor(0, 1);
    lcd.print("Humedad: "); 
    lcd.print(h); 
    lcd.print(" %");

    // Enviamos los datos ordenados a C# con el formato "TempHHum" (Ejemplo: "24H58")
    Serial.print(t);
    Serial.print("H");
    Serial.println(h);
  }

  // --- PARTE 2: RECIBIR ÓRDENES DESDE LOS BOTONES DE TU INTERFAZ C# ---
  if (Serial.available() > 0) {
    char comando = Serial.read(); // Lee el carácter enviado desde C#
    
    // Control del LED Verde (Pin 6)
    if (comando == 'V') digitalWrite(ledVerde, HIGH);   // Enciende con 'V' mayúscula
    if (comando == 'v') digitalWrite(ledVerde, LOW);    // Apaga con 'v' minúscula
    
    // Control del LED Amarillo (Pin 7)
    if (comando == 'A') digitalWrite(ledAmarillo, HIGH); // Enciende con 'A' mayúscula
    if (comando == 'a') digitalWrite(ledAmarillo, LOW);  // Apaga con 'a' minúscula
    
    // Control del LED Rojo (Pin 8)
    if (comando == 'R') digitalWrite(ledRojo, HIGH);     // Enciende con 'R' mayúscula
    if (comando == 'r') digitalWrite(ledRojo, LOW);      // Apaga con 'r' minúscula
  }
}