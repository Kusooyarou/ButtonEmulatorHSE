String readdata;
int pin1 = 2;
int pin2 = 3;
int pin3 = 4;
int pin4 = 5;
int pin5 = 8;
int pin6 = 9;
int pin7 = 10;
int pin8 = 11;

#define PWM_PIN 6

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(pin1, OUTPUT);
  pinMode(pin2, OUTPUT);
  pinMode(pin3, OUTPUT);
  pinMode(pin4, OUTPUT);
  pinMode(pin5, OUTPUT);
  pinMode(pin6, OUTPUT);
  pinMode(pin7, OUTPUT);
  pinMode(pin8, OUTPUT);

  pinMode(PWM_PIN, OUTPUT); 
  
  digitalWrite(pin1, LOW);
  digitalWrite(pin2, LOW);
  digitalWrite(pin3, LOW);
  digitalWrite(pin4, LOW);
  digitalWrite(pin5, LOW);
  digitalWrite(pin6, LOW);
  digitalWrite(pin7, LOW);
  digitalWrite(pin8, LOW);
}

void loop() {
  if(Serial.available()>0)
  {
    char data = Serial.read();
    readdata.concat(data);
  }
  else
  {
    if(readdata.equals("Hello"))
    {
      Serial.write("ardok");
      readdata = "";
    }
    else if(readdata.substring(0) =="1H")
    {
      digitalWrite(pin1, HIGH);
      readdata = "";
    }
    else if(readdata.substring(0) =="1L")
    {
      digitalWrite(pin1, LOW);
      readdata = "";
    }
    else if(readdata.substring(0) =="2H")
    {
      digitalWrite(pin2, HIGH);
      readdata = "";
    }
    else if(readdata.substring(0) =="2L")
    {
      digitalWrite(pin2, LOW);
      readdata = "";
    }
    else if(readdata.substring(0) =="3H")
    {
      digitalWrite(pin3, HIGH);
      readdata = "";
    }
    else if(readdata.substring(0) =="3L")
    {
      digitalWrite(pin3, LOW);
      readdata = "";
    }
    else if(readdata.substring(0) =="4H")
    {
      digitalWrite(pin4, HIGH);
      readdata = "";
    }
    else if(readdata.substring(0) =="4L")
    {
      digitalWrite(pin4, LOW);
      readdata = "";
    }
    else if(readdata.substring(0) =="5H")
    {
      digitalWrite(pin5, HIGH);
      readdata = "";
    }
    else if(readdata.substring(0) =="5L")
    {
      digitalWrite(pin5, LOW);
      readdata = "";
    }
    else if(readdata.substring(0) =="6H")
    {
      digitalWrite(pin6, HIGH);
      readdata = "";
    }
    else if(readdata.substring(0) =="6L")
    {
      digitalWrite(pin6, LOW);
      readdata = "";
    }
    else if(readdata.substring(0) =="7H")
    {
      digitalWrite(pin7, HIGH);
      readdata = "";
    }
    else if(readdata.substring(0) =="7L")
    {
      digitalWrite(pin7, LOW);
      readdata = "";
    }
    else if(readdata.substring(0) =="8H")
    {
      digitalWrite(pin8, HIGH);
      readdata = "";
    }
    else if(readdata.substring(0) =="8L")
    {
      digitalWrite(pin8, LOW);
      readdata = "";
    }
    else if(
      readdata.substring(0) =="9H" || readdata.substring(0) =="9L" ||
      readdata.substring(0) =="10H" || readdata.substring(0) =="10L" ||
      readdata.substring(0) =="11H" || readdata.substring(0) =="11L" ||
      readdata.substring(0) =="12H" || readdata.substring(0) =="12L" ||
      readdata.substring(0) =="13H" || readdata.substring(0) =="13L" ||
      readdata.substring(0) =="14H" || readdata.substring(0) =="14L" ||
      readdata.substring(0) =="15H" || readdata.substring(0) =="15L" ||
      readdata.substring(0) =="16H" || readdata.substring(0) =="16L" ||
      readdata.substring(0) =="17H" || readdata.substring(0) =="17L" ||
      readdata.substring(0) =="18H" || readdata.substring(0) =="18L" ||
      readdata.substring(0) =="19H" || readdata.substring(0) =="19L" ||
      readdata.substring(0) =="20H" || readdata.substring(0) =="20L" ||
      readdata.substring(0) =="21H" || readdata.substring(0) =="21L" ||
      readdata.substring(0) =="22H" || readdata.substring(0) =="22L" ||
      readdata.substring(0) =="23H" || readdata.substring(0) =="23L" ||
      readdata.substring(0) =="24H" || readdata.substring(0) =="24L" )
    {
      readdata = "";
    }
    else if (readdata.startsWith("PWM ")) {
      int dutyCycle = readdata.substring(4).toInt();
      // Ограничиваем значение скважности в диапазоне от 0 до 255
      dutyCycle = constrain(dutyCycle, 0, 255);
      analogWrite(PWM_PIN, dutyCycle);
      readdata = "";
    }
  }
}
