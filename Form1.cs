using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bot_Tutor_profesional
{
    public partial class Form1 : Form
    {
        // VARIABLES GLOBALES

        //Funcion de puntaje, ayuda y funcion de ejercicios aletorios
        private int puntaje = 0;
        private int preguntasRespondidas = 0;
        private Random rng = new Random();

        private int _valA = 0;
        private int _valB = 0;
        private int _valC = 0;

        private int _respuestaCorrecta;
        private string _tipoEjercicio = "";

        public Form1()
        {
            InitializeComponent();
            MostrarBienvenida();
        }


        //Inicio del bot
        private void MostrarBienvenida()
        {
            txtPantallaInfo.SelectionColor = Color.Cyan;
            txtPantallaInfo.AppendText("=========================================\n");
            txtPantallaInfo.AppendText("       TUTOR DE ÁLGEBRA V2.0 ACTIVADO    \n");
            txtPantallaInfo.AppendText("=========================================\n\n");
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("¡Hola! Presiona cualquiera de los temas de la izquierda para comenzar tu clase o generar ejercicios prácticos.\n\n");
        }

        //Habilitar cosas tecnicas de matematicas como exponenetes o logaritmo
        private void AppendFormatoMate(string textoBase, string superIndice = "", string subIndice = "")
        {
            txtPantallaInfo.SelectionCharOffset = 0;
            txtPantallaInfo.AppendText(textoBase);

            if (!string.IsNullOrEmpty(superIndice))
            {
                txtPantallaInfo.SelectionCharOffset = 7;
                txtPantallaInfo.SelectionFont = new Font(txtPantallaInfo.Font.FontFamily, 8, FontStyle.Bold);
                txtPantallaInfo.AppendText(superIndice);
            }
            if (!string.IsNullOrEmpty(subIndice))
            {
                txtPantallaInfo.SelectionCharOffset = -4;
                txtPantallaInfo.SelectionFont = new Font(txtPantallaInfo.Font.FontFamily, 8, FontStyle.Regular);
                txtPantallaInfo.AppendText(subIndice);
            }

            txtPantallaInfo.SelectionCharOffset = 0;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
        }

        //Decoracion del programa 
        private void Form1_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void txtPantallaInfo_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void txtRespuesta_TextChanged(object sender, EventArgs e) { }

        // DESIGUALDADES LINEALES
        private void button5_Click(object sender, EventArgs e)
        {
            txtPantallaInfo.Clear();
            txtPantallaInfo.AppendText(@"DESIGUALDADES LINEALES
──────────────────────
Forma básica: ax + b > c  (o <, ≥, ≤)
Objetivo primordial: Encontrar el conjunto de intervalos numéricos que hacen verdadera la inecuación.

Pasos para resolver:
  1. Despejar la incógnita 'x' aplicando las mismas reglas que en las ecuaciones lineales.
  2. ¡REGLA DE ORO!: Si multiplicas o divides ambos lados por un número NEGATIVO, la dirección del signo de la desigualdad se invierte.

Ejemplo resuelto:
  -2x > 6  →  x < 6 / (-2)  →  x < -3  ✓
──────────────────────
");
            //Crear un ejercicio aletorio
            int a = rng.Next(2, 6);
            int x = rng.Next(2, 8);
            int b = a * x;

            _valA = a;
            _valB = b;

            _respuestaCorrecta = x;
            _tipoEjercicio = "desigualdad";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA!\n");

            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.AppendText("Determina el valor límite (el número entero k) que resuelve la inecuación:\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText($"   {a}x >= {b}\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("Escribe la respuesta numérica abajo.");
            txtRespuesta.Focus();
        }

        // ECUACIONES CUADRÁTICAS
        private void button2_Click(object sender, EventArgs e)
        {
            txtPantallaInfo.Clear();
            txtPantallaInfo.AppendText(@"ECUACIONES CUADRÁTICAS
──────────────────────
Forma básica: ax² + bx + c = 0
Objetivo primordial: Encontrar los valores de 'x' que hacen que la ecuación sea igual a cero.

Pasos para resolver:
  1. Identificar los coeficientes 'a', 'b' y 'c'.
  2. Aplicar la fórmula general: x = (-b ± √(b² - 4ac)) / 2a
  3. Calcular las dos posibles soluciones (raíces).

Ejemplo resuelto:
  x² - 5x + 6 = 0  →  (x - 2)(x - 3) = 0  →  x = 2  o  x = 3  ✓
──────────────────────
");

            int r1 = rng.Next(1, 5);
            int r2 = rng.Next(5, 9);

            int b = -(r1 + r2);
            int c = r1 * r2;

            _valA = 1; 
            _valB = b;
            _valC = c;

            _respuestaCorrecta = r2;
            _tipoEjercicio = "cuadratica";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA!\n");

            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.AppendText("Encuentra la raíz MAYOR de la ecuación:\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText($"   x² {b:+#;-#;+0}x {c:+#;-#;+0} = 0\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("Escribe el valor numérico de la raíz mayor abajo.");
            txtRespuesta.Focus();
        }

        // ECUACIONES LINEALES
        private void button1_Click(object sender, EventArgs e)
        {
            txtPantallaInfo.Clear();
            string explicacion = @"ECUACIONES LINEALES
────────────────────
Forma básica: ax + b = c
Objetivo primordial: despejar la incógnita 'x'

Pasos para resolver:
  1. Mover términos con 'x' al lado izquierdo.
  2. Mover constantes los números solos al lado derecho.
  3. Dividir el resultado por el coeficiente que acompaña a 'x'.

Ejemplo resuelto:
  2x + 4 = 10
  → 2x = 10 - 4
  → 2x = 6
  → x  = 6 / 2
  → x  = 3  ✓
────────────────────
";
            txtPantallaInfo.AppendText(explicacion);

            int a = rng.Next(1, 6);
            int x = rng.Next(1, 11);
            int b = rng.Next(1, 10);
            int c = a * x + b;

            _valA = a;
            _valB = b;
            _valC = c;

            _respuestaCorrecta = x;
            _tipoEjercicio = "lineal";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA!\n");

            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.AppendText("Resuelve para x la siguiente ecuación:\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText($"   {a}x + {b} = {c}\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("Escribe tu respuesta numérica en el cuadro de abajo.");
            txtRespuesta.Focus();
        }

        // FACTORIZACIÓN
        private void button3_Click(object sender, EventArgs e)
        {
            txtPantallaInfo.Clear();
            txtPantallaInfo.AppendText(@"FACTORIZACIÓN (DIFERENCIA DE CUADRADOS)
───────────────────────────────────────
Forma básica: a² - b²
Objetivo primordial: Transformar una resta de cuadrados en un producto de binomios conjugados.

Pasos para resolver:
  1. Extraer la raíz cuadrada del primer término (√a² = a).
  2. Extraer la raíz cuadrada del segundo término (√b² = b).
  3. Escribir el resultado como la multiplicación de la suma por la resta de estas raíces: (a + b)(a - b).

Ejemplo resuelto:
  x² - 16  →  Raíces: x y 4  →  Resultado: (x - 4)(x + 4)  ✓
───────────────────────────────────────
");

            int n = rng.Next(2, 10);
            int b2 = n * n;

            _valA = b2; 

            _respuestaCorrecta = n;
            _tipoEjercicio = "factorizacion";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA!\n");

            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.AppendText($"Si x² - {b2} = (x - k)(x + k), ¿cuál es el valor de k?:\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText($"   x² - {b2}\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("Escribe tu respuesta abajo y presiona Enter.");
            txtRespuesta.Focus();
        }

        // EVALUACIÓN DE FUNCIONES
        private void button8_Click(object sender, EventArgs e)
        {
            txtPantallaInfo.Clear();
            txtPantallaInfo.AppendText(@"EVALUACIÓN DE FUNCIONES
───────────────────────
Forma básica: f(x) = mx + b
Objetivo primordial: Obtener el valor numérico de salida (imagen o variable dependiente) al introducir un valor específico de 'x'.

Pasos para resolver:
  1. Tomar el valor numérico dado para 'x'.
  2. Sustituir cada aparición de la letra 'x' en la función por ese número.
  3. Realizar las operaciones aritméticas correspondientes respetando la jerarquía.

Ejemplo resuelto:
  Dada f(x) = 3x + 2, evaluar f(4)  →  f(4) = 3(4) + 2  →  12 + 2 = 14  ✓
───────────────────────
");

            int m = rng.Next(2, 6);
            int b = rng.Next(1, 6);
            int x = rng.Next(1, 5);

            _valA = m;
            _valB = b;
            _valC = x;

            _respuestaCorrecta = m * x + b;
            _tipoEjercicio = "funciones";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA!\n");

            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.AppendText($"Dada la función f(x) = {m}x + {b}, evalúa f({x}):\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText($"   f({x}) = ?\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("Escribe el valor de f(x) abajo y presiona Enter.");
            txtRespuesta.Focus();
        }

        // VERIFICAR
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_tipoEjercicio))
            {
                MessageBox.Show("Primero selecciona un tema a la izquierda para generar un ejercicio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(txtRespuesta.Text.Trim(), out int valorUsuario))
            {
                MessageBox.Show("Por favor, escribe solo números enteros como respuesta.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            preguntasRespondidas++;
            txtPantallaInfo.AppendText("\n────────────────────────────────────────");

            if (valorUsuario == _respuestaCorrecta)
            {
                puntaje += 10;
                txtPantallaInfo.SelectionColor = Color.SpringGreen;
                txtPantallaInfo.AppendText($"\n¡CORRECTO! Excelente trabajo. +10 puntos.\n\n");
                txtPantallaInfo.AppendText($"Puntaje total acumulado: {puntaje} pts.\n\n");
                txtPantallaInfo.SelectionColor = Color.White;
                txtPantallaInfo.AppendText("Presiona cualquier botón para un nuevo problema.");
                _tipoEjercicio = "";
            }
            else
            {
                txtPantallaInfo.SelectionColor = Color.LightCoral;
                txtPantallaInfo.AppendText($"\n¡INCORRECTO. La respuesta real era: {_respuestaCorrecta}.\n\n");
                txtPantallaInfo.SelectionColor = Color.White;
                txtPantallaInfo.AppendText("¡No te preocupes! Selecciona un tema de la izquierda para volver a intentarlo.");
                _tipoEjercicio = "";
            }

            txtRespuesta.Clear();
        }

        // SISTEMAS DE ECUACIONES (2x2)
        private void button4_Click(object sender, EventArgs e)
        {
            txtPantallaInfo.Clear();
            txtPantallaInfo.AppendText(@"SISTEMAS DE ECUACIONES (2x2)
────────────────────────────
Forma básica:
  a₁x + b₁y = c₁
  a₂x + b₂y = c₂
Objetivo primordial: Encontrar el punto de intersección (x, y) que satisfaga ambas ecuaciones.

Pasos para resolver:
  1. Multiplicar una ecuación para igualar coeficientes pero con signos opuestos.
  2. Sumar las ecuaciones verticalmente para eliminar una variable.
  3. Despejar la variable restante y sustituir su valor en la otra ecuación.

Ejemplo resuelto:
  x + y = 5
  x - y = 1   → Al sumar: 2x = 6  →  x = 3, y = 2 ✓
────────────────────────────
");

            int x = rng.Next(1, 6);
            int y = rng.Next(1, 6);
            int r1 = x + y;
            int r2 = x - y;

            _valA = r1;
            _valB = r2;

            _respuestaCorrecta = x;
            _tipoEjercicio = "sistema";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA!\n");

            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.AppendText("Resuelve el sistema y determina SOLO el valor de 'x':\n\n");

            txtPantallaInfo.SelectionColor = Color.LightCyan;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText("   ⎧  x + y = " + r1 + "\n");
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText("   ⎩  x - y = " + r2 + "\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("Escribe tu respuesta numérica en el cuadro inferior.");
            txtRespuesta.Focus();
        }

        // EXPONENTES
        private void button6_Click(object sender, EventArgs e)
        {
            txtPantallaInfo.Clear();
            txtPantallaInfo.AppendText(@"LEYES DE LOS EXPONENTES
───────────────────────
Forma básica: xᵐ * xⁿ = xᵐ⁺ⁿ
Objetivo primordial: Simplificar productos de potencias de igual base sumando sus exponentes.

Pasos para resolver:
  1. Identificar que las bases de los términos algebraicos sean idénticas.
  2. Mantener la base intacta.
  3. Sumar aritméticamente los exponentes numéricos.

Ejemplo resuelto:
  x⁴ * x³  →  x⁽⁴⁺³⁾  →  x⁷ ✓
───────────────────────
");

            int a = rng.Next(2, 6);
            int b = rng.Next(2, 6);

            _valA = a;
            _valB = b;

            _respuestaCorrecta = a + b;
            _tipoEjercicio = "exponentes";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA!\n");

            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.AppendText("Simplifica la expresión y escribe el exponente resultante para x:\n\n   ");

            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 18, FontStyle.Regular);
            txtPantallaInfo.AppendText("x");

            txtPantallaInfo.SelectionCharOffset = 12;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            txtPantallaInfo.AppendText(a.ToString());

            txtPantallaInfo.SelectionCharOffset = 0;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 18, FontStyle.Regular);
            txtPantallaInfo.AppendText(" * x");

            txtPantallaInfo.SelectionCharOffset = 12;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            txtPantallaInfo.AppendText(b.ToString());

            txtPantallaInfo.SelectionCharOffset = 0;
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.AppendText("\n\nEscribe el exponente numérico abajo.");
            txtRespuesta.Focus();
        }

        // LOGARITMOS
        private void button7_Click(object sender, EventArgs e)
        {
            txtPantallaInfo.Clear();
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.AppendText("LOGARITMOS NATURALES/COMUNES\n");
            txtPantallaInfo.AppendText("────────────────────────────────────────\n");
            txtPantallaInfo.AppendText("Forma básica: log(x) = c  (La base implícita siempre es 10)\n");
            txtPantallaInfo.AppendText("Objetivo primordial: Despejar 'x' aplicando la base exponencial.\n\n");
            txtPantallaInfo.AppendText("Pasos para resolver:\n");
            txtPantallaInfo.AppendText("  1. Recordar la regla fundamental: log(x) = c  ↔  x = 10ᶜ\n");
            txtPantallaInfo.AppendText("  2. Elevar el número 10 al resultado 'c' para hallar el valor de x.\n\n");

            txtPantallaInfo.AppendText("Ejemplo resuelto:\n");
            txtPantallaInfo.AppendText("  log(x) = 2  →  x = 10²  →  x = 100 ✓\n");
            txtPantallaInfo.AppendText("────────────────────────────────────────\n");

            int exponenteOculto = rng.Next(1, 4);
            int valorX = (int)Math.Pow(10, exponenteOculto);

            _valA = exponenteOculto; 

            _respuestaCorrecta = valorX;
            _tipoEjercicio = "logaritmos";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA!\n");

            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.AppendText("Resuelve la ecuación logarítmica y halla el valor de x:\n\n   ");

            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText($"log(x) = {exponenteOculto}");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("\n\nEscribe el valor numérico de x abajo.");
            txtRespuesta.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas salir del Tutor?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // AYUDA 
        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_tipoEjercicio))
            {
                MessageBox.Show("Por favor, selecciona primero un tema de la izquierda para generar un ejercicio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtPantallaInfo.SelectionColor = Color.FromArgb(0, 174, 219);
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            txtPantallaInfo.AppendText("\n\n────────────────────────────────────────\n");
            txtPantallaInfo.AppendText("💡 GUÍA PASO A PASO CON TUS DATOS:\n");
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;

            switch (_tipoEjercicio)
            {
                case "lineal":
                    txtPantallaInfo.AppendText($"  1. Despeja el término independiente:\n     Pasa el (+{_valB}) al lado derecho restando: ({_valC} - {_valB}).\n");
                    txtPantallaInfo.AppendText($"  2. Resuelve esa resta en tu mente.\n");
                    txtPantallaInfo.AppendText($"  3. El número ({_valA}) que acompaña a la x pasa a dividir a ese resultado.\n");
                    txtPantallaInfo.AppendText("  ¡Haz la división final y tendrás la respuesta!");
                    break;

                case "cuadratica":
                    txtPantallaInfo.AppendText($"  1. Tus coeficientes actuales son: a = {_valA}, b = {_valB}, c = {_valC}.\n");
                    txtPantallaInfo.AppendText($"  2. Reemplaza en la raíz: √(({_valB})² - 4 * {_valA} * {_valC}).\n");
                    txtPantallaInfo.AppendText($"  3. Esto se reduce a: √({_valB * _valB} - {4 * _valA * _valC}) = √({(_valB * _valB) - (4 * _valA * _valC)}).\n");
                    txtPantallaInfo.AppendText("  4. Saca esa raíz, súmasela a el valor de -b y divídelo entre 2. ¡Esa es tu raíz mayor!");
                    break;

                case "factorizacion":
                    txtPantallaInfo.AppendText($"  1. Tienes una diferencia de cuadrados perfectos con el número {_valA}.\n");
                    txtPantallaInfo.AppendText($"  2. La regla te pide extraer la raíz cuadrada exacta de ese número: √{_valA}.\n");
                    txtPantallaInfo.AppendText($"  3. El número que multiplicado por sí mismo da {_valA} es el valor directo de 'k'.");
                    break;

                case "sistema":
                    txtPantallaInfo.AppendText($"  1. Suma las dos ecuaciones de forma vertical:\n");
                    txtPantallaInfo.AppendText($"     (x + x) + (y - y) = ({_valA} + ({_valB}))\n");
                    txtPantallaInfo.AppendText($"  2. Como las 'y' se eliminan, te queda la ecuación lineal: 2x = {_valA + _valB}.\n");
                    txtPantallaInfo.AppendText($"  3. Pasa el 2 a dividir al resultado de la suma. ¡Ahí tienes x!");
                    break;

                case "desigualdad":
                    txtPantallaInfo.AppendText($"  1. El ejercicio plantea que {_valA} veces x es mayor o igual a {_valB}.\n");
                    txtPantallaInfo.AppendText($"  2. Para dejar sola a la x, pasa el coeficiente positivo ({_valA}) a dividir al otro lado.\n");
                    txtPantallaInfo.AppendText($"  3. La operación límite que debes resolver es: x >= {_valB} / {_valA}.");
                    break;

                case "exponentes":
                    txtPantallaInfo.AppendText($"  1. Tienes la multiplicación de x con exponentes {_valA} y {_valB}.\n");
                    txtPantallaInfo.AppendText($"  2. La ley de exponentes dice que se mantiene la base x y los exponentes se suman.\n");
                    txtPantallaInfo.AppendText($"  3. Resuelve la suma aritmética simple de tus datos: {_valA} + {_valB}.");
                    break;

                case "logaritmos":
                    txtPantallaInfo.AppendText($"  1. Tienes la ecuación log(x) = {_valA} en base 10 implícita.\n");
                    txtPantallaInfo.AppendText($"  2. Su equivalencia exponencial directa nos dice que: x = 10 al exponente de la derecha.\n");
                    txtPantallaInfo.AppendText($"  3. Planteamiento matemático: x = 10 a la potencia de {_valA}.\n");
                    txtPantallaInfo.AppendText($"  Escribe la cantidad de ceros que indica ese exponente.");
                    break;

                case "funciones":
                    txtPantallaInfo.AppendText($"  1. Reemplaza el valor x = {_valC} en la función dada.\n");
                    txtPantallaInfo.AppendText($"  2. La operación estructurada paso a paso queda así: f({_valC}) = {_valA}({_valC}) + {_valB}.\n");
                    txtPantallaInfo.AppendText($"  3. Primero realiza la multiplicación de ({_valA} * {_valC}) y luego súmale el término ({_valB}).");
                    break;
            }

            txtPantallaInfo.AppendText("\n────────────────────────────────────────");
            txtPantallaInfo.ScrollToCaret();
            txtRespuesta.Focus();
        }

        //Funcion de Enter
        private void txtRespuesta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnVerificar_Click(sender, e);
            }
        }
    }
}