//Вам предстоит разработать систему управления умным домом, которая должна реагировать на различные события в доме и выполнять соответствующие действия. В доме есть различные устройства, такие как датчики движения, термостаты, светильники и т. д.

//Ваша задача состоит в следующем:

//Создайте классы для каждого типа устройства в доме. Например, классы MotionSensor, Thermostat, Light и т. д. Каждый класс должен иметь свои свойства и методы, относящиеся к данному типу устройства.

//Создайте событие с именем MotionDetectedEvent, которое будет генерироваться при обнаружении движения с помощью датчика движения. Событие должно предоставлять информацию о местоположении, времени и других деталях, связанных с обнаруженным движением.

//В классе SmartHomeSystem создайте метод RegisterMotionSensor, который будет принимать в качестве параметра объект типа MotionSensor и регистрировать его в системе.

//Создайте метод HandleMotionDetected, который будет вызываться при возникновении события MotionDetectedEvent. Этот метод должен принимать параметр типа EventArgs или наследника от EventArgs и выполнять соответствующие действия, например, включать свет или записывать видео.

//В классе SmartHomeSystem создайте метод StartMonitoring, который будет запускать мониторинг движения. Этот метод должен включать все зарегистрированные датчики движения и обрабатывать событие MotionDetectedEvent, вызывая метод HandleMotionDetected.

//Реализуйте метод Main, в котором создайте объект класса SmartHomeSystem, зарегистрируйте несколько объектов MotionSensor с помощью метода RegisterMotionSensor и запустите мониторинг с помощью метода StartMonitoring.

using System;
using System.Collections.Generic;
using ConsoleApp12;

class Program
{
    static void Main()
    {
        SmartHomeSystem smartHomeSystem = new SmartHomeSystem();

        MotionSensor motionSensor1 = new MotionSensor { Location = "Гостинная" };
        MotionSensor motionSensor2 = new MotionSensor { Location = "Спальня" };
        smartHomeSystem.RegisterMotionSensor(motionSensor1);
        smartHomeSystem.RegisterMotionSensor(motionSensor2);

        Thermostat thermostat = new Thermostat();

        smartHomeSystem.RegisterThermostat(thermostat);

        Light light = new Light();
        smartHomeSystem.RegisterLight(light);

        smartHomeSystem.StartMonitoring();

        thermostat.SetTemperature(22);
        light.TurnOn();
    }
}









//Account account = new Account(100);

//account.ChangeConsoleColor += ChangeConsoleColorHandler;
//account.Notify += DisplayMessage;

//account.Put(50);
//account.Take(50);


//void DisplayMessage(string message) => Console.WriteLine(message);

//void ChangeConsoleColorHandler(string action)
//{
//    if (action == "put")
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//    }
//    else if (action == "take")
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//    }
//}

//public class Account
//{

//    public delegate void AccountHandler(string message);

//    public event AccountHandler? ChangeConsoleColor;


//    public event AccountHandler? Notify;

//    public int Sum { get; set; }

//    public Account(int sum)
//    {
//        Sum = sum;
//    }


//    public void Put(int sum)
//    {
//        this.Sum += sum;
//        ChangeConsoleColor?.Invoke("put");
//        Notify?.Invoke($"на счет поступило {sum}");

//    }

//    public void Take(int sum)
//    {
//        if (Sum >= sum)
//        {
//            Sum -= sum;
//            ChangeConsoleColor?.Invoke("take");
//            Notify?.Invoke($"Cо счета было списано  {sum}");

//        }
//        else
//        {
//            Notify?.Invoke($"Недостаточно средств на балансе. Баланс:  {Sum}");
//        }
//    }
//}