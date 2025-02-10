# Prueba_Codifico
Prueba Desarrollador Codifico

Para el funcionamiento:

1. Ejecutar el Script adjunto que tiene dentro de si la base de datos, (si la base de datos ya esta creada solo es necesario ejecutar el apartado ---PARA LA API ya que este tiene algunas vistas y sp que se usan en el BackEnd), dentro de este también se encuentran las consultas solicitadas en la prueba

2. Entrar en la carpeta BackEnd y luego abrir el proyecto de Visual Studio, luego, es necesario cambiar la cadena de conexión con la de su computador o servidor: provider connection string=&quot;data source=(aquí debería ir el servidor y el usuario y contraseña en caso de ser necesario); esto debe hacerse en el archivo Web.config de la capa Prueba.Codifico.API y en el archivo App.config de la capa Prueba.Codifico.DAL, esto con el fin de que el modelo de datos pueda usar la base de datos que esta creada en su ordenador/servidor.

3. Es necesario ejecutar el proyecto de Visual Studio, esto para que nuestra API este activa y pueda recibir los datos.

4. Se debe cambiar el enrutamiento de las APIS con la url de su servidor esto debe hacerse en todos los componentes de la carpeta components, dentro de los archivos ts, es necesario que solo cambie la ruta del servidor, se debe mantener el enrutamiento creado en el backend, por ejemplo: api/getorderscustomers.

5. Después de concluidos los primeros 4 pasos, ya debería ser posible ejecutar el comando ng serve y usar la aplicación.


Explicación Breve:

1. Ejecute el script de la base de datos y luego cree las consultas y el script Transact SQL que solicitaron, luego, para usarlos en la api, cree vistas para las consultas y un store procedure para la inserción de datos.

2. Luego, cree el BackEnd en ASP.NET Entity Framework usando la plantilla para APIs, allí utilice la arquitectura por capas, la primera capa contiene el controlador de la API y sus peticiones correspondientes, la segunda capa contiene la lógica del negocio que sirve como puente para la comunicación y procesamiento de datos con la capa de Datos. En la capa de datos se encuentra la conexión a la base de datos que se hizo a traves de un modelo ADO.NET, allí están todas las consultas y demás métodos utilizados para consultar nuestra base de datos. La ultima capa es la de Entidades, implementada como una medida de seguridad para usar las entidades generadas por el modelo creado en la capa de Datos.

3. Por ultimo, la creación del FrontEnd, en la version más reciente de Angular, por lo que no use módulos ni componentes standalone.


