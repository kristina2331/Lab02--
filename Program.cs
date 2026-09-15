Console.WriteLine("Границы численных типов");
Console.WriteLine($"byte:  {byte.MinValue}  {byte.MaxValue}");
Console.WriteLine($"short: {short.MinValue}  {short.MaxValue}");
Console.WriteLine($"int:  {int.MinValue}  {int.MaxValue}");
Console.WriteLine($"long:  {long.MinValue}  {long.MaxValue}");

Console.WriteLine();
Console.WriteLine("Границы дробных типов");
Console.WriteLine($"float:  {float.MinValue}  {float.MaxValue}");
Console.WriteLine($"double:  {double.MinValue}  {double.MaxValue}");
Console.WriteLine($"decimal:  {decimal.MinValue}  {decimal.MaxValue}");

Console.WriteLine();
Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overflowed}");

Console.WriteLine();
Console.WriteLine("char");

char firstLetter = 'A';
char separator = '-';
int charAsNumber = firstLetter;
Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
Console.WriteLine($"Тамбуляция: \tпосле таба");
Console.WriteLine($"Перенос: \nпосле переноса");

Console.WriteLine();
Console.WriteLine("decimal против double");

double priceDouble = 0.1 + 0.2;
decimal priceDecimal = 0.1m + 0.2m;

Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDouble}");

Console.WriteLine();
Console.WriteLine("Ввод текста");

Console.WriteLine("Кристина");
string enteredName = Console.ReadLine();

Console.Write("ИСП253");
string enteredGroup = Console.ReadLine();

Console.WriteLine($"Зравствуйте, {enteredName} из группы {enteredGroup}!");

Console.WriteLine();
Console.WriteLine("Ввод чисел: Convert и Parse");
Console.Write("2009");
string birthYearInput = Console.ReadLine();

int birthYearConvert = Convert.ToInt32(birthYearInput);
int birthYearParse = int.Parse(birthYearInput);

Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
Console.WriteLine($"int.Parse:       {birthYearParse}");
Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

Console.WriteLine();
Console.WriteLine("Ввод чисел: TryParse");

Console.Write("5");
string booksInput = Console.ReadLine();

bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
Console.WriteLine($"Значение переменной booksCount: {booksCount}");

Console.Write("Введите имя и фамилию: ");
string name = Console.ReadLine();

Console.Write("Введите группу: ");
string group = Console.ReadLine();

Console.Write("Введите год рождения: ");
int year = int.Parse(Console.ReadLine());

Console.Write("Введите средний балл: ");
string scoreText = Console.ReadLine();
double score = double.Parse(Console.ReadLine());

Console.Write("Введите любимую букву: ");
char letter = Console.ReadLine()[0];

int age = 2030 - year;
bool goodScore = score >= 4.0;

Console.WriteLine();
Console.WriteLine("Анкета");
Console.WriteLine($"{name}, группа {group}");
Console.WriteLine($"Год рождения: {year} (в 2030 будет {age} лет)");
Console.WriteLine($"Средний балл: {score}");
Console.WriteLine($"Балл >= 4.0: {goodScore}");
Console.WriteLine($"Любимая буква: {letter}");

