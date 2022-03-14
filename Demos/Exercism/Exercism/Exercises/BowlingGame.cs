namespace Exercism.Exercises;

public class BowlingGame
{
    public const uint FramesPerGame = 10;
    public const uint PinsPerFrame = 10;
    public const uint RollsPerFrame = 2;

    private uint score = 0;
    private uint framesCompleted = 0;
    private uint pinsUp = PinsPerFrame;
    private uint rollsThisFrame = 0;
    private uint bonus1 = 0;
    private uint bonus2 = 0;

    public void Roll(int pins)
    {
        if (Complete)
            throw new ArgumentException("Game is complete; can't roll");
 
        if (pins < 0)
            throw new ArgumentException("Can't roll negative pins");
        
        if (pins > pinsUp)
            throw new ArgumentException($"There are only {pinsUp} pins up; can't roll {pins} pins");
        
        ++rollsThisFrame;
        pinsUp -= (uint)pins;
        bool isFill = framesCompleted >= FramesPerGame;
        uint multiplier = (isFill ? 0u : 1u) + bonus1 + bonus2;
        score += (uint)pins * multiplier;
        bonus1 = bonus2;
        bonus2 = 0;

        if (pinsUp > 0 && rollsThisFrame < RollsPerFrame)
            return;
        
        // Advance to next frame.
        if (pinsUp == 0 && !isFill)
        {
            if (rollsThisFrame == RollsPerFrame)
                ++bonus1; // Spare.
            else
                ++bonus2; // Strike.
        }

        rollsThisFrame = 0;
        pinsUp = PinsPerFrame;
        ++framesCompleted;
    }

    public int Score() => 
        Complete ? (int)score : throw new ArgumentException("Game incomplete; can't score");
   
    public bool Complete =>
        framesCompleted >= FramesPerGame && bonus1 == 0 && bonus2 == 0;
}