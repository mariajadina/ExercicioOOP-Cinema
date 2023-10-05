﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class SalaModel
    {
        private List<Sala> salas = new List<Sala>();

        public void CriarLista()
        {
            Sala sala = new Sala();
            sala.Popular();
            salas.Add(sala);
        }

        public void LerLista()
        {
            for (int i = 0; i < salas.Count; i++)
            {
                Console.Write(i + 1);
                salas[i].Listar();
            }
        }

        public void AtualizarLista()
        {
            LerLista();
            Console.WriteLine("Digite o id do item que deseja alterar:");
            int id = Convert.ToInt32(Console.ReadLine());
            salas[id - 1].Popular();
        }

        public void RemoverItem()
        {
            LerLista();
            Console.WriteLine("Digite o id do item que deseja remover:");
            int id = Convert.ToInt32(Console.ReadLine());
            salas.RemoveAt(id - 1);
        }
    }
}