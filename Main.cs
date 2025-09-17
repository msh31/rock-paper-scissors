using Godot;
using System;

public partial class Main : Godot.Node2D 
{
	enum Moves { 
		ROCK, 
		PAPER, 
		SCISSORS 
	};
	
	public override void _Ready()  {
		
	}
	
	public void _on_rock_pressed() {
		battle(Moves.ROCK);
	}
	
	public void _on_paper_pressed() {
		battle(Moves.PAPER);
	}
	
	public void _on_scissor_pressed() {
		battle(Moves.SCISSORS);
	}
	
	private void battle(Moves playerMove) {
		switch(playerMove) {
			case Moves.ROCK:
				GD.Print("rock");
			break;
			case Moves.PAPER:
				GD.Print("paper");
			break;
			case Moves.SCISSORS:
				GD.Print("scissors");
			break;
		}
	}
}
