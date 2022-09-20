using Armazen.Models;
using Armazen.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Armazen.Data
{
    public class SeedingService
    {
        private ArmazenContext _context;

        public SeedingService(ArmazenContext context)//Criação de construtor do mesmo tipo para sinalizar que a injeção de depêndecias deve acontecer.
        {
            _context = context;

        }
        public void Seed()
        {
            if (_context.Deposito.Any() || _context.Deposito.Any() || _context.Deposito.Any())//Verificação se há algum registro na tabela Deposito

            {
                return;
            }
            else
            {

                Deposito d1 = new Deposito(1, "Computadores");

                Deposito d2 = new Deposito(2, "Placas de video");

                Deposito d3 = new Deposito(3, "Caixas de som");

                Deposito d4 = new Deposito(4, "Placa mãe");

                Deposito d5 = new Deposito(5, "Processadores");

                Deposito d6 = new Deposito(6, "Periféricos");


                Vendedor v1 = new Vendedor(1, "Rick Grimes", "RickGrimes@twd.com", new DateTime(1973, 09, 14), 15984.25, d2);

                Vendedor v2 = new Vendedor(2, "Daryl Dixon", "DarylDixon@twd.com", new DateTime(1969, 01, 06), 165154.48, d4);

                Vendedor v3 = new Vendedor(3, "Carol Peletier", "CarolPeletier@twd.com", new DateTime(1965, 05, 23), 178482.84, d1);

                Vendedor v4 = new Vendedor(4, "Michonne", "Michonne@twd.com", new DateTime(1978, 02, 14), 200000.78, d6);

                Vendedor v5 = new Vendedor(5, "Maggie Greene-Rhee", "MaggieGreene-Rhee@twd.com", new DateTime(1982, 01, 07), 174681.58, d3);

                Vendedor v6 = new Vendedor(6, "Negan", "Negan@twd.com", new DateTime(1966, 04, 22), 257948.75, d5);



                RegistroDeVenda r1 = new RegistroDeVenda(1, new DateTime(2018, 09, 25), 11000.0, StatusDeVenda.Cancelado, v2);

                RegistroDeVenda r2 = new RegistroDeVenda(2, new DateTime(2018, 09, 4), 7000.0, StatusDeVenda.Pendente, v5);

                RegistroDeVenda r3 = new RegistroDeVenda(3, new DateTime(2018, 09, 13), 4000.0, StatusDeVenda.Cancelado, v4);

                RegistroDeVenda r4 = new RegistroDeVenda(4, new DateTime(2018, 09, 1), 8000.0, StatusDeVenda.Faturado, v1);

                RegistroDeVenda r5 = new RegistroDeVenda(5, new DateTime(2018, 09, 21), 3000.0, StatusDeVenda.Faturado, v3);

                RegistroDeVenda r6 = new RegistroDeVenda(6, new DateTime(2018, 09, 15), 2000.0, StatusDeVenda.Faturado, v1);

                RegistroDeVenda r7 = new RegistroDeVenda(7, new DateTime(2018, 09, 28), 13000.0, StatusDeVenda.Faturado, v2);

                RegistroDeVenda r8 = new RegistroDeVenda(8, new DateTime(2018, 09, 11), 4000.0, StatusDeVenda.Faturado, v4);

                RegistroDeVenda r9 = new RegistroDeVenda(9, new DateTime(2018, 09, 14), 11000.0, StatusDeVenda.Pendente, v6);

                RegistroDeVenda r10 = new RegistroDeVenda(10, new DateTime(2018, 09, 7), 9000.0, StatusDeVenda.Faturado, v6);

                RegistroDeVenda r11 = new RegistroDeVenda(11, new DateTime(2018, 09, 13), 6000.0, StatusDeVenda.Faturado, v2);

                RegistroDeVenda r12 = new RegistroDeVenda(12, new DateTime(2018, 09, 25), 7000.0, StatusDeVenda.Faturado, v3);

                RegistroDeVenda r13 = new RegistroDeVenda(13, new DateTime(2018, 09, 29), 10000.0, StatusDeVenda.Faturado, v4);

                RegistroDeVenda r14 = new RegistroDeVenda(14, new DateTime(2018, 09, 4), 3000.0, StatusDeVenda.Faturado, v5);

                RegistroDeVenda r15 = new RegistroDeVenda(15, new DateTime(2018, 09, 12), 4000.0, StatusDeVenda.Faturado, v1);

                RegistroDeVenda r16 = new RegistroDeVenda(16, new DateTime(2018, 10, 5), 2000.0, StatusDeVenda.Faturado, v4);

                RegistroDeVenda r17 = new RegistroDeVenda(17, new DateTime(2018, 10, 1), 12000.0, StatusDeVenda.Faturado, v1);

                RegistroDeVenda r18 = new RegistroDeVenda(18, new DateTime(2018, 10, 24), 6000.0, StatusDeVenda.Faturado, v3);

                RegistroDeVenda r19 = new RegistroDeVenda(19, new DateTime(2018, 10, 22), 8000.0, StatusDeVenda.Faturado, v5);

                RegistroDeVenda r20 = new RegistroDeVenda(20, new DateTime(2018, 10, 15), 8000.0, StatusDeVenda.Faturado, v6);

                RegistroDeVenda r21 = new RegistroDeVenda(21, new DateTime(2018, 10, 17), 9000.0, StatusDeVenda.Faturado, v2);

                RegistroDeVenda r22 = new RegistroDeVenda(22, new DateTime(2018, 10, 24), 4000.0, StatusDeVenda.Faturado, v4);

                RegistroDeVenda r23 = new RegistroDeVenda(23, new DateTime(2018, 10, 19), 11000.0, StatusDeVenda.Cancelado, v2);

                RegistroDeVenda r24 = new RegistroDeVenda(24, new DateTime(2018, 10, 12), 8000.0, StatusDeVenda.Faturado, v5);

                RegistroDeVenda r25 = new RegistroDeVenda(25, new DateTime(2018, 10, 31), 7000.0, StatusDeVenda.Faturado, v3);

                RegistroDeVenda r26 = new RegistroDeVenda(26, new DateTime(2018, 10, 6), 5000.0, StatusDeVenda.Faturado, v4);

                RegistroDeVenda r27 = new RegistroDeVenda(27, new DateTime(2018, 10, 13), 9000.0, StatusDeVenda.Pendente, v1);

                RegistroDeVenda r28 = new RegistroDeVenda(28, new DateTime(2018, 10, 7), 4000.0, StatusDeVenda.Faturado, v3);

                RegistroDeVenda r29 = new RegistroDeVenda(29, new DateTime(2018, 10, 23), 12000.0, StatusDeVenda.Faturado, v5);

                RegistroDeVenda r30 = new RegistroDeVenda(30, new DateTime(2018, 10, 12), 5000.0, StatusDeVenda.Faturado, v2);

                _context.Deposito.AddRange(d1, d2, d3, d4, d5, d6);
                _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);
                _context.RegistroDeVendas.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30); //inclusão dos objetos no banco de dados

                _context.SaveChanges();
            }
        }

    }
}

