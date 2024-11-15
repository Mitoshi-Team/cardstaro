using TaroEmployee.TaroLogic;

Console.WriteLine("Введите дату рождения (формат: дд.мм.гггг):");
string birthDateInput = Console.ReadLine();
DateTime birthDate = DateTime.ParseExact(birthDateInput, "dd.MM.yyyy", null);

Console.WriteLine("Введите год для расчета карты года:");
int year = int.Parse(Console.ReadLine());

TarotService tarotService = new TarotService();

TarotCard lifePathCard = tarotService.CalculateLifePathCard(birthDate);
TarotCard yearCard = tarotService.CalculateYearCard(birthDate, year);
int suitNumber = tarotService.CalculateSuitNumber(birthDate);

Console.WriteLine($"Карта жизненного пути: {lifePathCard.Name}");
Console.WriteLine($"Карта года: {yearCard.Name}");
Console.WriteLine($"Число для мастей карты Таро: {suitNumber}");