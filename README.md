# Regla 20-20-20

## Español

Esta aplicación de escritorio fue desarrollada en **C# con .NET 8 y Windows Forms** para automatizar la regla 20-20-20, una práctica pensada para reducir la fatiga visual durante el uso prolongado de pantallas.

La regla indica que, cada 20 minutos de trabajo frente al monitor, conviene mirar un objeto ubicado a 20 pies (aproximadamente 6 metros) de distancia durante 20 segundos. La aplicación se encarga de gestionar ese ciclo de forma automática y con una interfaz simple.

### Funcionalidades

- **Temporizador principal de 20 minutos** que controla el tiempo de trabajo antes del aviso de descanso visual.
- **Formulario de aviso a pantalla completa** cuando finaliza el ciclo principal, con un temporizador de 20 segundos para indicar el momento de mirar lejos.
- **Atajo de teclado `Ctrl + Shift + número`** para agregar minutos extra al temporizador principal, con un límite máximo de 10 minutos adicionales.
- **Ajuste progresivo del tiempo de mirar lejos** cuando se agregan minutos extra, sumando segundos de forma escalonada hasta un máximo de 60 segundos.
- **Pausa, reanudación y reinicio** del temporizador principal para adaptar el funcionamiento a distintas situaciones de uso.
- **Selección del sonido de aviso** al finalizar el temporizador, permitiendo personalizar la notificación según la preferencia del usuario.

## English

This desktop application was built with **C# on .NET 8 and Windows Forms** to automate the 20-20-20 rule, a simple method designed to reduce eye strain caused by long periods of screen use.

The rule suggests that every 20 minutes of screen work, you should look at something about 20 feet away for 20 seconds. The application manages that cycle automatically through a clean and practical interface.

### Features

- **20-minute main timer** responsible for tracking the work interval before the visual break reminder.
- **Full-screen reminder form** displayed when the main cycle ends, with a 20-second timer that prompts the user to look away from the screen.
- **`Ctrl + Shift + number` keyboard shortcut** to add extra minutes to the main timer, with a maximum limit of 10 additional minutes.
- **Progressive adjustment of the looking-away time** when extra minutes are added, increasing the break duration in steps until reaching a maximum of 60 seconds.
- **Pause, resume, and reset** support for the main timer, making it easy to adapt to different usage scenarios.
- **Custom alert sound selection** when the timer finishes, allowing the user to choose the notification sound that best fits their preference.