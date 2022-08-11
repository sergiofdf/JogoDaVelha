namespace JogoDaVelhaForm
{
    public class Jogador
    {
        public int Id { get; private set; }
        public char Signal { get; private set; }
        public Jogador(int id)
        {
            Id = id;
            if (id == 1)
            {
                Signal = 'X';
            }
            else
            {
                Signal = 'O';
            }
        }
    }
}
