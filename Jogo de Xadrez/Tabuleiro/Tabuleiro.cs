﻿namespace Jogo_de_Xadrez.Tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linha, int colunas)
        {
            this.linhas = linha;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
    }
}
