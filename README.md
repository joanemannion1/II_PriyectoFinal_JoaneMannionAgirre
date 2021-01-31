# II_PriyectoFinal_JoaneMannionAgirre
 Interfaces Inteligentes, proyecto final
 Autora: Joane Mannion Agirre - alu0101451701
 
## Cuestiones importantes para el uso
El objetivo del proyecto final de la asignatura es realizar un juego de Realidad Virtual (RV) que integre técnicas que se han ido desarrollando en las diferentes prácticas de RV. Para ello, hemos creado un juego en unity que consiste en conseguir puntos en un laverinto para poder pasar al siguiente nivel.
Para conseguir dichos puntos, habra bolas rojas esparcidas por el mapa de forma aleatoria, cada bola que recogamos nos proporcionara 10 puntos y cuando obtengamos 50 puntos aparecera un tesoro (en forma de un cubo amarillo) en algun punto del mapa. Al encontrar el tesoro automaticamente pasaremos al siguiente nivel.
La manera de movernos por el mapa sera moviendo el movil (????) o mediante la utilización de la voz. Es decir, nuestro jugador siempre estara moviendose en la dirección en la que estemos mirando, podremos controlar este movimiento utilizando cuatro palabras claves:
- **parar**: el jugador se detendra. 
- **empezar**: el jugador volvera a moverse. 
- **rapío**: la velocidad en la que se mueve nuestro jugador aumentara. 
- **lento**: la velocidad en la que se mueve nuestro jugador disminuira. 
 
## Elavoraicón del proyecto 
### Configuración del proyecto
Al crear nuestro proyecto Unity tendremos que configurarlo para poder realizar una aplicación VR. Primero tendremos que indicar que el proyecto que vamos a realizar está destinado a dispositivos Android por lo que vamos a *File -> Build Settings*. Una vez ahí debemos seleccionar **Android** y hacer click en el botón *Switch Platform*.

Después, tendremos que hacer click en *Player Settings* esto nos abrirá una sección para configurar las propiedades de nuestra aplicación Android. De entre todos los deplegables abriremos *Other Settings*. Aquí, seleccionaremos y eliminaremos las opciones *Vulcan* y *OpenGLES3*. Después, añadiremos **OpenGLES2**.

Una vez hecho esto, desplegaremos el apartado *XR Settings*. Ahí activaremos donde pone *Virtual Reality Supported* y pinchando en el pequeño símbolo + que aparece bajo List is Empty añadiremos **Cardboard**.

Una vez lo tenemos todo lo anterior configurado, procederemos a descargarnos el paquete de **Google VR** para Unity que ofrece el propio Google desde Github ((https://github.com/googlevr/gvr-unity-sdk/releases)). Para esto, entraremos a la web del repositorio y descargaremos el unitypackage de la última versión. Tras descargarlo, tendremos que importarlo desde *Assets -> Import package -> Custom Package* .

Ahora, sera necesario configurar la escena. Primero crearemos un objeto vacío que hara de padre de la camára (llamado *Player*), después añadiremos como hijo de la cámara el GameObject **GvrReticlePointer**. Después añadiremos a la raíz los GameObjects **GvrEditorEmulator** y **GvrEventSystem**. Para finalizar, añadiremos el Script **GvrPointerPhysicsRaycaster** a la cámara. Así queda la jerarquía:

### Creación de las escenas
Para este juego he realizado tres escenas, pero se podrian crear muchas mas dependiendo de la cantidad de niveles que quieras añadir.
- **Menu**: La primera escena sera el menu inicial del juego. Aquí hemos añadido un *Canvas* que contendra las instrucciónes de como jugar. También tendrá el botón que iniciara el juego (START GAME). Para empezar a jugar podremos hacer click en el botón, o podremos utilizar nuestra voz, es decir, con decir la palabra *Empezar* se cambiará a la primera escena que contendra el Nivel 1.
- **Nivel 1**: En el primer nivel hemos creado un terreno montañoso. Para ello hemos utilizado descargado desde el Asset Store el paquete *Terrain Tools Sample Asset Pack* y lo hemos importado al proyecto. Este paquete nos permitira crear terrenos más realistas. También hemos hecho uso del paquete *Standard Assets* para añadir árboles que den un toque mas dramático. Las montañas de esta escena seran muy perpendiculares, así creando la sensación de laverinto, ya que el jugador solo puede moverse por el terreno llano.
- **Nivel 2**: Para el segundo nivel, la escena la hemos hecho totalmente distinta. En este mundo hemos creado con la utilización de cubos de colores, altas paredes de color azul. El objetivo es que al ser las paredes mucho mas parecidas sea mas dificil orientarse en el laverinto.

### Los Scripts y Sensores utilizados en el proyecto.
Este proyecto consta de 7 scripts que permiten el funcionamiento de nuestro juego. En el siguiente punto explicaremos el objetivo de cada script.
- **BallScript**: Este script lanzará un evento cuando el jugador recoga una esfera. Así podremos incrementar el marcador de la pantalla cada vez que recogamos una esfera. 
- **BrujulaScript**: Con este script, hemos conseguido que la brujula siempre señale al Polo Norte, así ayudando al jugador a orientarse en el mapa. La brujula es un componente del móvil, y mediante los datos obtenidos de este componente hemos conseguido mover la brújula de nuestro juego.
- **InicioScript**:Este script se encargará de que el botón de inicio del juego funcione correctamente tanto haciendo click como mediante el reconocimiento de voz. 
- **RandomObject**: Mediante este script, crearemos el número indicado de esferas en nuestro mapa de forma aleatoria. Es decir, cada vez que ejecutemos el juego las esferas se encontaran en puntos diferentes a la ejecución anterior. 
- **TextScript**: Con este script controlaremos el marcador de la pantalla. Este tendra un contador, que cada vez que el jugador coja una esfera incrementara 10 puntos. Cuando el marcador llegue a los 50 puntos, lanzará un evento que mostrara el tesoro.
- **TreasureScript**: Este script mostrara el tesoro cuando el jugador obtenga los 50 puntos, después esperara a que el jugador encuentre el tesoro y cuande el jugador haga click en el tesoro nos enviara al siguiente nivel. 
- **VRLookWalk**: Mediante este script haremos que el jugador se mueva a dónde nostros miremos. También nos permitira controlar el jugador mediante el reconocimiento de voz utilizando los cuatro comandos explicados anteriormente.

### Hitos de programación logrados relacionándolos con los contenidos que se han impartido.
En este proyecto final he tenido como objetivo utilizar elementos que hemos utilizado durante las prácticas de la asignatura. Por lo tanto he añadido delegados y eventos, sensores (brujula) y reconocimiento de voz al proyecto. Como he explicado en el punto anterior, mediante los delegados y eventos hemos conseguido que diferentes objetos de la escena se comuniquen. Así he conseguido que cada vez que una bola es recogida, la puntuación aumente y cuando la puntuación llegue a 50, el tesero aparezca.
Con el uso de la brujula he conseguido facilitar la orientación del jugador en el laverinto, ya que así sabe en que dirección se esta moviendo en todo momento.
Para finalizar, con el reconocimiento de voz hemos conseguido que el movimiento de nuestro jugador sea mas cómodo y mas rápido, ya que no hace falta hacer click en nada sino con el uso de nuestra voz podemos cambiar el movimiento de nuestro jugador.

## Acta de los acuerdos del grupo respecto al trabajo en equipo.
Este trabajo ha sido realizado de manera individual, por lo tanto yo me he encargado de la realización del proyecto, de las pruebas y de la creación de la documentación.

## Gif animado de ejecución

