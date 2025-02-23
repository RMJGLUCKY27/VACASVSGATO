# VACASVSGATO

![image](https://github.com/user-attachments/assets/0377e4fc-8b4c-49d6-a554-71af25d924be)


Este juego sigue las bases de un juego top-down de aventura con las siguientes características:

Se desarrolla en un entorno bidimensional con una vista desde arriba (top-down).
Uso de Tilesets: Se ha implementado un tileset para el terreno y estructuras del escenario.
Grid con Tilemaps: Existen al menos dos tilemaps:
Uno para el suelo, que define el área jugable.
Otro para paredes o elevaciones, que limitan el movimiento del jugador.

Características implementadas en el juego:
Movimiento del personaje:

El jugador controla un gato que se desplaza arriba, abajo, izquierda y derecha con las teclas WASD o flechas del teclado.
Su sprite cambia dependiendo de la última dirección en la que se movió.(   NO SE PUDIERON HACER :(   )


Interacción con enemigos (vacas):

Se han añadido enemigos estáticos (vacas) que permanecen en su lugar hasta que el jugador entra en un radio de 3 unidades de distancia.
Al detectarlo, empiezan a perseguirlo con la intención de expulsarlo de la pantalla.









EL SCRIPT PLAYER1 HACE LO SIG:

movSpeed es una variable pública que determina la velocidad de movimiento del personaje. 
speedX y speedY almacenan la velocidad en los ejes X e Y respectivamente.
rb es una referencia al componente Rigidbody2D del personaje, que se usa para aplicar el movimiento.
En el método Start(), que se ejecuta al inicio del juego, se obtiene el Rigidbody2D del objeto y se almacena en rb.

En el método FixedUpdate(), que se ejecuta a intervalos regulares para cálculos físicos, se obtiene la entrada del jugador a través de Input.GetAxisRaw("Horizontal") y Input.GetAxisRaw("Vertical"). Estos valores indican la dirección en la que el jugador quiere moverse (izquierda, derecha, arriba o abajo). Luego, se multiplican por movSpeed para determinar la velocidad final en cada eje.

Finalmente, se asigna esta velocidad a rb.velocity, lo que provoca el desplazamiento del personaje en la dirección deseada dentro del juego.










EL SCRIPT DE ENEMY HACE:
Variables principales

jugador: almacena la referencia al objeto del jugador en la escena.
radioDeteccion: define la distancia dentro de la cual el enemigo detectará al jugador.
velocidad: determina la rapidez con la que el enemigo se moverá hacia el jugador.
persiguiendo: indica si el enemigo ha detectado al jugador y debe comenzar a seguirlo.
Método Start()

Busca un objeto llamado "PLAYER" en la escena y almacena su Transform en jugador.
Si el objeto no se encuentra, se muestra un mensaje de error en la consola.
Método Update()

Si el jugador no ha sido encontrado, el código termina (return).
Calcula la distancia entre el enemigo y el jugador con Vector3.Distance().
Si el jugador está dentro del radioDeteccion, se activa la persecución.
Si el enemigo está en modo persecución (persiguiendo = true), se mueve hacia la posición del jugador usando Vector3.MoveTowards().
Método RecibirDaño()

Se ejecuta cuando el enemigo recibe un ataque.
Muestra un mensaje en la consola indicando que el enemigo ha sido atacado.
Usa Destroy(gameObject) para eliminar el enemigo de la escena.
Método OnTriggerEnter(Collider other)

Se ejecuta cuando otro objeto entra en contacto con el enemigo.
Si el objeto tiene la etiqueta "AtaqueJugador", el enemigo recibe daño y se destruye.
