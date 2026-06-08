using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TutorAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            TutorBot tutor = new TutorBot();
            tutor.Iniciar();
        }
    }

    class TutorBot
    {
        private string nombreUsuario = "";
        private int puntaje = 0;
        private int preguntasRespondidas = 0;
        private Random rng = new Random();

        public void Iniciar()
        {
            MostrarBienvenida();
            Console.Write("¿Cuál es tu nombre? ");
            nombreUsuario = Console.ReadLine()?.Trim() ?? "Estudiante";

            Console.WriteLine($"\nHola, {nombreUsuario}! Soy tu tutor de álgebra. Escribe 'ayuda' para ver los comandos.\n");

            BucleConversacion();
        }

        private void MostrarBienvenida()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║      TUTOR DE ÁLGEBRA  v1.0          ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.ResetColor();
        }

        private void BucleConversacion()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\n[{nombreUsuario}] > ");
                Console.ResetColor();

                string entrada = Console.ReadLine()?.Trim().ToLower() ?? "";

                if (string.IsNullOrEmpty(entrada)) continue;

                string respuesta = ProcesarEntrada(entrada);

                if (respuesta == "SALIR") break;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n[Tutor] {respuesta}");
                Console.ResetColor();
            }

            MostrarDespedida();
        }

        private string ProcesarEntrada(string entrada)
        {
            if (entrada == "salir" || entrada == "exit") return "SALIR";
            if (entrada == "ayuda" || entrada == "help") return MostrarAyuda();
            if (entrada == "puntaje" || entrada == "score") return $"Tu puntaje actual es: {puntaje}/{preguntasRespondidas * 10} puntos.";
            if (entrada.StartsWith("resolver ")) return ResolverEcuacion(entrada.Substring(9).Trim());
            if (entrada.StartsWith("explicar ")) return ExplicarConcepto(entrada.Substring(9).Trim());
            if (entrada == "practica" || entrada == "ejercicio") return GenerarEjercicio();
            if (entrada.StartsWith("verificar ")) return VerificarRespuesta(entrada.Substring(10).Trim());
            if (entrada == "temas") return ListarTemas();

            return ResponderConversacion(entrada);
        }

        private string MostrarAyuda()
        {
            return @"Comandos disponibles:
  resolver [ecuación]   → Te explico cómo resolver una ecuación
  explicar [tema]       → Explico un concepto algebraico
  practica              → Te doy un ejercicio aleatorio
  verificar [respuesta] → Verifico tu respuesta al último ejercicio
  temas                 → Veo los temas disponibles
  puntaje               → Veo tu puntaje actual
  salir                 → Terminar sesión

Temas: ecuaciones lineales, ecuaciones cuadráticas, factorización,
       sistemas de ecuaciones, desigualdades, exponentes, logaritmos";
        }

        private string ListarTemas()
        {
            return @"Temas que puedo explicar:
  1. ecuaciones lineales
  2. ecuaciones cuadraticas
  3. factorizacion
  4. sistemas de ecuaciones
  5. desigualdades
  6. exponentes
  7. logaritmos
  8. funciones
  
Escribe: explicar [tema]";
        }

        private string ExplicarConcepto(string tema)
        {
            return tema switch
            {
                "ecuaciones lineales" or "ecuacion lineal" =>
                    @"ECUACIONES LINEALES
────────────────────
Forma: ax + b = c
Objetivo: despejar 'x'

Pasos:
  1. Mover términos con 'x' al lado izquierdo
  2. Mover constantes al lado derecho
  3. Dividir por el coeficiente de 'x'

Ejemplo: 2x + 4 = 10
  → 2x = 10 - 4
  → 2x = 6
  → x  = 3  ✓",

                "ecuaciones cuadraticas" or "ecuacion cuadratica" =>
                    @"ECUACIONES CUADRÁTICAS
───────────────────────
Forma: ax² + bx + c = 0

Método 1 - Fórmula general:
  x = (-b ± √(b²-4ac)) / 2a

Método 2 - Factorización:
  Busca dos números que multiplicados = c
  y sumados = b

Ejemplo: x² + 5x + 6 = 0
  Factores de 6 que suman 5: 2 y 3
  (x + 2)(x + 3) = 0
  x = -2  o  x = -3  ✓",

                "factorizacion" or "factorización" =>
                    @"FACTORIZACIÓN
──────────────
Es expresar un polinomio como producto de factores.

Técnicas comunes:
  1. Factor común:     6x² + 4x = 2x(3x + 2)
  2. Diferencia cuadrados: a²-b² = (a+b)(a-b)
  3. Trinomio perfecto: x²+2ax+a² = (x+a)²
  4. Por agrupación: para polinomios de 4 términos",

                "sistemas de ecuaciones" or "sistema de ecuaciones" =>
                    @"SISTEMAS DE ECUACIONES
───────────────────────
Dos ecuaciones con dos incógnitas.

Métodos:
  1. Sustitución: despejas una variable y sustituyes
  2. Eliminación: sumas/restas ecuaciones para eliminar variable
  3. Gráfico: intersección de rectas

Ejemplo (sustitución):
  x + y = 5  →  x = 5 - y
  2x - y = 4  →  2(5-y) - y = 4
              →  10 - 2y - y = 4
              →  y = 2,  x = 3  ✓",

                "desigualdades" =>
                    @"DESIGUALDADES
──────────────
Similar a ecuaciones pero con <, >, ≤, ≥

Regla importante:
  ⚠ Al multiplicar/dividir por número NEGATIVO,
    el signo de desigualdad se INVIERTE.

Ejemplo: -2x > 6
  x < -3  (signo invertido al dividir por -2)

La solución es un intervalo, no un punto.",

                "exponentes" =>
                    @"EXPONENTES
───────────
Leyes:
  aᵐ · aⁿ = aᵐ⁺ⁿ
  aᵐ / aⁿ = aᵐ⁻ⁿ
  (aᵐ)ⁿ  = aᵐⁿ
  a⁰      = 1
  a⁻ⁿ     = 1/aⁿ
  a^(1/n) = ⁿ√a",

                "logaritmos" =>
                    @"LOGARITMOS
───────────
log_b(x) = y  significa  b^y = x

Propiedades:
  log(ab)  = log(a) + log(b)
  log(a/b) = log(a) - log(b)
  log(aⁿ)  = n·log(a)
  log_b(b) = 1
  log_b(1) = 0

Cambio de base: log_b(x) = ln(x)/ln(b)",

                "funciones" =>
                    @"FUNCIONES
──────────
Una función f asigna exactamente un valor y a cada x.
Notación: f(x) o y = f(x)

Tipos comunes:
  Lineal:     f(x) = mx + b
  Cuadrática: f(x) = ax² + bx + c
  Exponencial:f(x) = aˣ
  Logarítmica:f(x) = log(x)

Dominio: valores permitidos de x
Rango: valores posibles de f(x)",

                _ => $"No tengo información sobre '{tema}'. Escribe 'temas' para ver los disponibles."
            };
        }

        // ── Ejercicios ────────────────────────────────────────────────
        private int _respuestaCorrecta;
        private string _tipoEjercicio = "";

        private string GenerarEjercicio()
        {
            int tipo = rng.Next(4);
            return tipo switch
            {
                0 => GenerarEcuacionLineal(),
                1 => GenerarOperacionExponente(),
                2 => GenerarSumaPolinomios(),
                _ => GenerarFactorSimple()
            };
        }

        private string GenerarEcuacionLineal()
        {
            int a = rng.Next(1, 6);
            int x = rng.Next(1, 11);
            int b = rng.Next(1, 10);
            int c = a * x + b;

            _respuestaCorrecta = x;
            _tipoEjercicio = "numero";

            return $@"EJERCICIO — Ecuación lineal
───────────────────────────
Resuelve para x:

  {a}x + {b} = {c}

Escribe: verificar [tu respuesta]";
        }

        private string GenerarOperacionExponente()
        {
            int baseNum = rng.Next(2, 5);
            int exp1 = rng.Next(1, 4);
            int exp2 = rng.Next(1, 4);

            _respuestaCorrecta = exp1 + exp2;
            _tipoEjercicio = "exponente";

            return $@"EJERCICIO — Exponentes
───────────────────────
Simplifica (escribe solo el exponente resultante):

  {baseNum}^{exp1} × {baseNum}^{exp2} = {baseNum}^?

Escribe: verificar [exponente]";
        }

        private string GenerarSumaPolinomios()
        {
            int a1 = rng.Next(1, 6), b1 = rng.Next(1, 8);
            int a2 = rng.Next(1, 6), b2 = rng.Next(1, 8);

            _respuestaCorrecta = a1 + a2;
            _tipoEjercicio = "coeficiente";

            return $@"EJERCICIO — Suma de polinomios
────────────────────────────────
¿Cuál es el coeficiente de x en la suma?

  ({a1}x + {b1}) + ({a2}x + {b2})

Escribe: verificar [coeficiente de x]";
        }

        private string GenerarFactorSimple()
        {
            int factor = rng.Next(2, 6);
            int a = factor * rng.Next(2, 5);
            int b = factor * rng.Next(2, 5);

            _respuestaCorrecta = factor;
            _tipoEjercicio = "numero";

            return $@"EJERCICIO — Factor común
────────────────────────
¿Cuál es el máximo factor común?

  {a}x + {b}

Escribe: verificar [factor]";
        }

        private string VerificarRespuesta(string respuesta)
        {
            if (_tipoEjercicio == "")
                return "Primero pide un ejercicio con: practica";

            if (!int.TryParse(respuesta, out int valor))
                return "Por favor escribe solo el número como respuesta.";

            preguntasRespondidas++;

            if (valor == _respuestaCorrecta)
            {
                puntaje += 10;
                _tipoEjercicio = "";
                return $"✅ ¡Correcto! Muy bien, {nombreUsuario}. +10 puntos. Total: {puntaje} pts";
            }
            else
            {
                _tipoEjercicio = "";
                return $"❌ Incorrecto. La respuesta era {_respuestaCorrecta}. ¡Sigue practicando!";
            }
        }

        // ── Resolver ecuación ─────────────────────────────────────────
        private string ResolverEcuacion(string ecuacion)
        {
            // Intenta detectar ax + b = c
            var match = Regex.Match(ecuacion, @"(-?\d*)x\s*([+-]\s*\d+)?\s*=\s*(-?\d+)");
            if (match.Success)
            {
                string aStr = match.Groups[1].Value.Replace(" ", "");
                string bStr = match.Groups[2].Value.Replace(" ", "");
                string cStr = match.Groups[3].Value.Replace(" ", "");

                double a = string.IsNullOrEmpty(aStr) || aStr == "-" ? (aStr == "-" ? -1 : 1) : double.Parse(aStr);
                double b = string.IsNullOrEmpty(bStr) ? 0 : double.Parse(bStr);
                double c = double.Parse(cStr);

                double x = (c - b) / a;

                return $@"Resolviendo: {ecuacion}
  Paso 1: Mover constante   →  {a}x = {c} - ({b}) = {c - b}
  Paso 2: Dividir por {a}    →  x = {c - b} / {a}
  Resultado:                    x = {x}

Verificación: {a}({x}) + {b} = {a * x + b} = {c} ✓";
            }

            return $"No pude interpretar '{ecuacion}'. Prueba formato: 2x + 3 = 7";
        }

        // ── Conversación general ──────────────────────────────────────
        private string ResponderConversacion(string entrada)
        {
            if (entrada.Contains("hola") || entrada.Contains("hi"))
                return $"¡Hola {nombreUsuario}! ¿En qué tema de álgebra necesitas ayuda?";

            if (entrada.Contains("gracias"))
                return "¡Con mucho gusto! El algebra puede ser difícil, pero con práctica lo dominas. 💪";

            if (entrada.Contains("no entiendo") || entrada.Contains("confundido"))
                return "No te preocupes. Escribe 'explicar [tema]' y lo explico paso a paso. ¿Qué tema te confunde?";

            if (entrada.Contains("dificil") || entrada.Contains("difícil"))
                return "El álgebra requiere práctica. Empieza con 'practica' para ejercicios simples, y usa 'explicar [tema]' cuando necesites repasar.";

            if (entrada.Contains("que eres") || entrada.Contains("quien eres"))
                return $"Soy tu tutor virtual de álgebra. Puedo explicar conceptos, resolver ecuaciones y darte ejercicios. ¡Estoy aquí para ayudarte, {nombreUsuario}!";

            return "No entendí eso. Escribe 'ayuda' para ver qué puedo hacer, o 'temas' para ver los temas disponibles.";
        }

        private void MostrarDespedida()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n╔══════════════════════════════════════╗");
            Console.WriteLine($"║  ¡Hasta pronto, {nombreUsuario,20} ║");
            Console.WriteLine($"║  Puntaje final: {puntaje,5} / {preguntasRespondidas * 10,-5} puntos  ║");
            Console.WriteLine($"╚══════════════════════════════════════╝");
            Console.ResetColor();
        }
    }
}