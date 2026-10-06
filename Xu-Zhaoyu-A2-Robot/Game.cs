using System;
using System.Numerics;

namespace MohawkGame2D;

public class Game
{
    // Robot position
    float robotX = 400;
    float robotY = 300;

    // Movement speed
    float speed = 4;

    public void Setup()
    {
        Window.SetSize(800, 600);
        Window.SetTitle("Interactive Robot");
    }

    public void Update()
    {
        Window.ClearBackground(Color.LightGray);

        // --------------------------------
        // KEYBOARD INPUT
        // --------------------------------

        if (Input.IsKeyboardKeyDown(KeyboardKey.Left))
        {
            robotX -= speed;
        }

        if (Input.IsKeyboardKeyDown(KeyboardKey.Right))
        {
            robotX += speed;
        }

        if (Input.IsKeyboardKeyDown(KeyboardKey.Up))
        {
            robotY -= speed;
        }

        if (Input.IsKeyboardKeyDown(KeyboardKey.Down))
        {
            robotY += speed;
        }

        // --------------------------------
        // MOUSE INPUT
        // --------------------------------

        // Hold left mouse button to move
        // the robot to the mouse position.
        if (Input.IsMouseButtonDown(MouseButton.Left))
        {
            robotX = Input.GetMouseX();
            robotY = Input.GetMouseY();
        }

        // --------------------------------
        // KEEP ROBOT ON SCREEN
        // --------------------------------

        if (robotX < 110)
        {
            robotX = 110;
        }

        if (robotX > 690)
        {
            robotX = 690;
        }

        if (robotY < 190)
        {
            robotY = 190;
        }

        if (robotY > 475)
        {
            robotY = 475;
        }

        // --------------------------------
        // ANTENNA
        // --------------------------------

        Draw.LineColor = Color.Black;
        Draw.LineSize = 4;

        Draw.Line(
            robotX,
            robotY - 140,
            robotX,
            robotY - 175
        );

        Draw.FillColor = Color.Red;

        Draw.Circle(
            robotX,
            robotY - 180,
            10
        );

        // --------------------------------
        // HEAD
        // --------------------------------

        Draw.FillColor = Color.Gray;
        Draw.LineColor = Color.Black;
        Draw.LineSize = 3;

        Draw.Rectangle(
            robotX - 50,
            robotY - 140,
            100,
            70
        );

        // --------------------------------
        // EYES
        // --------------------------------

        Draw.FillColor = Color.White;

        Draw.Circle(
            robotX - 25,
            robotY - 115,
            12
        );

        Draw.Circle(
            robotX + 25,
            robotY - 115,
            12
        );

        Draw.FillColor = Color.Blue;

        Draw.Circle(
            robotX - 25,
            robotY - 115,
            5
        );

        Draw.Circle(
            robotX + 25,
            robotY - 115,
            5
        );

        // --------------------------------
        // MOUTH
        // --------------------------------

        Draw.LineColor = Color.Black;
        Draw.LineSize = 4;

        Draw.Line(
            robotX - 20,
            robotY - 85,
            robotX + 20,
            robotY - 85
        );

        // --------------------------------
        // BODY COLOR INPUT
        // --------------------------------

        // Space makes the robot green.
        if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
        {
            Draw.FillColor = Color.Green;
        }

        // Right mouse button makes it red.
        else if (Input.IsMouseButtonDown(MouseButton.Right))
        {
            Draw.FillColor = Color.Red;
        }

        else
        {
            Draw.FillColor = Color.Blue;
        }

        // --------------------------------
        // BODY
        // --------------------------------

        Draw.LineColor = Color.Black;
        Draw.LineSize = 3;

        Draw.Rectangle(
            robotX - 60,
            robotY - 65,
            120,
            110
        );

        // --------------------------------
        // BODY LIGHT
        // --------------------------------

        Draw.FillColor = Color.Yellow;

        Draw.Circle(
            robotX,
            robotY - 15,
            15
        );

        // --------------------------------
        // ARMS
        // --------------------------------

        Draw.LineColor = Color.Black;
        Draw.LineSize = 8;

        Draw.Line(
            robotX - 60,
            robotY - 30,
            robotX - 100,
            robotY + 10
        );

        Draw.Line(
            robotX + 60,
            robotY - 30,
            robotX + 100,
            robotY + 10
        );

        // Hands
        Draw.FillColor = Color.Gray;

        Draw.Circle(
            robotX - 105,
            robotY + 15,
            12
        );

        Draw.Circle(
            robotX + 105,
            robotY + 15,
            12
        );

        // --------------------------------
        // LEGS
        // --------------------------------

        Draw.FillColor = Color.DarkGray;
        Draw.LineColor = Color.Black;
        Draw.LineSize = 3;

        Draw.Rectangle(
            robotX - 45,
            robotY + 45,
            30,
            60
        );

        Draw.Rectangle(
            robotX + 15,
            robotY + 45,
            30,
            60
        );

        // --------------------------------
        // FEET
        // --------------------------------

        Draw.FillColor = Color.Black;

        Draw.Rectangle(
            robotX - 55,
            robotY + 100,
            45,
            20
        );

        Draw.Rectangle(
            robotX + 10,
            robotY + 100,
            45,
            20
        );
    }
}