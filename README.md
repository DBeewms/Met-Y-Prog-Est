# Metodología y Programación Estructurada

Bienvenido al repositorio **Metodología-Y-Programacion-Estructurada**, donde encontrarás una colección de ejercicios prácticos y ejemplos desarrollados en **C#**, **Console** y **Windows Forms** durante mi segundo semestre en Ingeniería en Sistemas de Información en la **Universidad Americana (UAM)**.

---

## 🌍 English Version

This file is also available in English. You can access the English version [here](README-English.md).

---

## Descripción del Repositorio

### Ejercicios en C#, Console y Windows Forms

Este repositorio contiene una serie de ejercicios prácticos y ejemplos que te ayudarán a comprender los conceptos básicos de la metodología de programación estructurada y su implementación en C#. Los ejercicios están desarrollados utilizando dos entornos diferentes:

- **Console**: Aplicación de consola para ejercicios básicos y pruebas rápidas.
- **Windows Forms**: Interfaces gráficas de usuario (GUI) para aplicaciones más complejas.

---

## Estructura del Repositorio

El repositorio está organizado de la siguiente manera:

**Ejemplos**: Contiene ejemplos básicos de código en C# utilizando Console y Windows Forms. Problemas básicos para entender la estructura de un programa.

**Ejercicios Prácticos**: Incluye una serie de ejercicios resueltos y desafíos para que puedas practicar. Desafíos más complejos que te ayudarán a mejorar tus habilidades de programación estructurada.

---

## Ejemplos de Código

A continuación, te presentamos un ejemplo básico de código en cada entorno:

### Console (C#)

```Console (C#)
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola, mundo en C# (Console)!");
    }
}
```

### Windows Forms (C#)

```Windows Forms (C#)
using System.Windows.Forms;

namespace HolaMundoWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, mundo en C# (Windows Forms)!");
        }
    }
}
```

---

## Capturas de Pantalla

A continuación, te muestro los logos de las tecnologías utilizadas en este repositorio:

<div style="display: flex; justify-content: center; gap: 20px;"> <img src="https://upload.wikimedia.org/wikipedia/commons/0/0d/C_Sharp_wordmark.svg" alt="Logo de C#" width="200" height="200"> <img src="https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg" alt="Logo de .NetFramework" width="200" height="200"> </div>

Estos logos representan el lenguaje C# y el framework .NetFramework, que son las principales tecnologías utilizadas en este repositorio.

---

## Cómo Contribuir

¡Tu contribución es bienvenida! Si deseas agregar nuevos ejercicios, corregir errores o mejorar la documentación, sigue estos pasos:

1. Haz un **fork** del repositorio.
2. Crea una nueva rama (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza tus cambios y haz commit (`git commit -m "Agrega nueva funcionalidad"`).
4. Sube tus cambios a tu repositorio (`git push origin feature/nueva-funcionalidad`).
5. Abre una **pull request** en GitHub.

---

## Licencia

Este proyecto está bajo la licencia **MIT**. Consulta el archivo [LICENSE](LICENSE) para más detalles.

---

¡Gracias por visitar este repositorio! Espero que encuentres útil este material para tu aprendizaje. 😎

---

## Notas al Pie

Nota 1: Este repositorio fue creado para documentar ejercicios prácticos y ejemplos de la clase Metodología y Programación Estructurada. Asimismo, para apoyar a los estudiantes de la UAM en su aprendizaje de programación estructurada.
Nota 2: Si encuentras algún error o tienes sugerencias, no dudes en abrir un issue o enviar una pull request.
