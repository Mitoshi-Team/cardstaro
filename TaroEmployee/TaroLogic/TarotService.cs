namespace TaroEmployee.TaroLogic
{
    public class TarotService
    {
        public TarotCard CalculateLifePathCard(DateTime birthDate)
        {
            int sum = birthDate.Day + birthDate.Month + birthDate.Year;
            int lifePathNumber = ReduceToSingleDigit(sum);
            return TarotCards.MajorArcana[lifePathNumber];
        }

        public TarotCard CalculateYearCard(DateTime birthDate, int year)
        {
            int sum = year;
            int yearNumber = ReduceToSingleDigit(sum);
            return TarotCards.MajorArcana[yearNumber];
        }

        public int CalculateSuitNumber(DateTime birthDate)
        {
            int sum = birthDate.Day + birthDate.Month + birthDate.Year;
            return ReduceToSingleDigit(sum);
        }

        private int ReduceToSingleDigit(int number)
        {
            while (number > 21)
            {
                number = number.ToString().Sum(c => c - '0');
            }
            return number;
        }
    }
}
