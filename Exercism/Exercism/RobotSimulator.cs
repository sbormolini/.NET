using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    public RobotSimulator(Direction direction, int x, int y) => (Direction, X, Y) = (direction, x, y);

    public Direction Direction { get; private set; }

    public int X { get; private  set; }

    public int Y { get; private set; }

    private void Advance()
    {
        switch (Direction)
        {
            case Direction.North:
                Y++;
                break;
            case Direction.East:
                X++;
                break;
            case Direction.South:
                Y--;
                break;
            case Direction.West:
                X--;
                break;
            default:
                break;
        }
    }

    private void RotateRight() => Direction = Direction switch
    {
        Direction.North => Direction.East,
        Direction.East => Direction.South,
        Direction.South => Direction.West,
        Direction.West => Direction.North,
        _ => throw new ArgumentOutOfRangeException()
    };

    private void RotateLeft() => Direction = Direction switch
    {
        Direction.North => Direction.West,
        Direction.East => Direction.North,
        Direction.South => Direction.East,
        Direction.West => Direction.South,
        _ => throw new ArgumentOutOfRangeException()
    };

    public void Move(string instructions)
    {
        foreach (var instruction in instructions)
        {
            switch (instruction)
            {
                case 'A':
                    Advance();
                    break;
                case 'R':
                    RotateRight();
                    break;
                case 'L':
                    RotateLeft();
                    break;
                default:
                    throw new ArgumentException($"Invalid Instruction {instruction}");
            }
        }
    }
}
