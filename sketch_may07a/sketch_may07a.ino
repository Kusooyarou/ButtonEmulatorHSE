String readdata;
int pin1 = 2;
int pin2 = 3;
int pin3 = 4;
int pin4 = 5;
int pin5 = 8;
int pin6 = 9;
int pin7 = 10;
int pin8 = 11;

// #define PWM_PIN 11
int PWM_PIN = 9;

void setup() {
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
    if(readdata.startsWith("Hello"))
    {
      Serial.write("ardok");
      readdata = "";
    }
    else if(readdata.startsWith("1H"))
    {
      digitalWrite(pin1, HIGH);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("1L"))
    {
      digitalWrite(pin1, LOW);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("2H"))
    {
      digitalWrite(pin2, HIGH);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("2L"))
    {
      digitalWrite(pin2, LOW);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("3H"))
    {
      digitalWrite(pin3, HIGH);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("3L"))
    {
      digitalWrite(pin3, LOW);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("4H"))
    {
      digitalWrite(pin4, HIGH);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("4L"))
    {
      digitalWrite(pin4, LOW);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("5H"))
    {
      digitalWrite(pin5, HIGH);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("5L"))
    {
      digitalWrite(pin5, LOW);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("6H"))
    {
      digitalWrite(pin6, HIGH);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("6L"))
    {
      digitalWrite(pin6, LOW);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("7H"))
    {
      digitalWrite(pin7, HIGH);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("7L"))
    {
      digitalWrite(pin7, LOW);
     readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("8H"))
    {
      digitalWrite(pin8, HIGH);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("8L"))
    {
      digitalWrite(pin8, LOW);
      readdata = readdata.substring(2);
    }
    else if(readdata.startsWith("9H") || readdata.startsWith("9L"))
    {
      readdata = readdata.substring(2);
    }
    else if(
      readdata.startsWith("10H") || readdata.startsWith("10L") ||
      readdata.startsWith("11H") || readdata.startsWith("11L") ||
      readdata.startsWith("12H") || readdata.startsWith("12L") ||
      readdata.startsWith("13H") || readdata.startsWith("13L") ||
      readdata.startsWith("14H") || readdata.startsWith("14L") ||
      readdata.startsWith("15H") || readdata.startsWith("15L") ||
      readdata.startsWith("16H") || readdata.startsWith("16L") ||
      readdata.startsWith("17H") || readdata.startsWith("17L") ||
      readdata.startsWith("18H") || readdata.startsWith("18L") ||
      readdata.startsWith("19H") || readdata.startsWith("19L") ||
      readdata.startsWith("20H") || readdata.startsWith("20L") ||
      readdata.startsWith("21H") || readdata.startsWith("21L") ||
      readdata.startsWith("22H") || readdata.startsWith("22L") ||
      readdata.startsWith("23H") || readdata.startsWith("23L") ||
      readdata.startsWith("24H") || readdata.startsWith("24H"))
    {
      readdata = readdata.substring(3);
    }
    else if (readdata.startsWith("PWM")) {
      int endOfPwm = readdata.indexOf('#');
      if (endOfPwm != -1){
        String dutyCycleStr = readdata.substring(3, endOfPwm);
        int dutyValue = dutyCycleStr.toInt();
        analogWrite(PWM_PIN, dutyValue);
        readdata = readdata.substring(endOfPwm + 1);
      }
    }
  }
}
