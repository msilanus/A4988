/****************************************************************************************
* 
* Controle d'un moteur pas à pas unipolaire avec un driver A4988
* 
* Auteur : MS
* Date : 07/03/2017
* Rev 0
* 
*  Protocol :
*  
*  - STATUS : Demande de l'état du moteur (ON/OF; sens de rotation; résolution; vitesse 
*  - M : Mise en marche
*  - S : Stop
*  - A : Anti horaire
*  - R : Horaire
*  - + : Plus vite
*  - - : Moins vite
*  - F : Full step (plein pas)
*  - H : Half step (demi pas)
*  - Q : Quarter step (quart de pas)
*  - E : Eighth step : (huitième de pas)
*  - X : Sixteenth step : (seizième de pas)
*  - nombre entier : Demi période du signal step : réglage de la vitesse
*  
****************************************************************************************/


const int stepPin = 3;   
const int dirPin = 4;
const int enPin = 2;
const int ms1Pin = 5;
const int ms2Pin = 6;
const int ms3Pin = 7;
const int led = 13;

String recu, motorState = "OFF", stepState = "Full step", wiseState = "Anti Clockwise", speedState = "0.00";
String message;
int duree = 1000;  // Durée d'un demi-pas
bool doitTourner = false;
bool affVitesse = false;
float N = 3 / (20 * (float)duree);
int resolution = 1;

void setup() {
  Serial.begin(250000);
  pinMode(led, OUTPUT);
  digitalWrite(led, LOW);

  pinMode(stepPin, OUTPUT);
  pinMode(dirPin, OUTPUT);
  pinMode(enPin, OUTPUT);
  pinMode(ms1Pin, OUTPUT);
  pinMode(ms2Pin, OUTPUT);
  pinMode(ms3Pin, OUTPUT);

  // Initialisation
  digitalWrite(enPin, HIGH);
  digitalWrite(dirPin, HIGH);

  // Full step
  digitalWrite(ms3Pin, LOW);
  digitalWrite(ms2Pin, LOW);
  digitalWrite(ms1Pin, LOW);
}

void loop() 
{
  // Si on recoit quelque chose, sinon on rien
  if (Serial.available() > 0)
  {
    recu = Serial.readStringUntil('\n');
    digitalWrite(led, HIGH);
    if (recu == "STATUS")
    {
      // Réglages actuels
      message = motorState + ";" + wiseState + ";" + stepState + ";" + speedState + ";";
      Serial.println(message);
    }
    else // Protocol
    {
      switch (recu[0])
      {
        // Réglage de la demi période du signal step
        case '0' :
        case '1' :
        case '2' :
        case '3' :
        case '4' :
        case '5' :
        case '6' :
        case '7' :
        case '8' :
        case '9' :  duree = recu.toInt();
                    affVitesse = true;
                    break;
        
        // Demande de mise en Marche
        case 'M' :  digitalWrite(enPin, LOW);
                    motorState = "ON";
                    doitTourner = true;
                    affVitesse = true;
                    break;
       
        // Demande Stop moteur
        case 'S' :  digitalWrite(enPin, HIGH);
                    motorState = "OFF";
                    affVitesse = false;
                    doitTourner = false;
                    break;
        // Demande sens de rotation Anti horaire
        case 'A' :  digitalWrite(dirPin, HIGH);
                    wiseState = "Anti Clockwise";
                    //Serial.println(wiseState);
                    break;
        
        // Demande sens rotation horaire (Reverse)
        case 'R' :  digitalWrite(dirPin, LOW);
                    wiseState = "Clockwise";
                    //Serial.println(wiseState);
                    break;
        
        // Demande Vitesse +
        case '+' :  duree = duree - 100;
                    break;
        
        // Demande Vitesse -
        case '-' :  duree = duree + 100;
                    break;
        
        // Demande résolution
        case 'F' : // Full step
                    digitalWrite(ms3Pin, LOW);
                    digitalWrite(ms2Pin, LOW);
                    digitalWrite(ms1Pin, LOW);
                    resolution = 1;
                    stepState = "Full step";
                    break;

        case 'H' : // Half step
                    digitalWrite(ms3Pin, LOW);
                    digitalWrite(ms2Pin, LOW);
                    digitalWrite(ms1Pin, HIGH);
                    resolution = 2;
                    stepState = "Half step";
                    break;

        case 'Q' : // Quarter step
                    digitalWrite(ms3Pin, LOW);
                    digitalWrite(ms2Pin, HIGH);
                    digitalWrite(ms1Pin, LOW);
                    resolution = 4;
                    stepState = "Quarter step";
                    break;

        case 'E' : // Eighth step
                    digitalWrite(ms3Pin, LOW);
                    digitalWrite(ms2Pin, HIGH);
                    digitalWrite(ms1Pin, HIGH);
                    resolution = 8;
                    stepState = "Eighth step";
                    break;

        case 'X' : // Sixteenth step
                    digitalWrite(ms3Pin, HIGH);
                    digitalWrite(ms2Pin, HIGH);
                    digitalWrite(ms1Pin, HIGH);
                    stepState = "Sixteenth step";
                    resolution = 16;
                    break;
      }

      // Témoin transmission de données
      delay(100);
      digitalWrite(led, LOW);

      // Calcul vitesse de rotation 
      if (affVitesse)
      {
        if (duree < 520) duree = 530;
        if (duree > 16380) duree = 16380;
        N = 150000.0 / ((float)duree * (float)resolution);
      }
      else
      {
        N = 0;
      }
      speedState = String(N);
      
      // Préparation du message
      message = motorState + ";" + wiseState + ";" + stepState + ";" + speedState + ";";

      // Transmission du message
      Serial.println(message);
    }
  }

  // Faire tourner le moteur
  if (doitTourner) tourne(duree);
  else digitalWrite(stepPin, LOW);
}

void tourne(int d)
{
  digitalWrite(stepPin, LOW);
  delayMicroseconds(d);
  digitalWrite(stepPin, HIGH);
  delayMicroseconds(d);
}

