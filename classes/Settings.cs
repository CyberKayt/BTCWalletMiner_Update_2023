using ProgramBitcoin;
namespace ProgramSettings
{
	public class Settings
	{
		public static BitcoinAddress userBitcoinAddress = new BitcoinAddress();
		public static double ProgramVersion = 0.1;
		public string ProgramLogo = @"
			______ _____ _____ _    _       _ _      _  ___  ____                 
			| ___ \_   _/  __ \ |  | |     | | |    | | |  \/  (_)                
			| |_/ / | | | /  \/ |  | | __ _| | | ___| |_| .  . |_ _ __   ___ _ __ 
			| ___ \ | | | |   | |/\| |/ _` | | |/ _ \ __| |\/| | | '_ \ / _ \ '__|
			| |_/ / | | | \__/\  /\  / (_| | | |  __/ |_| |  | | | | | |  __/ |   
			\____/  \_/  \____/\/  \/ \__,_|_|_|\___|\__\_|  |_/_|_| |_|\___|_|   
		";

		public void displayLogo()
		{
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine(ProgramLogo);
			Console.ResetColor();
		}

		public void displayVersion()
		{
			string ProgramVersionFixed = ProgramVersion.ToString().Replace(",", "."); //issue: comma instead of dot!
			Console.WriteLine("Current version: v" + ProgramVersionFixed);
		}

		public void displayCredits()
		{
			System.Console.OutputEncoding = System.Text.Encoding.UTF8; //allows the display of a copyright mark
			Console.WriteLine("Credits: Schwa/Rick Huisman © 2022");
		}

		public void displayFee()
		{
			Random rnd = new Random(3);
			int number = 0;
			number = rnd.Next();
			Console.WriteLine("Current fee: " + 0 + "." + number + " BTC");
		}

		public void setColors()
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}