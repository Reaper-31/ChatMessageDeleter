using System;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace DiscordBot
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            InputSimulator simulator = new InputSimulator();

            while (isRunning)
            {
                // Press Arrow Up
                simulator.Keyboard.KeyPress(VirtualKeyCode.UP);
                Thread.Sleep(100);

                // Press CTRL + A
                simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_A);
                Thread.Sleep(100);

                // Press Delete
                simulator.Keyboard.KeyPress(VirtualKeyCode.DELETE);

                // Press Enter
                simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(100);

                // Press Enter again
                simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(100);

                // Press Enter again
                simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(100);

                // Press Backspace
                simulator.Keyboard.KeyPress(VirtualKeyCode.BACK);

                // Check if F2 is pressed to pause the loop
                if (simulator.InputDeviceState.IsKeyDown(VirtualKeyCode.F2))
                {
                    isRunning = false
                }
            }
        }
    }
}
