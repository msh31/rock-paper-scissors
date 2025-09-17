using Godot;
using System;

public partial class Main : Godot.Node2D 
{
    enum Moves { 
        ROCK = 0, 
        PAPER = 1, 
        SCISSORS = 2
    };
    
    private int randomNumber;
    
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
        Moves aiMove = (Moves)(GD.Randi() % 3);
        
        GD.Print($"You chose: {playerMove}");
        GD.Print($"AI chose: {aiMove}");
        
        if (playerMove == aiMove) {
            GD.Print("It's a tie!");
        } else if ((playerMove == Moves.ROCK && aiMove == Moves.SCISSORS) ||
                (playerMove == Moves.PAPER && aiMove == Moves.ROCK) ||
                (playerMove == Moves.SCISSORS && aiMove == Moves.PAPER)) {
            GD.Print("You win!");
        } else {
            GD.Print("You lose!");
        }
    }
}
