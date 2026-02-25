using System;
string? linea1 = Console.ReadLine();
if (string.IsNullOrEmpty(linea1)) return;
int n = int.Parse(linea1);
string[] entrada = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
int[] numeros = new int[n];
for (int i = 0; i < n; i++)
{
    numeros[i] = int.Parse(entrada[i]);
}
// --- INICIO DE LÓGICA DEL ALUMNO ---
int m = numeros[0];

for (int i = 1; i < n; ++i) {
    int n = numeros[i];
    if (n > m) m = n;
    }
// --- FIN DE LÓGICA DEL ALUMNO ---

Console.WriteLine(m);
