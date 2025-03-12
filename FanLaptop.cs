using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300035
{
    class FanLaptop
    {
        private enum State{ Turbo, Quiet, Balanced, Performance };
        private State currentState;

        public FanLaptop()
        {
            currentState = State.Quiet;
            Console.WriteLine("Dalam mode Quiet");
        }

        public void processCommand(string command)
        {
            switch (currentState) {
                case State.Quiet:
                    if (command == "MODE UP")
                    {
                        currentState = State.Balanced;
                        Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                    } else if (command == "TURBO SHORTCUT")
                    {
                        currentState = State.Performance;
                        Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                    }
                    else
                    {
                        Console.WriteLine("Fan Quiet tetap dalam mode Quiet");
                    }
                    break;
                case State.Turbo:
                    if (command == "MODE DOWN")
                    {
                        currentState = State.Performance;
                        Console.WriteLine("Fan Turbo berubah menjadi Performance");
                    }
                    else if (command == "TURBO SHORTCUT")
                    {
                        currentState = State.Quiet;
                        Console.WriteLine("Fan Turbo berubah menjadi Quiet");
                    }
                    else
                    {
                        Console.WriteLine("Fan Turbo tetap dalam mode Turbo");
                    }
                    break;
                case State.Balanced:
                    if (command == "MODE DOWN")
                    {
                        currentState = State.Quiet;
                        Console.WriteLine("Fan Balanced berubah menjadi Quiet");
                    }
                    else if(command == "MODE UP")
                    {
                        currentState = State.Performance;
                        Console.WriteLine("Fan Balanced berubah menjadi Performance");
                    }
                    else
                    {
                        Console.WriteLine("Fan Balanced tetap dalam mode Balanced");
                    }
                    break;
                case State.Performance:
                    if (command == "MODE DOWN")
                    {
                        currentState = State.Balanced;
                        Console.WriteLine("Fan Performanced berubah menjadi Balanced");
                    }
                    else if(command == "MODE UP")
                    {
                        currentState = State.Turbo;
                        Console.WriteLine("Fan Performanced berubah menjadi Turbo");
                    }
                    else
                    {
                        Console.WriteLine("Fan Performance tetap dalam mode Performance");
                    }
                    break;
            }
        }
    }
}
