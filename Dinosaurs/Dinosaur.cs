namespace Dinosaurs;

public class Dinosaur
{
	private Era _era;
	public String Era { get => _era.ToString(); }

	public String? Name { get; set; }

	public String? Description { get; set; }

	public int Rating { get; set; }

	public Dinosaur(Era era, String name, String description, int rating) {
		this._era = era;
		this.Name = name;
		this.Description = description;
		this.Rating = rating;
	}
}
