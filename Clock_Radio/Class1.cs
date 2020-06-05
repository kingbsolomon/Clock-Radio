using System;

public class ClockRadio
{
	//Member Variables
	public string currentTime;
	public string currentStation;
	public bool isOn;
	public string alarmTime;


	//Constructor
	public ClockRadio(string currentTime, string currentStation, bool isOn, string alarmTime)
	{
		this.currentTime = currentTime;
		this.currentStation = currentStation;
		this.isOn = isOn;
		this.alarmTime = alarmTime;
	}

	//Member Methods
	public void GetCurrentTime()
    {
		currentTime = DateTime.Now.ToString("h:mm");
	}

	public void UserSetTime()
    {
		// I want to make this so it will correct the user
		Console.Write("Please Enter the Current Time in \"h:mm\" format: ");
		currentTime = Console.ReadLine();
    }

	public void SetStation()

    {
		Console.Write("Please Enter the Current Radio Station: ");
		currentStation = Console.ReadLine();
	}

	public void SetAlarm()
    {
		Console.Write("Please Enter Your Alarm Time: ");
		alarmTime = Console.ReadLine();
    }

	public void ToggleAlarm()
    {
		isOn = !isOn;
    }

	public void PrintClockSettings()
    {
		Console.WriteLine("");
		Console.WriteLine("Current Clock Settings Are:");
		Console.WriteLine("Current Time: " + currentTime);
		Console.WriteLine("Current Station: " + currentStation);
		Console.WriteLine("Current Alarm Time: " + alarmTime);
		Console.WriteLine("Is the alarm on? " + isOn);
		Console.WriteLine("");
    }

	public void AdjClockRadio()
    {
		bool adjustClock = true;
		string menuChoice;

		while (adjustClock)
        {
            Console.WriteLine("Press 1 to set the Clock Radio to the Current Time");
			Console.WriteLine("Press 2 to manually set the Clock Radio Time ");
			Console.WriteLine("Press 3 to set the Clock Radio Station ");
			Console.WriteLine("Press 4 to Set the Alarm ");
			Console.WriteLine("Press 5 to Toggle the Alarm ");
			Console.WriteLine("Press 6 to Exit ");
			menuChoice = Console.ReadLine();

			switch (menuChoice)
            {
				case "1":
					GetCurrentTime();
					PrintClockSettings();
					break;
				case "2":
					UserSetTime();
					PrintClockSettings();
					break;
				case "3":
					SetStation();
					PrintClockSettings();
					break;
				case "4":
					SetAlarm();
					PrintClockSettings();
					break;
				case "5":
					ToggleAlarm();
					PrintClockSettings();
					break;
				case "6":
					adjustClock = false;
					break;
				default:
					Console.WriteLine("Please enter a valid choice");
					break;
            }
			
        }
    }
}

