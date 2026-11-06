int[] score = {75, 90, 60, 100, 80};

float total = 0, average;
int highestScore = 0;

for (int i = 0; i < score.Length; i++)
{
    Console.WriteLine($"Player {i+1}: {score[i]}");
    total += score[i];

    if (score[i] > highestScore)
    {
        highestScore = score [i];
    }
}

average = total / score.Length;

Console.WriteLine($"average score = {average}");
