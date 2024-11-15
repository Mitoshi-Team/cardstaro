namespace TaroEmployee.TaroLogic
{
    public class TarotCard
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public TarotCard(int number, string name)
        {
            Number = number;
            Name = name;
        }
    }
}
