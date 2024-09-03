using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        PriorityQueue<string, int> filaDePacientes = new PriorityQueue<string, int>();

        filaDePacientes.Enqueue("Paciente 1", 2);
        filaDePacientes.Enqueue("Paciente 2", 5);
        filaDePacientes.Enqueue("Paciente 3", 1);
        filaDePacientes.Enqueue("Paciente 4", 3);
        filaDePacientes.Enqueue("Paciente 5", 4);
        filaDePacientes.Enqueue("Paciente 6", 2);
        filaDePacientes.Enqueue("Paciente 7", 5);
        filaDePacientes.Enqueue("Paciente 8", 1);
        filaDePacientes.Enqueue("Paciente 9", 3);
        filaDePacientes.Enqueue("Paciente 10", 4);
        filaDePacientes.Enqueue("Paciente 11", 2);
        filaDePacientes.Enqueue("Paciente 12", 5);
        filaDePacientes.Enqueue("Paciente 13", 1);
        filaDePacientes.Enqueue("Paciente 14", 3);
        filaDePacientes.Enqueue("Paciente 15", 4);
        filaDePacientes.Enqueue("Paciente 16", 2);
        filaDePacientes.Enqueue("Paciente 17", 5);
        filaDePacientes.Enqueue("Paciente 18", 1);
        filaDePacientes.Enqueue("Paciente 19", 3);
        filaDePacientes.Enqueue("Paciente 20", 4);

        Console.WriteLine("Atendiendo a los pacientes según su prioridad:");
        while (filaDePacientes.Count > 0)
        {
            var paciente = filaDePacientes.Dequeue();
            Console.WriteLine($"Atendiendo a: {paciente}");
        }
    }
}
