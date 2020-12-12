using System;

public interface IReact
{
	/// <summary>
	/// defines the relationship between an integer number and a variable name
	/// allows you to use meaningful representations of values for character movement
	/// maps numbers 1 to 4 to names
	/// </summary>
	public enum MovementDirection {North, South, East, West};

	/// <summary>
	/// Converts a character for movement into a numeric value derived from the IReact.MovementDirection enum
	/// </summary>
	/// <param name="direction">a single character representing a key direction from wasd and ijkl</param>
	/// <returns>returns to numeric representation of the direction from MovementDirection</returns>
	public int Move(char direction);

	/// <summary>
	/// Converts an integer into the correct MovementDirection enum value
	/// </summary>
	/// <param name="direction">the int value which needs to be converted into a MovmenentDirection </param>
	/// <returns>the affiliated MovementDirection value that equals the given int direction</returns>
	public MovementDirection Move(int direction);

	/// <summary>
	/// converts a given string to its upper case version and returns it
	/// </summary>
	/// <param name="message">the mixed case message</param>
	/// <returns>an upper case version of the supplied message.</returns>
	public string ConvertToUpper(string message);

}
