using System;
string? l1 = Console.ReadLine();
if (string.IsNullOrEmpty(l1)) return;
int n = int.Parse(l1);
string[] ent = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(ent[i]);
}
// --- INICIO DE LÓGICA DEL ALUMNO ---
// Instrucción: El alumno debe encontrar el valor máximo del arreglo 'a'
int m = a[0];
for (int i = 1; i < n; ++i)
{    int x = a[i];
    if (x > m) m = x; 
}
// TODO: Implementar el algoritmo de búsqueda aquí

// --- FIN DE LÓGICA DEL ALUMNO ---

// 2. Salida: Lo que el Autograding comparará
Console.WriteLine(m);
