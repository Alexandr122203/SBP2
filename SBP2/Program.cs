string fullName = "Воротынцев Александр Андреевич";
int Age = 24;
string Email = "sobaken3245@gmail.com";
double programmingScores = 78.12;
double mathScores = 56.67;
double physicsScores = 81.22;

string inf = "Ф.И.О: {0}\nВозраст: {1}\nEmail: {2}\nБаллы по програмированию: {3}\nБаллы по математике: {4}\nБаллы по физике: {5}";
Console.WriteLine(inf,
   fullName,
   Age,
   Email,
   programmingScores,
   mathScores,
   physicsScores);
Console.ReadKey();

double totalScore = programmingScores+ mathScores+ physicsScores;
double averageScore = totalScore/3;
Console.WriteLine($"Сумма баллов: {totalScore:0.00}\nСредний балл: {averageScore:0.00}");
Console.ReadKey();
