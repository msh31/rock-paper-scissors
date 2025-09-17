using Godot;
using System;

public partial class Main : Godot.Node2D 
{
	public override void _Ready()  {
		
	}
	
	public void _on_rock_pressed() {
		GD.Print("rock");
		
		
	}
	
	public void _on_paper_pressed() {
		GD.Print("paper");
		
		
	}
	
	public void _on_scissor_pressed() {
		GD.Print("scissors");
		
	}
}
