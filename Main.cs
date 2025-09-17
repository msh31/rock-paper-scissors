using Godot;

public partial class Main : Godot.Node2D
{
	enum Moves
	{
		ROCK = 0,
		PAPER = 1,
		SCISSORS = 2
	};

	// assign nodes directly from the editor
	[Export] public ColorRect BackgroundNode;
	[Export] public TextureRect AIResult;
	
	private Texture2D rockTexture;
	private Texture2D paperTexture;
	private Texture2D scissorsTexture;

	public override void _Ready() {
		rockTexture = GD.Load<Texture2D>("res://rock.png");
		paperTexture = GD.Load<Texture2D>("res://paper.png");
		scissorsTexture = GD.Load<Texture2D>("res://scissors.png");
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

		if (playerMove == aiMove) {
			UpdateUI(Colors.Gray, aiMove);
		} else if ((playerMove == Moves.ROCK && aiMove == Moves.SCISSORS) ||
				 (playerMove == Moves.PAPER && aiMove == Moves.ROCK) ||
				 (playerMove == Moves.SCISSORS && aiMove == Moves.PAPER)) {
			UpdateUI(Colors.Green, aiMove);
		} else {
			UpdateUI(Colors.Red, aiMove);
		}
	}

	private void UpdateUI(Color color, Moves aiMove) {
		if (BackgroundNode != null && AIResult != null) {
			BackgroundNode.Color = color;
			
			if (aiMove == Moves.ROCK) {
				AIResult.Texture = rockTexture;
			}
			else if (aiMove == Moves.PAPER) 	{
				AIResult.Texture = paperTexture;
			}
			else {
				AIResult.Texture = scissorsTexture;
			}
		}
	}
}
