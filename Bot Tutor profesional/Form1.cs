using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bot_Tutor_profesional
{
    public partial class Form1 : Form
    {
        // VARIABLES GLOBALES
        private int puntaje = 0;
        private int preguntasRespondidas = 0;
        private Random rng = new Random();

        // Variables para controlar los ejercicios activos
        private int _respuestaCorrecta;
        private string _tipoEjercicio = "";

        public Form1()
        {
            InitializeComponent();
            MostrarBienvenida();
        }

        private void MostrarBienvenida()
        {
            txtPantallaInfo.SelectionColor = Color.Cyan;
            txtPantallaInfo.AppendText("=========================================\n");
            txtPantallaInfo.AppendText("       TUTOR DE ÁLGEBRA V2.0 ACTIVADO    \n");
            txtPantallaInfo.AppendText("=========================================\n\n");
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("¡Hola! Presiona cualquiera de los temas de la izquierda para comenzar tu clase o generar ejercicios prácticos.\n\n");
        }
        // Herramienta para escribir caracteres matemáticos avanzados de forma limpia
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

            // Restaurar valores estándar
            txtPantallaInfo.SelectionCharOffset = 0;
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
        }
        //Objetos de decoracion sin funcion
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //DESIGUALDADES LINEALES
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

            int a = rng.Next(2, 6);
            int x = rng.Next(2, 8);
            int b = a * x;

            _respuestaCorrecta = x;
            _tipoEjercicio = "desigualdad";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.AppendText($"¡EJERCICIO DE PRÁCTICA ANOTADO!\nDetermina el valor límite (el número entero k) que resuelve la inecuación:\n\n");
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText($"   {a}x >= {b}\n\n");
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("Escribe la respuesta numérica abajo.");
            txtRespuesta.Focus();
        }

        //ECUACIONES CUADRÁTICAS
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

            // Generamos dos raíces positivas distintas
            int r1 = rng.Next(1, 5);
            int r2 = rng.Next(5, 9); 

            int b = -(r1 + r2);
            int c = r1 * r2;

            _respuestaCorrecta = r2;
            _tipoEjercicio = "cuadratica";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA ANOTADO!\nEncuentra la raíz MAYOR de la ecuación:\n\n");
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText($"   x² {b:+#;-#;+0}x {c:+#;-#;+0} = 0\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("Escribe el valor numérico de la raíz mayor abajo.");
            txtRespuesta.Focus();
        }

        //ECUACIONES LINEALES
        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiamos la pantalla grande 
            txtPantallaInfo.Clear();

            // Le damos formato con saltos
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

            //GENERAMOS UN EJERCICIO AUTOMÁTICO
            int a = rng.Next(1, 6);
            int x = rng.Next(1, 11);
            int b = rng.Next(1, 10);
            int c = a * x + b;

            _respuestaCorrecta = x; // Guardamos la respuesta
            _tipoEjercicio = "lineal";

            // Imprimimos el ejercicio en la pantalla 
            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.AppendText($"¡EJERCICIO DE PRÁCTICA!\nResuelve para x la siguiente ecuación:\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText($"   {a}x + {b} = {c}\n\n");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("Escribe tu respuesta numérica en el cuadro de abajo.");

            txtRespuesta.Focus();
        }

        //FACTORIZACIÓN
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

            _respuestaCorrecta = n;
            _tipoEjercicio = "factorizacion";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA ANOTADO!\nSi x² - " + b2 + " = (x - k)(x + k), ¿cuál es el valor de k?:\n\n");
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText($"   x² - {b2}\n\n");
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("Escribe tu respuesta abajo y presiona Enter.");
            txtRespuesta.Focus();
        }

        //EVALUACIÓN DE FUNCIONES
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

            _respuestaCorrecta = m * x + b;
            _tipoEjercicio = "funciones";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.AppendText($"¡EJERCICIO DE PRÁCTICA ANOTADO!\nDada la función f(x) = {m}x + {b}, evalúa f({x}):\n\n");
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.AppendText($"   f({x}) = ?\n\n");
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("Escribe el valor de f(x) abajo y presiona Enter.");
            txtRespuesta.Focus();
        }

        //Funcion del texto del bot
        private void txtPantallaInfo_TextChanged(object sender, EventArgs e)
        {

        }

        //TITULO
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Funcion de verificar
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

        //funcion de respoder del bot
        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {
            
        }

        //SISTEMAS DE ECUACIONES (2x2)
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
────────────────────────────");

            txtPantallaInfo.AppendText(Environment.NewLine);
            txtPantallaInfo.AppendText(Environment.NewLine);

            int x = rng.Next(1, 6);
            int y = rng.Next(1, 6);
            int r1 = x + y;
            int r2 = x - y;

            _respuestaCorrecta = x;
            _tipoEjercicio = "sistema";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA ANOTADO!");
            txtPantallaInfo.AppendText(Environment.NewLine);
            txtPantallaInfo.AppendText("Resuelve el sistema y determina SOLO el valor de 'x':");
            txtPantallaInfo.AppendText(Environment.NewLine);
            txtPantallaInfo.AppendText(Environment.NewLine);

            // Configuración de fuente idéntica y negrita para todo el bloque del ejercicio
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.SelectionColor = Color.LightCyan;

            // FILA 1: Dibujamos la parte superior de la llave y la primera ecuación
            txtPantallaInfo.AppendText("  ⎧  x + y = " + r1);
            txtPantallaInfo.AppendText(Environment.NewLine);

            // FILA 2: Dibujamos la parte inferior de la llave (alineada) y la segunda ecuación
            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            txtPantallaInfo.SelectionColor = Color.LightCyan;
            txtPantallaInfo.AppendText("  ⎩  x - y = " + r2);

            txtPantallaInfo.AppendText(Environment.NewLine);
            txtPantallaInfo.AppendText(Environment.NewLine);

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("Escribe tu respuesta numérica en el cuadro inferior.");
            txtRespuesta.Focus();
        }

        //EXPONENTES
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

            _respuestaCorrecta = a + b;
            _tipoEjercicio = "exponentes";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA ANOTADO!\nSimplifica la expresión y escribe el exponente resultante para x:\n\n   ");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 15, FontStyle.Bold);
            txtPantallaInfo.SelectionColor = Color.Orange;

            AppendFormatoMate("x", a.ToString());
            txtPantallaInfo.AppendText(" * ");
            AppendFormatoMate("x", b.ToString());

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("\n\nEscribe el exponente numérico abajo.");
            txtRespuesta.Focus();
        }

        //LOGARITMOS
        private void button7_Click(object sender, EventArgs e)
        {
            txtPantallaInfo.Clear();
            txtPantallaInfo.AppendText(@"LOGARITMOS
──────────
Forma básica: log_b(a) = c
Objetivo primordial: Encontrar el exponente al que se debe elevar la base 'b' para obtener el argumento 'a'.

Pasos para resolver:
  1. Plantear la equivalencia matemática: log_b(a) = c  ↔  bᶜ = a.
  2. Descubrir cuántas veces se debe multiplicar la base por sí misma para alcanzar el número interno.

Ejemplo resuelto:
  log₂ (8) = ?  →  2ᶜ = 8  →  Como 2³ = 8, el resultado es 3 ✓
──────────
");

            int baseLog = 2; // Base estándar para simplificar
            int exponenteOculto = rng.Next(2, 6);
            int argumento = (int)Math.Pow(baseLog, exponenteOculto);

            _respuestaCorrecta = exponenteOculto;
            _tipoEjercicio = "logaritmos";

            txtPantallaInfo.SelectionColor = Color.Yellow;
            txtPantallaInfo.AppendText("¡EJERCICIO DE PRÁCTICA ANOTADO!\nResuelve el cálculo del logaritmo propuesto:\n\n   ");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 15, FontStyle.Bold);
            txtPantallaInfo.SelectionColor = Color.Orange;

            // Formato nativo de logaritmo con subíndice estilizado
            AppendFormatoMate("log", "", baseLog.ToString());
            txtPantallaInfo.AppendText($"({argumento}) = ?");

            txtPantallaInfo.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtPantallaInfo.SelectionColor = Color.White;
            txtPantallaInfo.AppendText("\n\nIngresa tu resultado numérico abajo.");
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
    }
}
