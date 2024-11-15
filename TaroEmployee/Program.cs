using TaroEmployee.TaroLogic;

Console.WriteLine("������� ���� �������� (������: ��.��.����):");
string birthDateInput = Console.ReadLine();
DateTime birthDate = DateTime.ParseExact(birthDateInput, "dd.MM.yyyy", null);

Console.WriteLine("������� ��� ��� ������� ����� ����:");
int year = int.Parse(Console.ReadLine());

TarotService tarotService = new TarotService();

TarotCard lifePathCard = tarotService.CalculateLifePathCard(birthDate);
TarotCard yearCard = tarotService.CalculateYearCard(birthDate, year);
int suitNumber = tarotService.CalculateSuitNumber(birthDate);

Console.WriteLine($"����� ���������� ����: {lifePathCard.Name}");
Console.WriteLine($"����� ����: {yearCard.Name}");
Console.WriteLine($"����� ��� ������ ����� ����: {suitNumber}");